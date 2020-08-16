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
        string GameName = "";
        string FilesDirectory = "";
        string MoveLocation = "";
        string FileExtention = "";
        static OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true, RestoreDirectory = true };
        List<string> IgnoreList = new List<string>();
        public ManageGameFiles()
        {
            InitializeComponent();
            SetUp();
        }
        void SetUp()
        {
            if (this != null)
            {
                locationLinkLabel.Text = GameName;
                UpdateLists();
            }
        }
        public void Set(string gameName, string filesDirectory, string moveLocation, string fileExtention, List<string> ignoreList)
        {
            GameName = gameName;
            FilesDirectory = filesDirectory == null ? "" : filesDirectory;
            MoveLocation = moveLocation == null ? "" : moveLocation;
            IgnoreList = ignoreList == null ? new List<string>() : ignoreList;
            FileExtention = fileExtention == null ? "" : fileExtention;
            SetUp();
        }
        void UpdateLists()
        {
            if (Directory.Exists(FilesDirectory))
            {
                List<string> files = new List<string>();
                foreach (string file in Directory.GetFiles(FilesDirectory, @"*." + FileExtention))
                {
                    files.Add(Path.GetFileNameWithoutExtension(file));
                }
                foreach (string file in IgnoreList)
                {
                    files.Remove(file);
                }
                fileList.ClearSelection();
                fileList.Rows.Clear();
                foreach(string file in files)
                {
                    fileList.Rows.Add("Not implemented", Path.GetFileNameWithoutExtension(file), File.GetLastWriteTime(file).ToString("dd/MM/yy HH:mm:ss"));
                }
            }
        }
        void UpdateAllButtons()
        {
            bool exists = Directory.Exists(FilesDirectory);
            Add.Enabled = exists;
            Delete.Enabled = (exists && fileList.SelectedRows.Count > 0);
            Move.Enabled = (exists && Directory.Exists(MoveLocation));
        }
        private void locationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(FilesDirectory))
            {
                Process.Start(FilesDirectory);
            }
        }
        private void fileList_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = fileList.SelectedRows.Count > 0;
            Delete.Enabled = selected;
            Move.Enabled = Directory.Exists(MoveLocation) && selected;
        }

        private void Move_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = fileList.SelectedRows.Count;
            if (selectedRowsCount > 0 && Directory.Exists(MoveLocation))
            {
                string fileName;
                string destinationPath;
                string sourcePath;
                for(int i = 0; i < selectedRowsCount; i++)
                {
                    fileName = fileList.SelectedRows[i].Cells[1].Value.ToString();
                    sourcePath = FilesDirectory + @"\" + fileName + "." + FileExtention;
                    destinationPath = MoveLocation + @"\" + fileName + "." + FileExtention;
                    if (File.Exists(sourcePath) && !File.Exists(destinationPath))
                    {
                        try
                        {
                            File.Move(sourcePath, destinationPath);
                            MainWindow.Output.WriteLine("Successfully moved " + fileName + " from " + FilesDirectory + "  to " + MoveLocation);
                        }
                        catch (Exception ex)
                        {
                            //list exception
                            MainWindow.Output.WriteLine("Failed to move " + fileName + " from " + FilesDirectory + "  to " + MoveLocation);
                        }
                    }
                    else
                    {
                        //list exception
                        MainWindow.Output.WriteLine("Failed to move " + fileName + " from " + FilesDirectory + "  to " + MoveLocation);
                    }
                }
                //attempt to resolve exceptions
                UpdateLists();
                MainWindow.Output.WriteLine("Move operation complete");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = fileList.SelectedRows.Count;
            if (selectedRowsCount > 0 && MessageBox.Show("Are you sure you want to delete the selected files? The file WILL show up in the recyling bin in case you decide you want it later.", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string fileName;
                string path;
                for (int i = 0; i < selectedRowsCount; i++)
                {
                    fileName = fileList.SelectedRows[i].Cells[1].Value.ToString();
                    path = FilesDirectory + @"\" + fileName + "." + FileExtention;
                    if (File.Exists(path))
                    {
                        try
                        {
                            FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                            MainWindow.Output.WriteLine("Successfully deleted " + fileName + " from " + FilesDirectory + ". If this was a mistake you can find it in the recyling bin.");
                        }
                        catch(Exception ex)
                        {
                            //List exception
                            MainWindow.Output.WriteLine("Failed to delete " + fileName + " (full path: " + path + ")");
                        }
                    }
                    else
                    {
                        //list exception
                        MainWindow.Output.WriteLine("Failed to delete " + fileName + " File doesn't exist (full path: " + path + ")");
                    }
                }
                //attempt to resolve exceptions

                UpdateLists();
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
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    file = openFileDialog.FileNames[i];
                    newFile = FilesDirectory + @"\" + Path.GetFileName(file);
                    if (File.Exists(newFile))
                    {
                        MainWindow.Output.WriteLine("Failed to add " + Path.GetFileNameWithoutExtension(file) + " another file already exists with that name at: " + newFile);
                        //list exception
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
                            //list exception
                        }
                    }
                }
                //attempt to resolve exceptions
                UpdateLists();
                MainWindow.Output.WriteLine("Add operation complete");
            }
        }
    }
}
