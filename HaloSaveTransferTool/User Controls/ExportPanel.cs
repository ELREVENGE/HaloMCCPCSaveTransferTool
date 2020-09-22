using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HaloMCCPCSaveTransferTool
{
    public partial class ExportPanel : UserControl
    {
        Dictionary<string, HaloX360FileIO.ContainerInfo> MapInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
        Dictionary<string, HaloX360FileIO.ContainerInfo> GametypeInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
        Dictionary<string, HaloX360FileIO.ContainerInfo> ScreenshotInfo = new Dictionary<string, HaloX360FileIO.ContainerInfo>();
        public void SetEnabledLists(bool enableMapList = true, bool enableGameTypeList = true, bool enableScreenshotList = true)
        {
            if (!enableGameTypeList) LayoutPanel.RemoveColumnAt(1);
            if (!enableMapList) LayoutPanel.RemoveColumnAt(0);
            if (!enableScreenshotList) LayoutPanel.RemoveColumnAt(LayoutPanel.ColumnCount - 1);
        }
        public enum FileType
        {
            Map,
            Gametype,
            Screenshot
        }
        public void Add(HaloX360FileIO.ContainerInfo file, FileType fileType)
        {
            if (fileType == FileType.Map && MapList != null) Add(file, MapInfo, MapList);
            if (fileType == FileType.Gametype && GameTypeList != null) Add(file, GametypeInfo, GameTypeList);
            if (fileType == FileType.Screenshot && ScreenshotList != null) AddScreenshot(file);
        }
        public void Add(List<HaloX360FileIO.ContainerInfo> files, FileType fileType)
        {
            if (fileType == FileType.Screenshot)
            {
                for (int i = 0; i < files.Count; i++)
                {
                    MainWindow.Output.WriteLine("Loading screenshot #" + (i + 1) + "/" + files.Count + " : " + files[i].CON.Header.Title_Display);
                    Add(files[i], fileType);
                }
            }
            else
            {
                for (int i = 0; i < files.Count; i++)
                {
                    Add(files[i], fileType);
                }
            }
        }
        void Add(HaloX360FileIO.ContainerInfo file, Dictionary<string, HaloX360FileIO.ContainerInfo> info, DataGridView list)
        {
            if (info != null) info.Add(file.path, file);
            if (list != null) list.Rows.Add(file.CON.Header.Title_Display, file.file.Created, file.file.Accessed, file.path);
        }
        void AddScreenshot(HaloX360FileIO.ContainerInfo file)
        {
            if (ScreenshotList != null)
            {
                ScreenshotInfo.Add(file.path, file);
                ScreenshotList.Rows.Add(HaloX360FileIO.Get16x9Thumbnail(HaloX360FileIO.ExtractImageFromScreenShotFile(file.CON), 12), file.CON.Header.Title_Display, file.file.Created, file.path);
                ScreenshotList.Rows[ScreenshotList.RowCount - 1].Height = 9 * 12;
            }
        }
        void ClearPannel(Dictionary<string, HaloX360FileIO.ContainerInfo> info, DataGridView list)
        {
            if (info != null) info.Clear();
            if (list != null) list.Rows.Clear();
        }
        public void Clear()
        {
            ClearPannel(MapInfo, MapList);
            ClearPannel(GametypeInfo, GameTypeList);
            ClearPannel(ScreenshotInfo, ScreenshotList);
        }
        public void ExportSelectedFromPannel(FileType fileType)
        {
            if (fileType == FileType.Map && MapList != null)
            {
                ExportSelected(MapList.SelectedRows, MapInfo);
            }
            else if (fileType == FileType.Gametype && GameTypeList != null)
            {
                ExportSelected(GameTypeList.SelectedRows, GametypeInfo);
            }
            else if (fileType == FileType.Screenshot && ScreenshotList != null)
            {
                ExportSelected(ScreenshotList.SelectedRows, ScreenshotInfo);
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
                    Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedWindow.ExportFailedException> failedFiles = new Dictionary<HaloX360FileIO.ContainerInfo, ExportFailedWindow.ExportFailedException>();
                    MainWindow.Output.WriteLine("Exporting to " + exportDirectory + " with an extention of " + exportExtention);
                    string name, location, exportLocation;
                    for (int i = 0; i < rows.Count; i++)
                    {
                        name = isScreenshot ? rows[i].Cells[1].Value.ToString() : rows[i].Cells[0].Value.ToString();
                        location = rows[i].Cells[3].Value.ToString();
                        exportLocation = exportDirectory + @"\" + name + exportExtention;
                        MainWindow.Output.WriteLine("Exporting " + name + " to " + exportLocation);
                        HaloX360FileIO.ContainerInfo info = infoDictionary[location];
                        try
                        {
                            if (isScreenshot)
                            {
                                if (File.Exists(exportLocation)) throw new Exception("File Already Exists");
                                HaloX360FileIO.ExtractImageFromScreenShotFile(info.CON).Save(exportLocation);
                                MainWindow.Output.WriteLine("Exported to " + exportLocation);
                            }
                            else if (HaloX360FileIO.Export(info, exportLocation))
                            {
                                MainWindow.Output.WriteLine("Exported to " + exportLocation);
                            }
                        }
                        catch (Exception ex)
                        {
                            failedFiles.Add(info, new ExportFailedWindow.ExportFailedException(ex.Message, ex) { containerInfo = info, exportPath = exportLocation, exportDirectory = exportDirectory, extention = exportExtention });
                            MainWindow.Output.WriteLine(Environment.NewLine + "Export of file " + name + " failed from exception " + Environment.NewLine + ex.Message + Environment.NewLine);
                        }
                    }
                    ExportFailedWindow.OpenDialog(failedFiles);
                    MainWindow.Output.WriteLine("Export completed!");
                }
            }
        }
        public ExportPanel()
        {
            InitializeComponent();
        }

        private void ExportMapsButton_Click(object sender, EventArgs e)
        {
            ExportSelectedFromPannel(FileType.Map);
        }

        private void ExportGametypesButton_Click(object sender, EventArgs e)
        {
            ExportSelectedFromPannel(FileType.Gametype);
        }

        private void ExportScreenShotsButton_Click(object sender, EventArgs e)
        {
            ExportSelectedFromPannel(FileType.Screenshot);
        }
    }
}
