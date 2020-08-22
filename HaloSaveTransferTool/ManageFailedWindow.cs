using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ManageFailedWindow : Form
    {
        string FilesDirectory = "";
        string DestinationDirectory = "";
        List<ManageFailedException> FailedFilesInfo;
        Operation Action;
        public enum Operation
        {
            Add,
            Move,
            Delete
        }
        public class ManageFailedException : Exception
        {
            public string FilePath;
            string _destinationDirectory;
            public string DestinationDirectory
            {
                get { return _destinationDirectory; }
                set
                {
                    if (value != null && value.Length > 0 && value[value.Length - 1] != '\\') { _destinationDirectory = value + @"\"; }
                    else _destinationDirectory = value;
                }
            }
            public ManageGameFiles.InGameNameAndDescription NameAndDescription;
            public ManageFailedException()
            {
            }
            public ManageFailedException(string message)
                : base(message)
            {
            }
            public ManageFailedException(string message, Exception inner, string filePath, string destinationDirectory, ManageGameFiles.InGameNameAndDescription nameAndDescription)
        : base(message, inner)
            {
                FilePath = filePath;
                DestinationDirectory = destinationDirectory;
                NameAndDescription = nameAndDescription;
            }
        }
        public ManageFailedWindow()
        {
            InitializeComponent();
        }
        public static void OpenDialog(List<ManageFailedException> failedFilesInfo, string filesDirectory, string destinationDirectory, Operation action)
        {
            if (failedFilesInfo != null && failedFilesInfo.Count > 0 && filesDirectory != null && Directory.Exists(filesDirectory) && destinationDirectory != null && Directory.Exists(destinationDirectory))
            {
                ManageFailedWindow window = new ManageFailedWindow
                {
                    FilesDirectory = filesDirectory,
                    DestinationDirectory = destinationDirectory,
                    Action = action,
                    FailedFilesInfo = failedFilesInfo
                };
                window.UpdateList();
                window.Text = "Failed to " + action.ToString("G");
                window.ShowDialog();
            }
        }
        void UpdateList()
        {
            FailedList.Rows.Clear();
            string buttonText = "";
            switch (Action)
            {
                case Operation.Add:
                    buttonText = "Save as";
                    break;
                case Operation.Move:
                    buttonText = "Save as";
                    break;
                case Operation.Delete:
                    buttonText = "Try again";
                    break;
            }
            ManageFailedException failed;
            for (int i = 0; i < FailedFilesInfo.Count; i++)
            {
                failed = FailedFilesInfo[i];
                //exception, resolve, InGameName, Description, File, Modified
                FailedList.Rows.Add(failed.Message, buttonText, failed.NameAndDescription.InGameName, failed.NameAndDescription.Description, failed.FilePath, File.GetLastWriteTime(failed.FilePath).ToString("yy/MM/dd HH:mm:ss"));
            }
            if (FailedList.Rows.Count == 0)
            {
                MainWindow.Output.WriteLine("Resolved all exceptions from " + Action.ToString("G") + " operation!");
                DialogResult = DialogResult.OK;
            }
        }
        private void FailedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (Action == Operation.Delete)
                {
                    if (PreformOperation(FailedFilesInfo[e.RowIndex], "", e.RowIndex)) FailedFilesInfo.RemoveAt(e.RowIndex);
                    UpdateList();
                    return;
                }
                ManageFailedException exception = FailedFilesInfo[e.RowIndex];
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                string extention = Path.GetExtension(exception.FilePath);
                string fileName = Path.GetFileNameWithoutExtension(exception.FilePath);
                string type = null;
                if (extention == ".mvar") type = "Map";
                else if (extention == ".bin") type = "Gametype";
                saveFileDialog1.Filter = type == null ? "All files (*.*)|*.*" : type + " files (*" + extention + ")|*" + extention + "|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 0;
                saveFileDialog1.RestoreDirectory = false;
                saveFileDialog1.FileName = fileName;
                if (!Directory.Exists(DestinationDirectory))
                {
                    //change inital directory because destination directory doesn't exist (this should never happen)
                    saveFileDialog1.InitialDirectory = Directory.Exists(FilesDirectory) ? FilesDirectory : ExportToWindow.GetOtherDirectory();
                }
                else
                {
                    saveFileDialog1.InitialDirectory = DestinationDirectory;
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // move or save as new 
                    if (PreformOperation(exception, saveFileDialog1.FileName, e.RowIndex)) FailedFilesInfo.RemoveAt(e.RowIndex);
                    UpdateList();
                }
            }

        }
        bool PreformOperation(ManageFailedException exception, string newFileName, int index)
        {
            if (Action == Operation.Add)
            {
                if (File.Exists(exception.FilePath))
                {
                    try
                    {
                        File.Copy(exception.FilePath, newFileName);
                        MainWindow.Output.WriteLine("Successfully added file " + exception.FilePath + " as " + newFileName);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //replace with new exception details
                        MainWindow.Output.WriteLine("Failed to add file " + exception.FilePath + " due to exception " + ex.Message + " updating it's details on the list");
                        FailedFilesInfo[index] = new ManageFailedException("Failed to add file with save as dialog because: " + ex.Message, ex, exception.FilePath, Path.GetDirectoryName(newFileName), exception.NameAndDescription);
                        return false;
                    }
                }
                else
                {
                    MainWindow.Output.WriteLine("Can't add file " + exception.FilePath + " because it doesn't exist. Removing it from the list");
                    FailedFilesInfo.RemoveAt(index);
                    return true;
                }
            }
            else if (Action == Operation.Move)
            {
                if (File.Exists(exception.FilePath))
                {
                    try
                    {
                        File.Move(exception.FilePath, newFileName);
                        MainWindow.Output.WriteLine("Successfully moved file from" + exception.FilePath + " to " + newFileName);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //replace with new exception details
                        MainWindow.Output.WriteLine("Failed to move file " + exception.FilePath + " due to exception " + ex.Message + " updating it's details on the list");
                        FailedFilesInfo[index] = new ManageFailedException("Failed to move file with save as dialog because: " + ex.Message, ex, exception.FilePath, Path.GetDirectoryName(newFileName), exception.NameAndDescription);
                        return false;
                    }
                }
                else
                {
                    MainWindow.Output.WriteLine("Can't move file " + exception.FilePath + " because it doesn't exist. Removing it from the list");
                    return true;
                }
            }
            else if (Action == Operation.Delete)
            {
                if(File.Exists(exception.FilePath))
                {
                    RecycleOption recycleOption = Properties.Settings.Default.UseRecyclingBin ? RecycleOption.SendToRecycleBin : RecycleOption.DeletePermanently;
                    try
                    {
                        FileSystem.DeleteFile(exception.FilePath, UIOption.OnlyErrorDialogs, recycleOption);
                        MainWindow.Output.WriteLine("Successfully deleted " + exception.FilePath);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MainWindow.Output.WriteLine("Failed to delete file " + exception.FilePath + " due to exception " + ex.Message + " updating it's details on the list");
                        FailedFilesInfo[index] = new ManageFailedException("Failed to delete file with save as dialog because: " + ex.Message, ex, exception.FilePath, exception.DestinationDirectory, exception.NameAndDescription);
                        return false;
                    }
                }
                else
                {
                    MainWindow.Output.WriteLine("Can't delete file " + exception.FilePath + " because it doesn't exist. Removing it from the list");
                    return true;
                }
            }
            return false;
        }
        private void AutoResolve_Click(object sender, EventArgs e)
        {
            /*
             * Fix this
             * add help link 
             * make game pannels a user control
             */
            string fileName;
            string fileDirectory;
            string fileExtention;
            List<ManageFailedException> exportedList = new List<ManageFailedException>();
            ManageFailedException exception;
            for(int i = 0; i < FailedFilesInfo.Count; i++)
            {
                //fix for delete
                exception = FailedFilesInfo[i];
                fileDirectory = Path.GetDirectoryName(exception.FilePath);
                fileName = Path.GetFileNameWithoutExtension(exception.FilePath);
                fileExtention = Path.GetExtension(exception.FilePath);
                string newPath = "";
                if (Action != Operation.Delete)
                {
                    string newName = FailedFileHelper.ReplaceInvalidCharactersFromFileName(fileName);
                    newPath = exception.DestinationDirectory + newName + fileExtention;
                    if (File.Exists(newPath))
                    {
                        newPath = FailedFileHelper.GetUniqueName(newPath);
                        newName = Path.GetFileNameWithoutExtension(newPath);
                    }
                    MainWindow.Output.WriteLine("Attempting to save with file name " + newName);
                }
                if (PreformOperation(exception, newPath, i))
                {
                    FailedFilesInfo.RemoveAt(i);
                    i--;
                }
            }
            UpdateList();
        }
    }
}
