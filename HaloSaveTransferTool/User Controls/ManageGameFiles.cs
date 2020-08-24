using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.VisualBasic.FileIO;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ManageGameFiles : UserControl
    {
        public struct InGameNameAndDescription
        {
            public string InGameName;
            public string Description;
            public InGameNameAndDescription(string inGameName, string description)
            {
                InGameName = inGameName;
                Description = description;
            }
        }
        string GameName = "";
        internal string FilesDirectory = "";
        string FileExtention = "";
        static OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true, RestoreDirectory = true };
        ManageGameFiles MoveDirectoryManageGameFiles; 
        List<string> IgnoreList = new List<string>();
        #region Initialization and setup
        public ManageGameFiles()
        {
            InitializeComponent();
            SetUp();
        }
        void SetUp()
        {
            if (this != null)
            {
                LocationLinkLabel.Text = GameName;
                UpdateList();
            }
        }
        public void Set(string gameName, string filesDirectory, string fileExtention, List<string> ignoreList, ManageGameFiles moveDirectoryManageGameFiles)
        {
            GameName = gameName;
            FilesDirectory = filesDirectory ?? "";
            IgnoreList = ignoreList ?? new List<string>();
            FileExtention = fileExtention ?? "";
            MoveDirectoryManageGameFiles = moveDirectoryManageGameFiles;
            SetUp();
        }
        public void Set(string gameName, string filesDirectory, string fileExtention, string ignoreListFile, ManageGameFiles moveDirectoryManageGameFiles)
        {
            //repeat normal set to make sure values can be used for debugging if ignore list has issues
            GameName = gameName;
            FilesDirectory = filesDirectory ?? "";
            IgnoreList = GetIgnoreListFromFile(ignoreListFile);
            FileExtention = fileExtention ?? "";
            MoveDirectoryManageGameFiles = moveDirectoryManageGameFiles;
            SetUp();
        }
        #endregion
        void UpdateLists()
        {
            UpdateList();
            if (MoveDirectoryManageGameFiles != null) MoveDirectoryManageGameFiles.UpdateList();
        }
        internal void UpdateList()
        {
            if (Directory.Exists(FilesDirectory))
            {
                Enabled = true;
                List<string> files = new List<string>();
                foreach (string file in Directory.GetFiles(FilesDirectory, @"*." + FileExtention))
                {
                    files.Add(file);
                }
                foreach (string file in IgnoreList)
                {
                    files.Remove(FilesDirectory + @"\" + file);
                }
                FileList.ClearSelection();
                FileList.Rows.Clear();
                InGameNameAndDescription inGameNameAndDescription;
                foreach (string file in files)
                {
                    inGameNameAndDescription = new InGameNameAndDescription("","");
                    if (GameName == "Halo: Reach")
                    {
                        inGameNameAndDescription = GetReachInGameNameAndDescription(file);
                    }
                    else if (GameName == "Halo 3")
                    {
                        inGameNameAndDescription = Get3InGameNameAndDescription(file);
                    }
                    FileList.Rows.Add(inGameNameAndDescription.InGameName, inGameNameAndDescription.Description, Path.GetFileNameWithoutExtension(file), File.GetLastWriteTime(file).ToString("yy/MM/dd HH:mm:ss"));
                }
                UpdateAllButtons();
            }
            else { Enabled = false; }
        }
        private void UpdateAllButtons()
        {
            bool exists = Directory.Exists(FilesDirectory);
            bool filesListed = FileList.SelectedRows.Count > 0;
            AddButton.Enabled = exists;
            DeleteButton.Enabled = (exists && filesListed);
            MoveButton.Enabled = (exists && filesListed && Directory.Exists(GetMoveLocation()));
        }
        string GetMoveLocation()
        {
            if (MoveDirectoryManageGameFiles == null)
            {
                return "";
            }
            return MoveDirectoryManageGameFiles.FilesDirectory;
        }
        #region Buttons
        private void Move_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = FileList.SelectedRows.Count;
            string moveLocation = GetMoveLocation();
            if (selectedRowsCount > 0 && Directory.Exists(moveLocation))
            {
                string fileName;
                string destinationPath;
                string sourcePath;
                List<ManageFailedWindow.ManageFailedException> exceptions = new List<ManageFailedWindow.ManageFailedException>();
                for(int i = 0; i < selectedRowsCount; i++)
                {
                    fileName = FileList.SelectedRows[i].Cells[2].Value.ToString();
                    sourcePath = FilesDirectory + @"\" + fileName + "." + FileExtention;
                    destinationPath = moveLocation + @"\" + fileName + "." + FileExtention;
                    if (File.Exists(sourcePath) && !File.Exists(destinationPath))
                    {
                        try
                        {
                            File.Move(sourcePath, destinationPath);
                            MainWindow.Output.WriteLine("Successfully moved " + fileName + " from " + FilesDirectory + "  to " + moveLocation);
                        }
                        catch (Exception ex)
                        {
                            MainWindow.Output.WriteLine("Failed to move " + fileName + " from " + FilesDirectory + "  to " + moveLocation);
                            exceptions.Add(new ManageFailedWindow.ManageFailedException("Failed to move file because: " + ex.Message, ex, sourcePath, moveLocation, new InGameNameAndDescription(FileList.SelectedRows[i].Cells[0].Value.ToString(), FileList.SelectedRows[i].Cells[1].Value.ToString())));
                        }
                    }
                    else
                    {
                        MainWindow.Output.WriteLine("Failed to move " + fileName + " from " + FilesDirectory + " to " + moveLocation);
                        exceptions.Add(new ManageFailedWindow.ManageFailedException("Failed to move file because the file doesn't exist", new Exception("File doesn't exist"), sourcePath, moveLocation, new InGameNameAndDescription(FileList.SelectedRows[i].Cells[0].Value.ToString(), FileList.SelectedRows[i].Cells[1].Value.ToString())));
                    }
                }
                //attempt to resolve exceptions
                if (exceptions.Count > 0) ManageFailedWindow.OpenDialog(exceptions, FilesDirectory, moveLocation, ManageFailedWindow.Operation.Move);
                UpdateLists();
                MainWindow.Output.WriteLine("Move operation complete");
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = FileList.SelectedRows.Count;
            if (selectedRowsCount > 0)
            {
                if (Properties.Settings.Default.WarnBeforeDeleting && MessageBox.Show("Are you sure you want to delete the selected files?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    //user didn't press yes
                    MainWindow.Output.WriteLine("Delete operation canceled");
                    return;
                }
                string fileName;
                string path;
                List<ManageFailedWindow.ManageFailedException> exceptions = new List<ManageFailedWindow.ManageFailedException>();
                for (int i = 0; i < selectedRowsCount; i++)
                {
                    fileName = FileList.SelectedRows[i].Cells[2].Value.ToString();
                    path = FilesDirectory + @"\" + fileName + "." + FileExtention;
                    RecycleOption recycleOption = Properties.Settings.Default.UseRecyclingBin ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;
                    if (File.Exists(path))
                    {
                        try
                        {
                            FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, recycleOption);
                            MainWindow.Output.WriteLine("Successfully deleted " + fileName + " from " + FilesDirectory);
                        }
                        catch(Exception ex)
                        {
                            MainWindow.Output.WriteLine("Failed to delete " + fileName + " (full path: " + path + ")");
                            exceptions.Add(new ManageFailedWindow.ManageFailedException("Failed to delete file because: " + ex.Message, ex, path, path, new InGameNameAndDescription(FileList.SelectedRows[i].Cells[0].Value.ToString(), FileList.SelectedRows[i].Cells[1].Value.ToString())));
                        }
                    }
                    else
                    {
                        MainWindow.Output.WriteLine("Failed to delete " + fileName + " File doesn't exist (full path: " + path + ")");
                        exceptions.Add(new ManageFailedWindow.ManageFailedException("Failed to delete file because the file doesn't exist", new Exception("File doesn't exist"), path, path, new InGameNameAndDescription(FileList.SelectedRows[i].Cells[0].Value.ToString(), FileList.SelectedRows[i].Cells[1].Value.ToString())));
                    }
                }
                //attempt to resolve exceptions
                if (exceptions.Count > 0) ManageFailedWindow.OpenDialog(exceptions, FilesDirectory, FilesDirectory, ManageFailedWindow.Operation.Delete);
                UpdateList();
                MainWindow.Output.WriteLine("Delete operation complete");
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            //file dialog filter set up
            string filter;
            string title;
            if (FileExtention != null && FileExtention.Length > 0)
            {
                if (FileExtention == "mvar")
                {
                    title = "Maps";
                    filter = "Map files (*.mvar)|*.mvar";
                }
                else if (FileExtention == "bin")
                {
                    title = "Game Types";
                    filter = "Game Type files (*.bin)|*.bin";
                }
                else
                {
                    //fall back in case class is used for some other type of file
                    title = "Others";
                    filter = "Other files (*." + FileExtention + ")|*." + FileExtention;
                }
                openFileDialog.Title = "Add " + title;
                openFileDialog.Filter = filter + "|All files (*.*)|*.*";
            }
            else
            {
                //fall back to make sure you can still do something
                openFileDialog.Title = "Add files";
                openFileDialog.Filter = "All files (*.*)|*.*";
            }
            //open and get result
            if (openFileDialog.ShowDialog() ==  DialogResult.OK && openFileDialog.FileNames.Length > 0)
            {
                //add files
                string file;
                string newFile;
                List<ManageFailedWindow.ManageFailedException> exceptions = new List<ManageFailedWindow.ManageFailedException>();
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    file = openFileDialog.FileNames[i];
                    newFile = FilesDirectory + @"\" + Path.GetFileName(file);
                    if (File.Exists(newFile))
                    {
                        MainWindow.Output.WriteLine("Failed to add " + Path.GetFileNameWithoutExtension(file) + " another file already exists with that name at: " + newFile);
                        //list exception
                        exceptions.Add(new ManageFailedWindow.ManageFailedException("Failed to add file because another file with the same name already exists there", new Exception("File already exists"), file, FilesDirectory, GetInGameNameAndDescription(file)));
                    }
                    else
                    {
                        try
                        {
                            File.Copy(file, newFile);
                            MainWindow.Output.WriteLine("Added " + Path.GetFileNameWithoutExtension(file) + " new location: " + newFile);
                        }
                        catch (Exception ex)
                        {
                            MainWindow.Output.WriteLine("Failed to add " + Path.GetFileNameWithoutExtension(file) + " new location: " + newFile);
                            exceptions.Add(new ManageFailedWindow.ManageFailedException("Failed to add file because: " + ex.Message, ex, file, FilesDirectory, GetInGameNameAndDescription(file)));
                        }
                    }
                }
                //attempt to resolve exceptions
                if (exceptions.Count > 0) ManageFailedWindow.OpenDialog(exceptions, FilesDirectory, FilesDirectory, ManageFailedWindow.Operation.Add);
                UpdateList();
                MainWindow.Output.WriteLine("Add operation complete");
            }
        }
        #endregion
        public List<string> GetIgnoreListFromFile(string file)
        {
            List<string> returnValue = new List<string>();
            if (File.Exists(file))
            {
                try
                {
                    string line;
                    StreamReader fileStream = new StreamReader(file);
                    while ((line = fileStream.ReadLine()) != null)
                    {
                        returnValue.Add(line);
                    }
                    fileStream.Close();
                }
                catch
                {
                    MainWindow.Output.WriteLine("ERROR: Couldn't get ignore list for " + GameName + " from file: " + file + " Some files in " + FilesDirectory + " may be listed that are supposed to be ignored.");
                }
            }
            else
            {
                MainWindow.Output.WriteLine("Ignore list missing for " + GameName + ". Ignore list file should have been at: " + file + ". Some files in " + FilesDirectory + " may be listed that are supposed to be ignored.");
            }
            return returnValue;
        }
        #region Get name and desctiption from file
        InGameNameAndDescription GetInGameNameAndDescription(string file)
        {
            if (GameName == "Halo: Reach")
            {
                return GetReachInGameNameAndDescription(file);
            }
            else if (GameName == "Halo 3")
            {
                return Get3InGameNameAndDescription(file);
            }
            return new InGameNameAndDescription("", ""); 
        }
        InGameNameAndDescription GetReachInGameNameAndDescription(string file)
        {
            byte[] fileBytes;
            InGameNameAndDescription returnInfo = new InGameNameAndDescription("","");
            if (file != null && File.Exists(file) && Path.GetExtension(file) == ".mvar" || Path.GetExtension(file) == ".bin")
            {
                fileBytes = File.ReadAllBytes(file);
                int startName = 192;
                int length = 256;
                int offset = 0;
                if (fileBytes[startName] == 0)
                {
                    //shift 1
                    offset = 1;
                }
                char currentChar;
                for(int i = startName + offset; i < startName + offset + length; i+=2)
                {
                    currentChar = (char)fileBytes[i];
                    if (currentChar == 0) //End of name
                    {
                        break;
                    }
                    returnInfo.InGameName += currentChar;
                }
                int startDescription = 448;
                for (int i = startDescription + offset; i < 752; i += 2)
                {
                    currentChar = (char)fileBytes[i];
                    if (currentChar == 0) //End of name
                    {
                        break;
                    }
                    returnInfo.Description += currentChar;
                }
            }
            return returnInfo;
        }
        InGameNameAndDescription Get3InGameNameAndDescription(string file)
        {
            byte[] fileBytes;
            InGameNameAndDescription returnInfo = new InGameNameAndDescription("", "");
            if (file != null && File.Exists(file) && Path.GetExtension(file) == ".mvar" || Path.GetExtension(file) == ".bin")
            {
                fileBytes = File.ReadAllBytes(file);
                //check if built in file
                int offset = 0;
                string builtInTextCheck = "";
                char currentChar;
                for (int i = 14; i < 25; i++)
                {
                    currentChar = (char)fileBytes[i];
                    builtInTextCheck += currentChar;
                }
                //check of built in map or game type
                if (builtInTextCheck == "game var\0\0\0")
                {
                    //abort cant read built in game var 
                    MainWindow.Output.WriteLine("Unable to obtain built in Halo 3 game type name and description. Does the file belong on the ignore list? Path:" + file);
                    returnInfo.InGameName = "Unable to get in game name";
                    returnInfo.Description = "Unable to obtain description";
                }
                else if (builtInTextCheck == "map variant")
                {
                    //built in map var, add offset
                    offset = 76;
                }
                int startName = 72;
                if (fileBytes[startName+offset] == 0) { offset++; } //check if info is shifted by 1 if so adjust offset
                int length = 32;
                int startDescription = 0;
                //Get Name
                for (int i = startName + offset; i < startName + offset + length; i += 2)
                {
                    currentChar = (char)fileBytes[i];
                    if (currentChar == 0) //End of name
                    {
                        startDescription = i;
                        break;
                    }
                    returnInfo.InGameName += currentChar;
                }
                //find start of description from end of name
                for (int i = 0; i <32; i++)
                {
                    if (fileBytes[startDescription] != 0) break;
                    startDescription++;
                }
                //get description
                for (int i = 0; i < 127; i++) 
                {
                    currentChar = (char)fileBytes[startDescription+i];
                    if (currentChar == 0) //End of description
                    {
                        break;
                    }
                    returnInfo.Description += currentChar;
                }
            }
            return returnInfo;
        }
        #endregion

        private void LocationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(FilesDirectory))
            {
                Process.Start(FilesDirectory);
            }
        }

        private void FileList_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = FileList.SelectedRows.Count > 0;
            DeleteButton.Enabled = selected;
            MoveButton.Enabled = Directory.Exists(GetMoveLocation()) && selected;
        }
    }
}
