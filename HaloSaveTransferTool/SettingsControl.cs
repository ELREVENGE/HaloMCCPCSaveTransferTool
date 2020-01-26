using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HaloMCCPCSaveTransferTool
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            SettingsGrid.Rows.Add("Built in", "Set", "Set", Properties.Settings.Default.BuiltInLocation);
            SettingsGrid.Rows.Add("Private", "Set", "Set", Properties.Settings.Default.PrivateLocation);
            SettingsGrid.Rows.Add("Other", "Set", "Set", Properties.Settings.Default.DefaultOtherLocation);
            CheckForUpdateCheckBox.Checked = Properties.Settings.Default.AutoCheckForUpdates;
        }
        static string defaultBuiltInLocation = @"C:\Program Files (x86)\Steam\steamapps\common\Halo The Master Chief Collection\";
        static string defaultPrivateLocation = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\MCC\LocalFiles\";
        static string defaultOtherLocation = @"C:\Users\" + Environment.UserName + @"\Documents\";
        void AutoSetDefaultOther(object sender = null, EventArgs e = null)
        {
            if (Directory.Exists(defaultOtherLocation))
            {
                Properties.Settings.Default.DefaultOtherLocation = defaultOtherLocation;
                SettingsGrid.Rows[2].Cells[3].Value = defaultOtherLocation;
                MainWindow.Output.WriteLine("Other location set to " + defaultOtherLocation);
                Properties.Settings.Default.Save();
            }
            else { MainWindow.Output.WriteLine("Directory " + defaultOtherLocation + " Does not exist, you will have to enter the location manually"); }
        }
        void AutoSetBuiltIn(object sender = null, EventArgs e = null)
        {
            if (Directory.Exists(defaultBuiltInLocation))
            {
                Properties.Settings.Default.BuiltInLocation = defaultBuiltInLocation;
                SettingsGrid.Rows[0].Cells[3].Value = defaultBuiltInLocation;
                MainWindow.Output.WriteLine("Built in location set to " + defaultBuiltInLocation);
                Properties.Settings.Default.Save();
            }
            else { MainWindow.Output.WriteLine("Directory " + defaultBuiltInLocation + " Does not exist, you will have to enter the location manually"); }
        }
        void AutoSetPrivate(object sender = null, EventArgs e = null)
        {
            if (Directory.Exists(defaultPrivateLocation))
            {
                string[] directories = Directory.GetDirectories(defaultPrivateLocation);
                string currentDirectory;
                for (int i = 0; i < directories.Length; i++)
                {
                    currentDirectory = directories[i];
                    if (HaloX360FileIO.ValidXUID(new DirectoryInfo(currentDirectory).Name))
                    {
                        Properties.Settings.Default.PrivateLocation = currentDirectory;
                        SettingsGrid.Rows[1].Cells[3].Value = currentDirectory;
                        MainWindow.Output.WriteLine("Private location set to " + currentDirectory);
                        Properties.Settings.Default.Save();
                        break;
                    }
                }
            }
            else { MainWindow.Output.WriteLine("Directory " + defaultPrivateLocation + " Does not exist, you will have to enter the location manually"); }
        }

        private void SettingsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < 3 && e.ColumnIndex >= 1 && e.ColumnIndex < 4)
            {
                if (e.ColumnIndex == 1) // Auto set
                {
                    if (e.RowIndex == 0) { AutoSetBuiltIn(); }
                    else if (e.RowIndex == 1) { AutoSetPrivate(); }
                    else { AutoSetDefaultOther(); }
                }
                else if (e.ColumnIndex == 2)
                {
                    ManualSet(e.RowIndex);
                }
            }
        }
        public void ManualSet(int row)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok && Directory.Exists(dialog.FileName))
            {
                if (row == 0)
                {
                    //built in
                    Properties.Settings.Default.BuiltInLocation = dialog.FileName;
                    SettingsGrid.Rows[0].Cells[3].Value = defaultBuiltInLocation;
                    MainWindow.Output.WriteLine("Built in location set to " + defaultBuiltInLocation);
                    Properties.Settings.Default.Save();
                }
                else if (row == 1)
                {
                    //private
                    Properties.Settings.Default.PrivateLocation = dialog.FileName;
                    SettingsGrid.Rows[1].Cells[3].Value = dialog.FileName;
                    MainWindow.Output.WriteLine("Private location set to " + dialog.FileName);
                    Properties.Settings.Default.Save();
                }
                else if (row == 2)
                {
                    //other 
                    Properties.Settings.Default.DefaultOtherLocation = dialog.FileName;
                    SettingsGrid.Rows[2].Cells[3].Value = dialog.FileName;
                    MainWindow.Output.WriteLine("Other location set to " + dialog.FileName);
                    Properties.Settings.Default.Save();
                }
            }

        }

        private void CheckForUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoCheckForUpdates = CheckForUpdateCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
