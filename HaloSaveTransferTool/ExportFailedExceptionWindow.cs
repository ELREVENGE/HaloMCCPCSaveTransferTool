using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ExportFailedExceptionWindow : Form
    {
        //failedFiles.Add(exception, save as, save name, created, modified, location, export location)
        Dictionary<string, KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException>> failedFilesInfo;
        public ExportFailedExceptionWindow()
        {
            InitializeComponent();
            failedFilesInfo = new Dictionary<string, KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException>>();
        }
        public static void OpenDialog(Dictionary<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> failedFiles)
        {
            if (failedFiles != null && failedFiles.Count > 0)
            {
                ExportFailedExceptionWindow window = new ExportFailedExceptionWindow();
                window.InitializeList(failedFiles);
                window.ShowDialog();
            }
        }
        void InitializeList(Dictionary<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> failedFiles)
        {
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> pair in failedFiles)
            {
                failedFilesInfo.Add(pair.Key.path, pair);
                string message = pair.Value.InnerException != null ? pair.Value.InnerException.Message : pair.Value.Message;
                FailedList.Rows.Add(message, "Save As", pair.Key.CON.Header.Title_Display, pair.Key.file.Created, pair.Key.file.Accessed, pair.Key.path, pair.Value.exportPath);
            }
        }
        void UpdateList()
        {
            FailedList.Rows.Clear();
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> pair in failedFilesInfo.Values)
            {
                string message = pair.Value.InnerException != null ? pair.Value.InnerException.Message : pair.Value.Message;
                FailedList.Rows.Add(message, "Save As", pair.Key.CON.Header.Title_Display, pair.Key.file.Created, pair.Key.file.Accessed, pair.Key.path, pair.Value.exportPath);
                
            }
            if (FailedList.Rows.Count == 0)
            {
                MainWindow.Output.WriteLine("All failed file exports resolved!");
                DialogResult = DialogResult.OK;
            }
        }
        private void FailedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> pair = failedFilesInfo[FailedList.Rows[e.RowIndex].Cells[5].Value.ToString()];
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                string extention = pair.Value.extention;
                string displayName = pair.Key.CON.Header.Title_Display;
                string type = null;
                if (extention == ".mvar") type = "Map";
                else if (extention == ".bin") type = "Gametype";
                saveFileDialog1.Filter = type == null ? "All files (*.*)|*.*" : type + " files (*" + extention + ")|*" + extention + "|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 0;
                saveFileDialog1.RestoreDirectory = false;
                saveFileDialog1.FileName = displayName;
                string exportDirectory = pair.Value.exportDirectory;
                if (!Directory.Exists(exportDirectory))
                {
                    exportDirectory = ExportToWindow.GetOtherDirectory();
                }
                saveFileDialog1.InitialDirectory = exportDirectory;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string exportedFileName = saveFileDialog1.FileName;
                    bool exported = false;
                    MainWindow.Output.WriteLine("Exporting " + displayName + " to " + exportedFileName);
                    try
                    {
                        exported = HaloX360FileIO.Export(pair.Key, exportedFileName);
                    }
                    catch(Exception ex)
                    {
                        if (ex.Message == "file already exists.")
                        {
                            //replace
                        }
                        //change row info and failed files info to reflect new reason
                        MainWindow.Output.WriteLine(Environment.NewLine + "Export of file " + displayName + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
                        failedFilesInfo[pair.Key.path] = new KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException>(pair.Key, new MainWindow.ExportFailedException("Failed to export", ex) { containerInfo = pair.Key, exportDirectory = exportDirectory, exportPath = exportedFileName, extention = extention });
                        UpdateList();
                    }
                    if (exported)
                    {
                        failedFilesInfo.Remove(pair.Key.path);
                        MainWindow.Output.WriteLine("Exported " + displayName + " to " + exportedFileName);
                        UpdateList();
                    }
                }
            }
        }
        string GetUniqueName(string originalPath)
        {
            if (originalPath != null && File.Exists(originalPath))
            {
                string directory = Path.GetDirectoryName(originalPath);
                string name = Path.GetFileNameWithoutExtension(originalPath);
                int i = 1;
                string extention = Path.GetExtension(originalPath);
                string newPath = directory + @"\" + name +" (" + i + ")"+ extention;
                while (File.Exists(newPath))
                {
                    i++;
                    newPath = directory + @"\" + name + " (" + i + ")" + extention;
                }
                return newPath;
            }
            return null;
        }

        private void RenameExisting_Click(object sender, EventArgs e)
        {
            bool exported;
            List<string> exportedList = new List<string>();
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> pair in failedFilesInfo.Values)
            {
                if (pair.Value.Message == "File already exists" || (pair.Value.InnerException != null && pair.Value.InnerException.Message == "File already exists"))
                {
                    exported = false;
                    string uniqueName = GetUniqueName(pair.Value.exportPath);
                    try
                    {
                        exported = HaloX360FileIO.Export(pair.Key, uniqueName);
                    }
                    catch (Exception ex)
                    {
                        MainWindow.Output.WriteLine(Environment.NewLine + "Export of file " + pair.Value.containerInfo.CON.Header.Title_Display + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
                        failedFilesInfo[pair.Key.path] = new KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException>(pair.Key, new MainWindow.ExportFailedException("Failed to auto export a file that already exists", ex) { containerInfo = pair.Key, exportDirectory = pair.Value.exportDirectory, exportPath = uniqueName, extention = pair.Value.extention });
                        UpdateList();
                    }
                    if (exported)
                    {
                        exportedList.Add(pair.Key.path);
                        MainWindow.Output.WriteLine("Exported " + pair.Value.containerInfo.CON.Header.Title_Display + " to " + uniqueName);
                    }
                }
            }
            foreach (string path in exportedList)
            {
                failedFilesInfo.Remove(path);
            }
            UpdateList();
        }
        static string invalidChars = @"<>:" + '"' + @"/\|?*";
        static string ReplaceInvalidCharactersFromFileName(string fileName, char replaceCharacter = '_')
        {
            string retval = fileName;
            if (fileName != null && fileName.Length > 0)
            {
                retval = "";
                for (int i = 0; i < fileName.Length; i++)
                {
                    if (invalidChars.Contains(fileName[i].ToString()))
                    {
                        retval += replaceCharacter;
                    }
                    else
                    {
                        retval += fileName[i];
                    }
                }
            }
            return retval;
        }
        private void FixInvalidCharacter_Click(object sender, EventArgs e)
        {
            bool exported;
            string titleDisplay;
            List<string> exportedList = new List<string>();
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException> pair in failedFilesInfo.Values)
            {
                titleDisplay = pair.Key.CON.Header.Title_Display;
                exported = false;
                string newName = ReplaceInvalidCharactersFromFileName(titleDisplay);
                if (newName != pair.Key.file.Name)
                {
                    try
                    {
                        MainWindow.Output.WriteLine("Attempting to save with file name " + newName);
                        exported = HaloX360FileIO.Export(pair.Key, newName);
                    }
                    catch (Exception ex)
                    {
                        MainWindow.Output.WriteLine(Environment.NewLine + "Export of file " + titleDisplay + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
                        failedFilesInfo[pair.Key.path] = new KeyValuePair<HaloX360FileIO.ContainerInfo, MainWindow.ExportFailedException>(pair.Key, new MainWindow.ExportFailedException("Failed to auto export a file that already exists", ex) { containerInfo = pair.Key, exportDirectory = pair.Value.exportDirectory, exportPath = newName, extention = pair.Value.extention });
                        UpdateList();
                    }
                }
                if (exported)
                {
                    exportedList.Add(pair.Key.path);
                    MainWindow.Output.WriteLine("Exported " + titleDisplay + " to " + newName);
                }
            }
            foreach (string path in exportedList)
            {
                failedFilesInfo.Remove(path);
            }
            UpdateList();
        }
    }
}
