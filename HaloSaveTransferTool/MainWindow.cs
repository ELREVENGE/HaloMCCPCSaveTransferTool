using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using X360.STFS;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HaloMCCPCSaveTransferTool
{
    public partial class MainWindow : Form
    {
        public class Output
        {
            internal static void SetOutput(RichTextBox richTextBox)
            {
                _output = richTextBox;
            }
            static RichTextBox _output;
            internal static void WriteLine(string text = null, RichTextBox output = null)
            {
                if (output != null) _output = output;
                if (_output != null)
                {
                    if (text == null) text = "";
                    _output.AppendText(text + Environment.NewLine);
                    _output.ScrollToCaret();
                    Console.Write(text);
                }
            }
        }
        string openedDirectory = "";
        CommonOpenFileDialog exportDialog = new CommonOpenFileDialog() { IsFolderPicker = true, RestoreDirectory = false};
        CommonOpenFileDialog selectDirectoryDialog = new CommonOpenFileDialog() { IsFolderPicker = true };

        HaloX360FileIO.HaloFiles loadedFiles;
        Dictionary<string, HaloX360FileIO.ContainerInfo> mapInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
        Dictionary<string, HaloX360FileIO.ContainerInfo> gametypeInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
        Dictionary<string, HaloX360FileIO.ContainerInfo> screenshotInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
        public MainWindow()
        {
            InitializeComponent();
            Output.SetOutput(OutputTextBox);
            if (Properties.Settings.Default.AutoCheckForUpdates) UpdateChecker.UpToDatePrompt();
            try { Text += " v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4); } catch { }
            if (!Directory.Exists(Properties.Settings.Default.DefaultOtherLocation) || !Directory.Exists(Properties.Settings.Default.BuiltInLocation) || !Directory.Exists(Properties.Settings.Default.PrivateLocation))
            {
                tableLayoutPanel1.TabIndex = 1;
            }
            UpdateOpened("");
        }

        
        void UpdateLists(HaloX360FileIO.HaloFiles files)
        {
            Output.WriteLine("Updating lists");
            loadedFiles = files;
            gametypeInfo.Clear();
            mapInfo.Clear();
            MapSaves.Rows.Clear();
            GameTypeSaves.Rows.Clear();
            Output.WriteLine(files.reachMaps.Count + " Maps, " + files.reachGametypes.Count + " Gametypes, and " + files.reachScreenShots.Count + " Screenshots found");
            foreach (HaloX360FileIO.ContainerInfo map in files.reachMaps)
            {
                mapInfo.Add(map.path, map);
                MapSaves.Rows.Add(map.CON.Header.Title_Display, map.file.Created, map.file.Accessed, map.path);

            }
            Output.WriteLine("Map names listed");
            foreach (HaloX360FileIO.ContainerInfo gt in files.reachGametypes)
            {
                gametypeInfo.Add(gt.path, gt);
                GameTypeSaves.Rows.Add(gt.CON.Header.Title_Display, gt.file.Created, gt.file.Accessed, gt.path);
            }
            HaloX360FileIO.ContainerInfo screenshot;
            for (int i =0; i < files.reachScreenShots.Count; i++)
            {
                screenshot = files.reachScreenShots[i];
                screenshotInfo.Add(screenshot.path, screenshot);
                Output.WriteLine("Loading thumbnail and info for screenshot #"+ (i + 1) +"/"+files.reachScreenShots.Count+": " + screenshot.CON.Header.Title_Display);
                screenshotSaves.Rows.Add(HaloX360FileIO.Get16x9Thumbnail(HaloX360FileIO.ExtractImageFromScreenShotFile(screenshot.CON), 12), screenshot.CON.Header.Title_Display, screenshot.file.Created, screenshot.file.Accessed, screenshot.path);
                screenshotSaves.Rows[screenshotSaves.RowCount - 1].Height = 9 * 12;
            }
            //foreach(HaloX360FileIO.ContainerInfo screenshot in files.reachScreenShots)
            //{
            //    Output.WriteLine("Loading thumbnail and info for screenshot: " + screenshot.CON.Header.Title_Display);
            //    screenshotSaves.Rows.Add(HaloX360FileIO.Get16x9Thumbnail(HaloX360FileIO.ExtractImageFromScreenShotFile(screenshot.path), 12), screenshot.CON.Header.Title_Display, screenshot.file.Created, screenshot.file.Accessed, screenshot.path);
            //    screenshotSaves.Rows[screenshotSaves.RowCount - 1].Height = 9 * 12;
            //}
            Output.WriteLine("All files listed!");
        }

        private void ExportMaps_Click(object sender, EventArgs e)
        {
            ExportSelected(MapSaves.SelectedRows, mapInfo);
        }
        public class ExportFailedException : Exception
        {
            public string exportPath;
            string _exportDirectory;
            public string exportDirectory
            {
                get { return _exportDirectory; }
                set
                {
                    if (value != null && value.Length > 0 && value[value.Length-1] != '\\') { _exportDirectory = value + @"\"; }
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
        void ExportSelected(DataGridViewSelectedRowCollection rows, Dictionary<string, HaloX360FileIO.ContainerInfo> infoDictionary)
        {
            if (rows != null && rows.Count > 0)
            {
                string exportDirectory = ExportToWindow.GetResult(infoDictionary[rows[0].Cells[3].Value.ToString()]);
                if (exportDirectory != null && Directory.Exists(exportDirectory))
                {
                    string exportExtention = ExportToWindow.extention;
                    Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException> failedFiles = new Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException>();
                    Output.WriteLine("Exporting to " + exportDirectory + " with an extention of " + exportExtention);
                    string name, location, exportLocation;
                    for (int i = 0; i < rows.Count; i++)
                    {
                        name = rows[i].Cells[0].Value.ToString();
                        location = rows[i].Cells[3].Value.ToString();
                        exportLocation = exportDirectory + @"\" + name + exportExtention;
                        Output.WriteLine("Exporting " + name + " to " + exportLocation);
                        HaloX360FileIO.ContainerInfo info = infoDictionary[location];
                        try
                        {
                            if (HaloX360FileIO.Export(info, exportLocation))
                            {
                                Output.WriteLine("Exported to " + exportLocation);
                            }
                        }
                        catch (Exception ex)
                        {
                            failedFiles.Add(info, new ExportFailedException(ex.Message, ex) { containerInfo = info, exportPath = exportLocation, exportDirectory = exportDirectory, extention = exportExtention });
                            Output.WriteLine(Environment.NewLine + "Export of file " + name + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
                        }
                    }
                    ExportFailedWindow.OpenDialog(failedFiles);
                    Output.WriteLine("Export completed!");
                }
            }
        }
        private void ExportGametypes_Click(object sender, EventArgs e)
        {
            ExportSelected(GameTypeSaves.SelectedRows, gametypeInfo);
        }
        void UpdateOpened(string opened)
        {
            if (opened != null && opened != "")
            {
                Output.WriteLine("Updating from folder " + selectDirectoryDialog.FileName);
                openedDirectory = opened;
                selectDirectoryDialog.InitialDirectory = opened;
                OpenedLabel.Text = "360 files in: " + opened;
                UpdateLists(HaloX360FileIO.GetHaloFilesFromDirectory(selectDirectoryDialog.FileName));
            }
            else
            {
                openedDirectory = opened;
                selectDirectoryDialog.InitialDirectory = ExportToWindow.GetOtherDirectory();
                OpenedLabel.Text = "360 files in: ";
                UpdateLists(new HaloX360FileIO.HaloFiles() { reachGametypes = new List<HaloX360FileIO.ContainerInfo>(), reachMaps = new List<HaloX360FileIO.ContainerInfo>(), reachScreenShots = new List<HaloX360FileIO.ContainerInfo>() });
            }

        }
        private void Open_Click(object sender, EventArgs e)
        {
            selectDirectoryDialog.InitialDirectory = openedDirectory;
            if (selectDirectoryDialog.ShowDialog() == CommonFileDialogResult.Ok && Directory.Exists(selectDirectoryDialog.FileName))
            {
                UpdateOpened(selectDirectoryDialog.FileName);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LicenseWindow().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mtolly/X360");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloSaveTransferTool");
        }

        private void ExportScreenShots_Click(object sender, EventArgs e)
        {
            if (screenshotSaves.SelectedRows != null && screenshotSaves.SelectedRows.Count > 0)
            {
                string exportDirectory = ExportToWindow.GetResult(screenshotInfo[screenshotSaves.SelectedRows[0].Cells[4].Value.ToString()]);
                if (exportDirectory != null && Directory.Exists(exportDirectory))
                {
                    string exportExtention = ExportToWindow.extention;
                    Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException> failedFiles = new Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException>();
                    Output.WriteLine("Exporting to " + exportDirectory + " with an extention of " + exportExtention);
                    string name, location, exportLocation;
                    for (int i = 0; i < screenshotSaves.SelectedRows.Count; i++)
                    {
                        name = screenshotSaves.SelectedRows[i].Cells[1].Value.ToString();
                        location = screenshotSaves.SelectedRows[i].Cells[4].Value.ToString();
                        exportLocation = exportDirectory + @"\" + name + exportExtention;
                        Output.WriteLine("Exporting " + name + " to " + exportLocation);
                        HaloX360FileIO.ContainerInfo info = screenshotInfo[location];
                        try
                        {
                            if (exportExtention == ".jpg")
                            {
                                if (File.Exists(exportLocation)) throw new Exception("File Already Exists");
                                HaloX360FileIO.ExtractImageFromScreenShotFile(info.CON).Save(exportLocation);
                                Output.WriteLine("Exported to " + exportLocation);

                            }
                            else if (HaloX360FileIO.Export(info, exportLocation))
                            {
                                Output.WriteLine("Exported to " + exportLocation);
                            }
                        }
                        catch (Exception ex)
                        {
                            failedFiles.Add(info, new ExportFailedException(ex.Message, ex) { containerInfo = info, exportPath = exportLocation, exportDirectory = exportDirectory, extention = exportExtention });
                            Output.WriteLine(Environment.NewLine + "Export of file " + name + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
                        }
                    }
                    ExportFailedWindow.OpenDialog(failedFiles);
                    Output.WriteLine("Export completed!");
                }
            }
        }

        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloMCCPCSaveTransferTool/wiki/Help");
        }
    }
}
