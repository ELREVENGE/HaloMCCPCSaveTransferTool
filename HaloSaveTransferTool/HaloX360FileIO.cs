using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X360.STFS;
using X360.IO;

namespace HaloSaveTransferTool
{
    public static class HaloX360FileIO
    {
        /*
         * get all files (looks for files in directory and subdirectories)
         * get potential container files (looks for CON)
         * get Container info from potential containers (grabs location and container data
         * Look for contents of container that match names
         */
        public static bool ValidXUID(string XUID)
        {
            if (XUID.Length == 16)
            {
                char c;
                for (int i = 0; i < XUID.Length; i++)
                {
                    c = XUID[i];
                    if (!((c >= '0' && c <= '9') ||
                          (c >= 'a' && c <= 'f') ||
                          (c >= 'A' && c <= 'F'))) return false;
                }
                return true;
            }
            return false;
        }
        static readonly char[] InvalidFileNameCharacters = Path.GetInvalidFileNameChars();
         public static bool FileNameValid(string fileName)
        {
            if (fileName != null)
            {
                for(int i = 0; i < InvalidFileNameCharacters.Length; i++)
                {
                    if (fileName.Contains(InvalidFileNameCharacters[i])) return false;
                }
                return true;
            }
            return false;
        }
        public static bool Export(ContainerInfo containerInfo, string destinationPath)
        {
            if (File.Exists(containerInfo.path) && destinationPath != null)
            {
                if (File.Exists(destinationPath)) { throw new Exception("File already exists"); } // we should not write over any files without prompting the user 
                using (MemoryStream x360FileStream = new MemoryStream(containerInfo.file.GetTempIO(true).ReadStream(), false))
                {
                    FileStream file = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
                    x360FileStream.WriteTo(file);
                    file.Close();
                    x360FileStream.Close();
                    return true;
                }
            }
            throw new Exception("Failed to export file to " + destinationPath);
        }
        #region non async functions
        public static List<ContainerInfo> GetAllContainersInfoFromDirectory(string directory)
        {
            
            MainWindow.Output.WriteLine("Gathering Files");
            List<string> allFiles = GetAllFiles(directory);
            MainWindow.Output.WriteLine("All files Gathered, scanning for potential containers");
            List<string> potentialContainerFiles = GetPotentialContainerFiles(allFiles);
            MainWindow.Output.WriteLine("All Potential Containers Gathered, Gathering Container Info from containers");
            
            //

            List<ContainerInfo> containersInfo = GetContainerInfoFromPotentialContainers(potentialContainerFiles);
            MainWindow.Output.WriteLine("All Container Files gathered");
            return containersInfo;
        }
        public static List<ContainerInfo> GetAllTitleContainersFromDirectory(string directory, string titleName)
        {
            return GetContainersForTitle(GetAllContainersInfoFromDirectory(directory), titleName);
        }
        public static List<ContainerInfo> MultiAttemptGetContainers(List<string> potentialContainers)
        {
            bool success = false;
            while (!success)
            {
                try { return GetContainerInfoFromPotentialContainers(potentialContainers); } catch { }
            }
            return null;
        }
        public static HaloFiles GetHaloFilesFromDirectory(string directory)
        {
            List<ContainerInfo> containers= GetAllContainersInfoFromDirectory(directory);
            return GetHaloFilesFromContainers(containers);
        }
        public static HaloFiles GetHaloFilesFromContainers(List<ContainerInfo> package)
        {
            HaloFiles haloFiles = new HaloFiles();
            List<ContainerInfo> reachFiles = GetContainersForTitle(package, "Halo: Reach");
            haloFiles.reachMaps = GetMatchingContents(reachFiles, "sandbox.map");
            haloFiles.reachGametypes = GetMatchingContents(reachFiles, "variant");
            return haloFiles;

        }
        public static string[] GetContentsNames(STFSPackage package)
        {
            MainWindow.Output.WriteLine("Getting Container files from package " + package.Header.Title_Display);
            List<string> retVal = new List<string>();
            try
            {
                FileEntry[] fileEntries = package.GetFiles(package.RootDirectory.FolderPointer);
                for (int i = 0; i < fileEntries.Length; i++)
                {
                    try { retVal.Add(fileEntries[i].Name); } catch { }
                }
            }
            catch {  }
            return retVal.ToArray();
        }
        public static List<ContainerInfo> GetContainersForTitle(List<ContainerInfo> containers,string titleName)
        {
            List<ContainerInfo> result = new List<ContainerInfo>();
            ContainerInfo container;
            for (int i = 0; i < containers.Count; i++)
            {
                container = containers[i];
                if (container.CON.Header.Title_Package == titleName)
                {
                    result.Add(container);
                }
            }
            return result;
        }
        public static List<ContainerInfo> GetMatchingContents(List<ContainerInfo> containers, string contents)
        {
            List<ContainerInfo> MatchingFiles = new List<ContainerInfo>();
            string[] containerContents;
            ContainerInfo container;
            for (int i = 0; i < containers.Count; i++)
            {
                container = containers[i];
                try { containerContents = GetContentsNames(container.CON); }
                catch { containerContents = null; }
                if (containerContents != null && containerContents.Length == 1 && containerContents[0] == contents)
                {
                    container.file = container.CON.GetFiles(container.CON.RootDirectory.FolderPointer)[0];
                    MatchingFiles.Add(container);
                }
            }
            return MatchingFiles;
        }
        public static List<string> GetAllFiles(string directoryToSearch)
        {
            List<string> filesFound = new List<string>();
            if (Directory.Exists(directoryToSearch))
            {
                filesFound.AddRange(Directory.GetFiles(directoryToSearch));
                string[] directoriesToSearch = Directory.GetDirectories(directoryToSearch);
                for(int i = 0; i < directoriesToSearch.Length; i++)
                {
                    filesFound.AddRange(GetAllFiles(directoriesToSearch[i]));
                }
            }
            return filesFound;
        }
        public static List<string> GetPotentialContainerFiles(List<string> files)
        {
            List<string> potentialContainerFiles = new List<string>();
            string currentFile;
            for (int i = 0; i < files.Count; i++)
            {
                currentFile = files[i];
                if (FirstLettersContainerCheck(currentFile))
                {
                    potentialContainerFiles.Add(currentFile);
                }
            }
            return potentialContainerFiles;
        }
        public static List<ContainerInfo> GetContainerInfoFromPotentialContainers(List<string> potentialContainerFiles)
        {
            List<ContainerInfo> containerFiles = new List<ContainerInfo>();
            STFSPackage package = null;
            string currentFile;
            for (int i = 0; i < potentialContainerFiles.Count; i++)
            {
                try
                {
                    currentFile = potentialContainerFiles[i];
                    package = GetContainer(currentFile);
                    if (package != null)
                    {
                        FileEntry[] files = package.RootDirectory.GetSubFiles();
                        containerFiles.Add(new ContainerInfo() { path = currentFile, CON = package });
                    }
                }
                catch { }
            }
            return containerFiles;
        }
        public static STFSPackage GetContainer(string file)
        {
            MainWindow.Output.WriteLine("Getting Container from path " + file);
            try
            {
                    using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        fileStream.Seek(0, SeekOrigin.Begin);
                        BinaryReader br = new BinaryReader(fileStream);
                        byte[] fileInMemory = br.ReadBytes((int)fileStream.Length);
                        if (fileInMemory.Count() != fileStream.Length)
                            throw new EndOfStreamException();
                        STFSPackage CON = new STFSPackage(new DJsIO(fileInMemory, true), new X360.Other.LogRecord());
                        return CON;
                    }
            }
            catch { return null; }
        }
        public static bool FirstLettersContainerCheck(string file)
        {
            if (File.Exists(file))
            {
                try
                {
                    using (var stream = File.OpenRead(file))
                    using (var reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        char[] buffer = new char[3];
                        int n = reader.ReadBlock(buffer, 0, 3);
                        if (buffer[0] == 'C' && buffer[1] == 'O' && buffer[2] == 'N')
                        {
                            return true;
                        }
                    }
                }
                catch { return false; }
            }
            return false;
        }
        public struct ContainerInfo
        {
            public string path;
            public STFSPackage CON;
            public FileEntry file;
        }
        
        public struct HaloFiles
        {
            public List<ContainerInfo> reachMaps;
            public List<ContainerInfo> reachGametypes;
        }
    }
    #endregion 
}
