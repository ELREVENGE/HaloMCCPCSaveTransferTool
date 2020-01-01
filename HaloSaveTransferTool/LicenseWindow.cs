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
using System.Reflection;

namespace HaloSaveTransferTool
{
    public partial class LicenseWindow : Form
    {
        public LicenseWindow()
        {
            InitializeComponent();
        }
        internal static bool AgreedToLicenseCheck()
        {
            if (Properties.Settings.Default.AgreedToLicense)
            {
                return true;
            }
            else
            {
                LicenseWindow licenseWindow = new LicenseWindow();
                if (licenseWindow.ShowDialog() == DialogResult.OK)
                {
                    return true;
                }
            }
            return false;
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mtolly/X360/blob/master/X360/READ%20ME.txt");
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AgreedToLicense = DontShowLicenseWindow.Checked;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }
    }
}
