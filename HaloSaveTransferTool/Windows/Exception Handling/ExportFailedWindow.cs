using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ExportFailedWindow : Form
    {
        public class ExportFailedException : Exception
        {
            public string exportPath;
            string _exportDirectory;
            public string exportDirectory
            {
                get { return _exportDirectory; }
                set
                {
                    if (value != null && value.Length > 0 && value[value.Length - 1] != '\\') { _exportDirectory = value + @"\"; }
                    else _exportDirectory = value;
                }
            }
            public string extention;
            public HaloX360FileIO.ContainerInfo containerInfo;
            public ExportFailedException()
            {
            }

            public ExportFailedException(string message)
                : base(message)
            {
            }
            public ExportFailedException(string message, Exception inner)
        : base(message, inner)
            {
            }
        }
        //failedFiles.Add(exception, save as, save name, created, modified, location, export location)
        Dictionary<string, KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException>> failedFilesInfo;
        public ExportFailedWindow()
        {
            InitializeComponent();
            failedFilesInfo = new Dictionary<string, KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException>>();
        }
        public static void OpenDialog(Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException> failedFiles)
        {
            if (failedFiles != null && failedFiles.Count > 0)
            {
                ExportFailedWindow window = new ExportFailedWindow();
                window.InitializeList(failedFiles);
                window.ShowDialog();
            }
        }
        void InitializeList(Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException> failedFiles)
        {
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException> pair in failedFiles)
            {
                failedFilesInfo.Add(pair.Key.path, pair);
                string message = pair.Value.InnerException != null ? pair.Value.InnerException.Message : pair.Value.Message;
                FailedList.Rows.Add(message, "Save As", pair.Key.CON.Header.Title_Display, pair.Key.file.Created, pair.Key.file.Accessed, pair.Key.path, pair.Value.exportPath);
            }
        }
        void UpdateList()
        {
            FailedList.Rows.Clear();
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException> pair in failedFilesInfo.Values)
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
                KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException> pair = failedFilesInfo[FailedList.Rows[e.RowIndex].Cells[5].Value.ToString()];
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
                        failedFilesInfo[pair.Key.path] = new KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException>(pair.Key, new ExportFailedException("Failed to export", ex) { containerInfo = pair.Key, exportDirectory = exportDirectory, exportPath = exportedFileName, extention = extention });
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
        private void AutoResolve_Click(object sender, EventArgs e)
        {
            bool exported;
            string titleDisplay;
            List<string> exportedList = new List<string>();
            foreach (KeyValuePair<HaloX360FileIO.ContainerInfo, ExportFailedException> pair in failedFilesInfo.Values)
            {
                titleDisplay = pair.Key.CON.Header.Title_Display;
                exported = false;
                string newName = FailedFileHelper.ReplaceInvalidCharactersFromFileName(titleDisplay);
                string newPath = pair.Value.exportDirectory + newName + pair.Value.extention;
                if (newName != titleDisplay || File.Exists(newPath))
                {
                    try
                    {
                        if (File.Exists(newPath))
                        {
                            newPath = FailedFileHelper.GetUniqueName(newPath);
                            newName = Path.GetFileNameWithoutExtension(newPath);
                        }
                        MainWindow.Output.WriteLine("Attempting to save with file name " + newName);
                        if (pair.Value.extention == ".jpg")
                        {
                            HaloX360FileIO.ExtractImageFromScreenShotFile(pair.Key.CON).Save(newPath);
                            exported = true;
                        }
                        else
                        {
                            exported = HaloX360FileIO.Export(pair.Key, newPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MainWindow.Output.WriteLine(Environment.NewLine + "Export of file " + titleDisplay + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
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

        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloMCCPCSaveTransferTool/wiki/Help");
        }
    }
}
