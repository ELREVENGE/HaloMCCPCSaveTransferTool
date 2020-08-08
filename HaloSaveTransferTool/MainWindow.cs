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
        string openedDirectory = "";
        CommonOpenFileDialog exportDialog = new CommonOpenFileDialog() { IsFolderPicker = true, RestoreDirectory = false};
        CommonOpenFileDialog selectDirectoryDialog = new CommonOpenFileDialog() { IsFolderPicker = true };

        HaloX360FileIO.HaloFiles loadedFiles;
        class GamePannel
        {
            public Dictionary<string, HaloX360FileIO.ContainerInfo> mapInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
            public Dictionary<string, HaloX360FileIO.ContainerInfo> gametypeInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
            public Dictionary<string, HaloX360FileIO.ContainerInfo> screenshotInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
            public DataGridView mapList;
            public DataGridView gametypeList;
            public DataGridView screenshotList;

            public GamePannel(DataGridView mapList, DataGridView gametypeList, DataGridView screenshotList)
            {
                this.mapList = mapList;// ?? throw new ArgumentNullException(nameof(mapList));
                this.gametypeList = gametypeList;// ?? throw new ArgumentNullException(nameof(gametypeList));
                this.screenshotList = screenshotList;// ?? throw new ArgumentNullException(nameof(screenshotList));
            }

            public enum FileType
            {
                Map,
                Gametype,
                Screenshot
            }
            public void Add(HaloX360FileIO.ContainerInfo file, FileType fileType)
            {
                switch(fileType)
                {
                    case FileType.Map:
                        Add(file, mapInfo, mapList);
                        break;
                    case FileType.Gametype:
                        Add(file, gametypeInfo, gametypeList);
                        break;
                    case FileType.Screenshot:
                        AddScreenshot(file);
                        break;
                }
            }
            void Add(HaloX360FileIO.ContainerInfo file, Dictionary<string, HaloX360FileIO.ContainerInfo> info, DataGridView list)
            {
                info.Add(file.path, file);
                if (list != null) list.Rows.Add(file.CON.Header.Title_Display, file.file.Created, file.file.Accessed, file.path);
            }
            void AddScreenshot(HaloX360FileIO.ContainerInfo file)
            {
                screenshotInfo.Add(file.path, file);
                if (screenshotList != null)
                {
                    screenshotList.Rows.Add(HaloX360FileIO.Get16x9Thumbnail(HaloX360FileIO.ExtractImageFromScreenShotFile(file.CON), 12), file.CON.Header.Title_Display, file.file.Created, file.path);
                    screenshotList.Rows[screenshotList.RowCount - 1].Height = 9 * 12;
                }
            }
            void ClearPannel(Dictionary<string, HaloX360FileIO.ContainerInfo> info, DataGridView list)
            {
                info.Clear();
                if (list != null) list.Rows.Clear();
            }
            public void Clear()
            {
                ClearPannel(mapInfo, mapList);
                ClearPannel(gametypeInfo, gametypeList);
                ClearPannel(screenshotInfo, screenshotList);
            }
            public void ExportSelectedFromPannel(FileType fileType)
            {
                if (fileType == FileType.Map && mapList != null)
                {
                    ExportSelected(mapList.SelectedRows, mapInfo);
                }
                else if (fileType == FileType.Gametype && gametypeList != null)
                {
                    ExportSelected(gametypeList.SelectedRows, gametypeInfo);
                }
                else if (fileType == FileType.Screenshot && screenshotList != null)
                {
                    ExportSelected(screenshotList.SelectedRows, screenshotInfo);
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
                        bool isScreenshot = exportExtention == ".jpg";
                        Dictionary <HaloX360FileIO.ContainerInfo, ExportFailedException> failedFiles = new Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedException>();
                        Output.WriteLine("Exporting to " + exportDirectory + " with an extention of " + exportExtention);
                        string name, location, exportLocation;
                        for (int i = 0; i < rows.Count; i++)
                        {
                            name = isScreenshot ? rows[i].Cells[1].Value.ToString() : rows[i].Cells[0].Value.ToString();
                            location = rows[i].Cells[3].Value.ToString();
                            exportLocation = exportDirectory + @"\" + name + exportExtention;
                            Output.WriteLine("Exporting " + name + " to " + exportLocation);
                            HaloX360FileIO.ContainerInfo info = infoDictionary[location];
                            try
                            {
                                if (isScreenshot)
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
        }

        GamePannel reachPannel;
        GamePannel h3Pannel;
        GamePannel h3ODSTPannel;
        public MainWindow()
        {
            InitializeComponent();
            reachPannel = new GamePannel(HaloReachMapSaves, HaloReachGameTypeSaves, HaloReachScreenshotSaves);
            h3Pannel = new GamePannel(Halo3MapSaves, Halo3GameTypeSaves, Halo3ScreenshotSaves);
            h3ODSTPannel = new GamePannel(null, null, ODSTScreenshots);
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
            reachPannel.Clear();
            h3Pannel.Clear();
            h3ODSTPannel.Clear();
            int screenshotCounter = 0;
            Output.WriteLine(files.reachMaps.Count + " Maps, " + files.reachGametypes.Count + " Gametypes, and " + files.reachScreenShots.Count + " Screenshots for Halo: Reach");
            Output.WriteLine(files.h3Maps.Count + " Maps, " + files.h3Gametypes.Count + " Gametypes, and " + files.reachScreenShots.Count + " Screenshots for Halo 3");
            Output.WriteLine(files.h3ODSTScreenShots.Count + " Screenshots for Halo 3: ODST");
            //reach
            foreach (HaloX360FileIO.ContainerInfo map in files.reachMaps)
            {
                reachPannel.Add(map, GamePannel.FileType.Map);
            }
            foreach (HaloX360FileIO.ContainerInfo gt in files.reachGametypes)
            {
                reachPannel.Add(gt, GamePannel.FileType.Gametype);
            }
            foreach (HaloX360FileIO.ContainerInfo screenshot in files.reachScreenShots)
            {
                Output.WriteLine("Loading screenshot #" + (screenshotCounter + 1) + "/" + files.reachScreenShots.Count + ": " + screenshot.CON.Header.Title_Display);
                screenshotCounter++;
                reachPannel.Add(screenshot, GamePannel.FileType.Screenshot);
            }
            //Halo 3
            foreach (HaloX360FileIO.ContainerInfo map in files.h3Maps)
            {
                h3Pannel.Add(map, GamePannel.FileType.Map);
            }
            foreach (HaloX360FileIO.ContainerInfo gt in files.h3Gametypes)
            {
                h3Pannel.Add(gt, GamePannel.FileType.Gametype);
            }
            screenshotCounter = 0;
            foreach(HaloX360FileIO.ContainerInfo screenshot in files.h3ScreenShots)
            {
                Output.WriteLine("Loading screenshot #" + (screenshotCounter + 1) + "/" + files.h3ScreenShots.Count + ": " + screenshot.CON.Header.Title_Display);
                screenshotCounter++;
                h3Pannel.Add(screenshot, GamePannel.FileType.Screenshot);
            }
            //Halo 3 ODST
            screenshotCounter = 0;
            foreach (HaloX360FileIO.ContainerInfo screenshot in files.h3ODSTScreenShots)
            {
                Output.WriteLine("Loading screenshot #" + (screenshotCounter + 1) + "/" + files.h3ODSTScreenShots.Count + ": " + screenshot.CON.Header.Title_Display);
                screenshotCounter++;
                h3ODSTPannel.Add(screenshot, GamePannel.FileType.Screenshot);
            }
            Output.WriteLine("All files listed!");
        }

        private void ReachExportMaps_Click(object sender, EventArgs e)
        {
            reachPannel.ExportSelectedFromPannel(GamePannel.FileType.Map);
        }
        
        private void ReachExportGametypes_Click(object sender, EventArgs e)
        {
            reachPannel.ExportSelectedFromPannel(GamePannel.FileType.Gametype);
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
                UpdateLists(new HaloX360FileIO.HaloFiles(true));
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

        private void ReachExportScreenShots_Click(object sender, EventArgs e)
        {
            reachPannel.ExportSelectedFromPannel(GamePannel.FileType.Screenshot);
        }

        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloMCCPCSaveTransferTool/wiki/Help");
        }

        private void H3ExportMaps_Click(object sender, EventArgs e)
        {
            h3Pannel.ExportSelectedFromPannel(GamePannel.FileType.Map);
        }

        private void H3ExportGameTypes_Click(object sender, EventArgs e)
        {
            h3Pannel.ExportSelectedFromPannel(GamePannel.FileType.Gametype);
        }

        private void H3ExportScreenshots_Click(object sender, EventArgs e)
        {
            h3Pannel.ExportSelectedFromPannel(GamePannel.FileType.Screenshot);
        }

        private void Halo3ODSTExportScreenshots_Click(object sender, EventArgs e)
        {
            h3ODSTPannel.ExportSelectedFromPannel(GamePannel.FileType.Screenshot);
        }
    }
}
