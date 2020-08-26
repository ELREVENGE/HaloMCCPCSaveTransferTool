using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
        CommonOpenFileDialog selectDirectoryDialog = new CommonOpenFileDialog() { IsFolderPicker = true };
        void VerifiyResources()
        {
            //create files if they don't exist
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (!File.Exists(currentDirectory + "Halo3GameTypeIgnoreList.txt"))
            {
                File.WriteAllText(currentDirectory + "Halo3GameTypeIgnoreList.txt", Resource.Halo3GameTypeIgnoreList);
            }
            if (!File.Exists(currentDirectory + "Halo3MapIgnoreList.txt"))
            {
                File.WriteAllText(currentDirectory + "Halo3MapIgnoreList.txt", Resource.Halo3MapIgnoreList);
            }
            if (!File.Exists(currentDirectory + "HaloReachGameTypeIgnoreList.txt"))
            {
                File.WriteAllText(currentDirectory + "HaloReachGameTypeIgnoreList.txt", Resource.HaloReachGameTypeIgnoreList);
            }
            if (!File.Exists(currentDirectory + "HaloReachMapIgnoreList.txt"))
            {
                File.WriteAllText(currentDirectory + "HaloReachMapIgnoreList.txt", Resource.HaloReachMapIgnoreList);
            }
        }
        public MainWindow()
        {
            VerifiyResources();
            InitializeComponent();
            Output.SetOutput(OutputTextBox);
            if (Properties.Settings.Default.AutoCheckForUpdates) UpdateChecker.UpToDatePrompt();
            try { Text += " v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4); } catch { }
            Halo3ODSTExportPanel.SetEnabledLists(false, false, true);
            UpdateOpened("");
            ManageMapsPanel.Set(ManagePanel.FileType.Map);
            ManageGameTypesPanel.Set(ManagePanel.FileType.GameType);
            Output.WriteLine("Updating Manage tab file lists");
            ManageMapsPanel.UpdateLists();
            ManageGameTypesPanel.UpdateLists();
            Output.WriteLine("All files in Manage tab listed!");
        }
        #region Export tab
        HaloX360FileIO.HaloFiles loadedFiles;
        string openedDirectory = "";
        CommonOpenFileDialog exportDialog = new CommonOpenFileDialog() { IsFolderPicker = true, RestoreDirectory = false };
        void UpdateLists(HaloX360FileIO.HaloFiles files)
        {
            Output.WriteLine("Updating Export tab lists");
            loadedFiles = files;
            ReachExportPanel.Clear();
            Halo3ExportPanel.Clear();
            Halo3ODSTExportPanel.Clear();
            Output.WriteLine(files.Reach.Maps.Count + " Maps, " + files.Reach.GameTypes.Count + " Gametypes, and " + files.Reach.Screenshots.Count + " Screenshots for Halo: Reach");
            ReachExportPanel.Add(files.Reach.Maps, ExportPanel.FileType.Map);
            ReachExportPanel.Add(files.Reach.GameTypes, ExportPanel.FileType.Gametype);
            ReachExportPanel.Add(files.Reach.Screenshots, ExportPanel.FileType.Screenshot);
            Output.WriteLine(files.Halo3.Maps.Count + " Maps, " + files.Halo3.GameTypes.Count + " Gametypes, and " + files.Reach.Screenshots.Count + " Screenshots for Halo 3");
            Halo3ExportPanel.Add(files.Halo3.Maps, ExportPanel.FileType.Map);
            Halo3ExportPanel.Add(files.Halo3.GameTypes, ExportPanel.FileType.Gametype);
            Halo3ExportPanel.Add(files.Halo3.Screenshots, ExportPanel.FileType.Screenshot);
            Output.WriteLine(files.Halo3ODST.Screenshots.Count + " Screenshots for Halo 3: ODST");
            Halo3ODSTExportPanel.Add(files.Halo3ODST.Screenshots, ExportPanel.FileType.Screenshot);
            Output.WriteLine("All files in Export tab listed!");
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
        #endregion
        #region Help/Other tab
        private void HelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloMCCPCSaveTransferTool/wiki/Help");
        }
        private void ViewLicensesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LicenseWindow().ShowDialog();
        }
        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloSaveTransferTool");
        }
        private void IssuesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ELREVENGE/HaloMCCPCSaveTransferTool/issues");
        }
        #endregion
    }
}
