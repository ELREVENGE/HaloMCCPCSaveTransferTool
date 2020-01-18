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

namespace HaloMCCPCSaveTransferTool
{
    public partial class LicenseWindow : Form
    {
        bool[] read = new bool[3] { true, false, false };
        public LicenseWindow()
        {
            InitializeComponent();
            UpdateAcceptButton();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            read[tabControl1.SelectedIndex] = true;
            UpdateAcceptButton();
        }
        void UpdateAcceptButton()
        {
            bool allRead = true;
            for (int i = 0; i < read.Length; i++)
            {
                if (read[i] == false) { allRead = false; }
            }
            AcceptButton.Enabled = allRead;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int newIndex = tabControl1.SelectedIndex + 1;
            if (newIndex > 2)
            {
                newIndex = 0;
            }
            tabControl1.SelectedIndex = newIndex;
        }

        private void linkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mtolly/X360/blob/master/X360/READ%20ME.txt");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aybe/Windows-API-Code-Pack-1.1/blob/master/LICENCE");
        }
    }
}
