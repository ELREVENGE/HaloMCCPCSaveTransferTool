using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using X360.STFS;
using X360.IO;
using System.Drawing;

namespace HaloMCCPCSaveTransferTool
{
    public static class HaloX360FileIO
    {
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
        public static bool Export(ContainerInfo containerInfo, string destinationPath)
        {
            if (File.Exists(containerInfo.path) && destinationPath != null)
            {
                if (File.Exists(destinationPath)) { throw new Exception("File already exists"); } // should not write over any files without prompting the user 
                using (MemoryStream x360FileStream = new MemoryStream(containerInfo.file.GetTempIO(true).ReadStream(), false))
                {
                    FileStream file = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
                    x360FileStream.WriteTo(file);
                    file.Close();
                    x360FileStream.Close();
                }
                return true;
            }
            throw new Exception("Failed to export file to " + destinationPath);
        }
        #region PC Utilities
        static readonly char[] InvalidFileNameCharacters = Path.GetInvalidFileNameChars();
        public static bool FileNameValid(string fileName)
        {
            if (fileName != null)
            {
                for (int i = 0; i < InvalidFileNameCharacters.Length; i++)
                {
                    if (fileName.Contains(InvalidFileNameCharacters[i])) return false;
                }
                return true;
            }
            return false;
        }
        #endregion
        #region Screenshot Extraction
        public static Image Get16x9Thumbnail(Image img, int size)
        {
            if (img != null && size > 0 && size * 16 < 256)
            {
                return img.GetThumbnailImage(16 * size, 9 * size, null, new IntPtr());
            }
            return null;
        }
        public static Image ExtractImageFromScreenShotFile(STFSPackage Container)
        {
            try
            {
                FileEntry[] files = Container.RootDirectory.GetSubFiles();
                if (files.Length == 1 && files[0].Name == "screen.shot")
                {
                    return ExtractImageFromScreenShotFile(new MemoryStream(files[0].GetTempIO(true).ReadStream(), false));
                }
                return null;
            }
            catch { return null; }
        }
        public static Image ExtractImageFromScreenShotFile(MemoryStream fileStream)
        {
            if (fileStream == null) return null;
            try
            {
                List<byte> image = new List<byte>();
                // 0xFF 0xD8 Start of Image (SOI)
                // 0xFF 0xD9 End of Image (EOI)
                byte[] buff = new byte[2];
                BinaryReader br = new BinaryReader(fileStream);
                bool imgBytes = false;
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    byte bCurrent = br.ReadByte();
                    buff[0] = buff[1];
                    buff[1] = bCurrent;
                    if (buff[0] == 0xFF)
                    {
                        if (bCurrent == 0xD8) //SOI
                        {
                            image.Clear();
                            imgBytes = true;
                            image.Add(0xFF); //will add current byte at end of while loop
                        }
                        if (bCurrent == 0xD9) //EOI
                        {
                            image.Add(bCurrent); //already have 0xFF byte
                            break;
                        }
                    }
                    if (imgBytes) image.Add(bCurrent);
                }
                return (Bitmap)((new ImageConverter()).ConvertFrom(image.ToArray()));
            }
            catch
            {
                return null;
            }
        }
        #endregion
        #region 360 Drive Utilities
        public static List<ContainerInfo> GetAllContainersInfoFromDirectory(string directory)
        {
            MainWindow.Output.WriteLine("Gathering Files");
            List<string> allFiles = GetAllFiles(directory);
            MainWindow.Output.WriteLine("All files Gathered, scanning for potential containers");
            List<string> potentialContainerFiles = GetPotentialContainerFiles(allFiles);
            MainWindow.Output.WriteLine("All Potential Containers Gathered, Gathering Container Info from containers");
            List<ContainerInfo> containersInfo = GetContainerInfoFromPotentialContainers(potentialContainerFiles);
            MainWindow.Output.WriteLine("All Container Files gathered");
            return containersInfo;
        }
        public static HaloFiles GetHaloFilesFromDirectory(string directory)
        {
            if (Directory.Exists(directory))
            {
                List<ContainerInfo> containers = GetAllContainersInfoFromDirectory(directory);
                return GetHaloFilesFromContainers(containers);
            }
            else { return new HaloFiles(); }
        }
        public static HaloFiles GetHaloFilesFromContainers(List<ContainerInfo> package)
        {
            HaloFiles haloFiles = new HaloFiles();

            // Halo: Reach
            MainWindow.Output.WriteLine("Searching for Halo: Reach files");
            List<ContainerInfo> reachFiles = GetContainersForTitle(package, "Halo: Reach");
            haloFiles.Reach.Maps = GetMatchingContents(reachFiles, "sandbox.map");
            haloFiles.Reach.GameTypes = GetMatchingContents(reachFiles, "variant");
            haloFiles.Reach.Screenshots = GetMatchingContents(reachFiles, "screen.shot");
            // Halo 3
            MainWindow.Output.WriteLine("Searching for Halo 3 files");
            List<ContainerInfo> h3Files = GetContainersForTitle(package, "Halo 3");
            haloFiles.Halo3.Maps = GetMatchingContents(h3Files, "sandbox.map");
            haloFiles.Halo3.GameTypes = GetMatchingContents(h3Files, "variant", false);
            haloFiles.Halo3.Screenshots = GetMatchingContents(h3Files, "screen.shot");
            // Halo 3 ODST
            MainWindow.Output.WriteLine("Searching for Halo 3 ODST files");
            List<ContainerInfo> h3ODSTFiles = GetContainersForTitle(package, "Halo 3: ODST");
            haloFiles.Halo3ODST.Screenshots = GetMatchingContents(h3ODSTFiles, "screen.shot");

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
            catch { }
            return retVal.ToArray();
        }
        public static List<ContainerInfo> GetContainersForTitle(List<ContainerInfo> containers, string titleName)
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
        public static List<ContainerInfo> GetMatchingContents(List<ContainerInfo> containers, string contents, bool exact = true)
        {
            List<ContainerInfo> MatchingFiles = new List<ContainerInfo>();
            string[] containerContents;
            ContainerInfo container;
            for (int i = 0; i < containers.Count; i++)
            {
                container = containers[i];
                try { containerContents = GetContentsNames(container.CON); }
                catch { containerContents = null; }
                if (containerContents != null && containerContents.Length == 1)
                {
                    if (exact && containerContents[0] == contents)
                    {
                        container.file = container.CON.GetFiles(container.CON.RootDirectory.FolderPointer)[0];
                        MatchingFiles.Add(container);
                    }
                    else if (!exact && containerContents[0].Contains(contents))
                    {
                        container.file = container.CON.GetFiles(container.CON.RootDirectory.FolderPointer)[0];
                        MatchingFiles.Add(container);
                    }
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
                for (int i = 0; i < directoriesToSearch.Length; i++)
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
                        containerFiles.Add(new ContainerInfo() { path = currentFile, CON = package, file = files[0] });
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
                    {
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
                }
                catch { return false; }
            }
            return false;
        }
        #endregion
        #region Structs
        public struct ContainerInfo
        {
            public string path;
            public STFSPackage CON;
            public FileEntry file;
        }
        public struct GameFiles
        {
            public List<ContainerInfo> Maps;
            public List<ContainerInfo> GameTypes;
            public List<ContainerInfo> Screenshots;
            public GameFiles(bool initLists) : this()
            {
                if (initLists)
                {
                    Clear();
                }
            }

            public void Clear()
            {
                GameTypes = new List<ContainerInfo>();
                Maps = new List<ContainerInfo>();
                Screenshots = new List<ContainerInfo>();
            }
        }
        public struct HaloFiles
        {
            public GameFiles Reach;
            public GameFiles Halo3;
            public GameFiles Halo3ODST;

            public HaloFiles(bool initLists) : this()
            {
                if (initLists)
                {
                    Clear();
                }
            }

            public void Clear()
            {
                Reach.Clear();
                Halo3.Clear();
                Halo3ODST.Clear();
            }
        }
        #endregion
    }
}
