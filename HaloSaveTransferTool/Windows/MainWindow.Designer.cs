namespace HaloMCCPCSaveTransferTool
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ExportTab = new System.Windows.Forms.TabPage();
            this.FilesPannel = new System.Windows.Forms.TableLayoutPanel();
            this.gameTabControl = new System.Windows.Forms.TabControl();
            this.ReachTab = new System.Windows.Forms.TabPage();
            this.ReachExportPanel = new HaloMCCPCSaveTransferTool.ExportPanel();
            this.Halo3 = new System.Windows.Forms.TabPage();
            this.Halo3ExportPanel = new HaloMCCPCSaveTransferTool.ExportPanel();
            this.ODST = new System.Windows.Forms.TabPage();
            this.Halo3ODSTExportPanel = new HaloMCCPCSaveTransferTool.ExportPanel();
            this.OpenPannel = new System.Windows.Forms.Panel();
            this.OpenedLabel = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.exportAndSettingsTabControl = new System.Windows.Forms.TabControl();
            this.ManageTab = new System.Windows.Forms.TabPage();
            this.MapAndGameTypeTabControl = new System.Windows.Forms.TabControl();
            this.MapsTab = new System.Windows.Forms.TabPage();
            this.ManageMapsPanel = new HaloMCCPCSaveTransferTool.ManagePanel();
            this.GameTypesTab = new System.Windows.Forms.TabPage();
            this.ManageGameTypesPanel = new HaloMCCPCSaveTransferTool.ManagePanel();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.settingsControl = new HaloMCCPCSaveTransferTool.SettingsControl();
            this.OtherTabPage = new System.Windows.Forms.TabPage();
            this.IssuesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HelpLink = new System.Windows.Forms.LinkLabel();
            this.ViewLicensesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Halo4Tab = new System.Windows.Forms.TabPage();
            this.Halo4ExportPanel = new HaloMCCPCSaveTransferTool.ExportPanel();
            this.ExportTab.SuspendLayout();
            this.FilesPannel.SuspendLayout();
            this.gameTabControl.SuspendLayout();
            this.ReachTab.SuspendLayout();
            this.Halo3.SuspendLayout();
            this.ODST.SuspendLayout();
            this.OpenPannel.SuspendLayout();
            this.exportAndSettingsTabControl.SuspendLayout();
            this.ManageTab.SuspendLayout();
            this.MapAndGameTypeTabControl.SuspendLayout();
            this.MapsTab.SuspendLayout();
            this.GameTypesTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.OtherTabPage.SuspendLayout();
            this.Halo4Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputTextBox.Location = new System.Drawing.Point(0, 465);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.OutputTextBox.Size = new System.Drawing.Size(1017, 96);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.Text = "";
            // 
            // ExportTab
            // 
            this.ExportTab.Controls.Add(this.FilesPannel);
            this.ExportTab.Location = new System.Drawing.Point(4, 22);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExportTab.Size = new System.Drawing.Size(1009, 439);
            this.ExportTab.TabIndex = 0;
            this.ExportTab.Text = "Export";
            this.ExportTab.UseVisualStyleBackColor = true;
            // 
            // FilesPannel
            // 
            this.FilesPannel.ColumnCount = 1;
            this.FilesPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FilesPannel.Controls.Add(this.gameTabControl, 0, 1);
            this.FilesPannel.Controls.Add(this.OpenPannel, 0, 0);
            this.FilesPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesPannel.Location = new System.Drawing.Point(3, 3);
            this.FilesPannel.Name = "FilesPannel";
            this.FilesPannel.RowCount = 2;
            this.FilesPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.FilesPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FilesPannel.Size = new System.Drawing.Size(1003, 433);
            this.FilesPannel.TabIndex = 13;
            // 
            // gameTabControl
            // 
            this.gameTabControl.Controls.Add(this.ReachTab);
            this.gameTabControl.Controls.Add(this.Halo3);
            this.gameTabControl.Controls.Add(this.ODST);
            this.gameTabControl.Controls.Add(this.Halo4Tab);
            this.gameTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTabControl.Location = new System.Drawing.Point(3, 43);
            this.gameTabControl.Name = "gameTabControl";
            this.gameTabControl.SelectedIndex = 0;
            this.gameTabControl.Size = new System.Drawing.Size(997, 387);
            this.gameTabControl.TabIndex = 16;
            // 
            // ReachTab
            // 
            this.ReachTab.Controls.Add(this.ReachExportPanel);
            this.ReachTab.Location = new System.Drawing.Point(4, 22);
            this.ReachTab.Name = "ReachTab";
            this.ReachTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReachTab.Size = new System.Drawing.Size(989, 361);
            this.ReachTab.TabIndex = 0;
            this.ReachTab.Text = "Reach";
            this.ReachTab.UseVisualStyleBackColor = true;
            // 
            // ReachExportPanel
            // 
            this.ReachExportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReachExportPanel.Location = new System.Drawing.Point(3, 3);
            this.ReachExportPanel.Name = "ReachExportPanel";
            this.ReachExportPanel.Size = new System.Drawing.Size(983, 355);
            this.ReachExportPanel.TabIndex = 0;
            // 
            // Halo3
            // 
            this.Halo3.Controls.Add(this.Halo3ExportPanel);
            this.Halo3.Location = new System.Drawing.Point(4, 22);
            this.Halo3.Name = "Halo3";
            this.Halo3.Padding = new System.Windows.Forms.Padding(3);
            this.Halo3.Size = new System.Drawing.Size(989, 361);
            this.Halo3.TabIndex = 1;
            this.Halo3.Text = "Halo 3";
            this.Halo3.UseVisualStyleBackColor = true;
            // 
            // Halo3ExportPanel
            // 
            this.Halo3ExportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo3ExportPanel.Location = new System.Drawing.Point(3, 3);
            this.Halo3ExportPanel.Name = "Halo3ExportPanel";
            this.Halo3ExportPanel.Size = new System.Drawing.Size(983, 355);
            this.Halo3ExportPanel.TabIndex = 1;
            // 
            // ODST
            // 
            this.ODST.Controls.Add(this.Halo3ODSTExportPanel);
            this.ODST.Location = new System.Drawing.Point(4, 22);
            this.ODST.Name = "ODST";
            this.ODST.Padding = new System.Windows.Forms.Padding(3);
            this.ODST.Size = new System.Drawing.Size(989, 361);
            this.ODST.TabIndex = 2;
            this.ODST.Text = "ODST";
            this.ODST.UseVisualStyleBackColor = true;
            // 
            // Halo3ODSTExportPanel
            // 
            this.Halo3ODSTExportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo3ODSTExportPanel.Location = new System.Drawing.Point(3, 3);
            this.Halo3ODSTExportPanel.Name = "Halo3ODSTExportPanel";
            this.Halo3ODSTExportPanel.Size = new System.Drawing.Size(983, 355);
            this.Halo3ODSTExportPanel.TabIndex = 1;
            // 
            // OpenPannel
            // 
            this.OpenPannel.Controls.Add(this.OpenedLabel);
            this.OpenPannel.Controls.Add(this.Open);
            this.OpenPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenPannel.Location = new System.Drawing.Point(3, 3);
            this.OpenPannel.Name = "OpenPannel";
            this.OpenPannel.Size = new System.Drawing.Size(997, 34);
            this.OpenPannel.TabIndex = 15;
            // 
            // OpenedLabel
            // 
            this.OpenedLabel.AutoSize = true;
            this.OpenedLabel.Location = new System.Drawing.Point(109, 11);
            this.OpenedLabel.Name = "OpenedLabel";
            this.OpenedLabel.Size = new System.Drawing.Size(63, 13);
            this.OpenedLabel.TabIndex = 14;
            this.OpenedLabel.Text = "360 files in: ";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(3, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 28);
            this.Open.TabIndex = 12;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // exportAndSettingsTabControl
            // 
            this.exportAndSettingsTabControl.Controls.Add(this.ExportTab);
            this.exportAndSettingsTabControl.Controls.Add(this.ManageTab);
            this.exportAndSettingsTabControl.Controls.Add(this.SettingsTab);
            this.exportAndSettingsTabControl.Controls.Add(this.OtherTabPage);
            this.exportAndSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportAndSettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.exportAndSettingsTabControl.Name = "exportAndSettingsTabControl";
            this.exportAndSettingsTabControl.SelectedIndex = 0;
            this.exportAndSettingsTabControl.Size = new System.Drawing.Size(1017, 465);
            this.exportAndSettingsTabControl.TabIndex = 8;
            // 
            // ManageTab
            // 
            this.ManageTab.Controls.Add(this.MapAndGameTypeTabControl);
            this.ManageTab.Location = new System.Drawing.Point(4, 22);
            this.ManageTab.Name = "ManageTab";
            this.ManageTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManageTab.Size = new System.Drawing.Size(1009, 439);
            this.ManageTab.TabIndex = 3;
            this.ManageTab.Text = "Manage";
            this.ManageTab.UseVisualStyleBackColor = true;
            // 
            // MapAndGameTypeTabControl
            // 
            this.MapAndGameTypeTabControl.Controls.Add(this.MapsTab);
            this.MapAndGameTypeTabControl.Controls.Add(this.GameTypesTab);
            this.MapAndGameTypeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapAndGameTypeTabControl.Location = new System.Drawing.Point(3, 3);
            this.MapAndGameTypeTabControl.Name = "MapAndGameTypeTabControl";
            this.MapAndGameTypeTabControl.SelectedIndex = 0;
            this.MapAndGameTypeTabControl.Size = new System.Drawing.Size(1003, 433);
            this.MapAndGameTypeTabControl.TabIndex = 0;
            // 
            // MapsTab
            // 
            this.MapsTab.Controls.Add(this.ManageMapsPanel);
            this.MapsTab.Location = new System.Drawing.Point(4, 22);
            this.MapsTab.Name = "MapsTab";
            this.MapsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MapsTab.Size = new System.Drawing.Size(995, 407);
            this.MapsTab.TabIndex = 0;
            this.MapsTab.Text = "Maps";
            this.MapsTab.UseVisualStyleBackColor = true;
            // 
            // ManageMapsPanel
            // 
            this.ManageMapsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageMapsPanel.Location = new System.Drawing.Point(3, 3);
            this.ManageMapsPanel.Name = "ManageMapsPanel";
            this.ManageMapsPanel.Size = new System.Drawing.Size(989, 401);
            this.ManageMapsPanel.TabIndex = 0;
            // 
            // GameTypesTab
            // 
            this.GameTypesTab.Controls.Add(this.ManageGameTypesPanel);
            this.GameTypesTab.Location = new System.Drawing.Point(4, 22);
            this.GameTypesTab.Name = "GameTypesTab";
            this.GameTypesTab.Padding = new System.Windows.Forms.Padding(3);
            this.GameTypesTab.Size = new System.Drawing.Size(995, 407);
            this.GameTypesTab.TabIndex = 1;
            this.GameTypesTab.Text = "Game Types";
            this.GameTypesTab.UseVisualStyleBackColor = true;
            // 
            // ManageGameTypesPanel
            // 
            this.ManageGameTypesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageGameTypesPanel.Location = new System.Drawing.Point(3, 3);
            this.ManageGameTypesPanel.Name = "ManageGameTypesPanel";
            this.ManageGameTypesPanel.Size = new System.Drawing.Size(989, 401);
            this.ManageGameTypesPanel.TabIndex = 0;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.settingsControl);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(1009, 439);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(3, 3);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(1003, 433);
            this.settingsControl.TabIndex = 0;
            // 
            // OtherTabPage
            // 
            this.OtherTabPage.Controls.Add(this.IssuesLinkLabel);
            this.OtherTabPage.Controls.Add(this.HelpLink);
            this.OtherTabPage.Controls.Add(this.ViewLicensesLinkLabel);
            this.OtherTabPage.Controls.Add(this.GitHubLinkLabel);
            this.OtherTabPage.Controls.Add(this.label1);
            this.OtherTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherTabPage.Name = "OtherTabPage";
            this.OtherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherTabPage.Size = new System.Drawing.Size(1009, 439);
            this.OtherTabPage.TabIndex = 2;
            this.OtherTabPage.Text = "Other";
            this.OtherTabPage.UseVisualStyleBackColor = true;
            // 
            // IssuesLinkLabel
            // 
            this.IssuesLinkLabel.AutoSize = true;
            this.IssuesLinkLabel.Location = new System.Drawing.Point(177, 17);
            this.IssuesLinkLabel.Name = "IssuesLinkLabel";
            this.IssuesLinkLabel.Size = new System.Drawing.Size(134, 13);
            this.IssuesLinkLabel.TabIndex = 6;
            this.IssuesLinkLabel.TabStop = true;
            this.IssuesLinkLabel.Text = "View or submit a new issue";
            this.IssuesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IssuesLinkLabel_LinkClicked);
            // 
            // HelpLink
            // 
            this.HelpLink.AutoSize = true;
            this.HelpLink.Location = new System.Drawing.Point(84, 17);
            this.HelpLink.Name = "HelpLink";
            this.HelpLink.Size = new System.Drawing.Size(87, 13);
            this.HelpLink.TabIndex = 5;
            this.HelpLink.TabStop = true;
            this.HelpLink.Text = "Wiki/Help pages";
            this.HelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLink_LinkClicked);
            // 
            // ViewLicensesLinkLabel
            // 
            this.ViewLicensesLinkLabel.AutoSize = true;
            this.ViewLicensesLinkLabel.Location = new System.Drawing.Point(3, 17);
            this.ViewLicensesLinkLabel.Name = "ViewLicensesLinkLabel";
            this.ViewLicensesLinkLabel.Size = new System.Drawing.Size(75, 13);
            this.ViewLicensesLinkLabel.TabIndex = 4;
            this.ViewLicensesLinkLabel.TabStop = true;
            this.ViewLicensesLinkLabel.Text = "View Licenses";
            this.ViewLicensesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewLicensesLinkLabel_LinkClicked);
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(267, 3);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(277, 13);
            this.GitHubLinkLabel.TabIndex = 1;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "https://github.com/ELREVENGE/HaloSaveTransferTool";
            this.GitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This program is open source the code can be found at:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AddExtension = false;
            this.saveFileDialog.CheckFileExists = true;
            // 
            // Halo4Tab
            // 
            this.Halo4Tab.Controls.Add(this.Halo4ExportPanel);
            this.Halo4Tab.Location = new System.Drawing.Point(4, 22);
            this.Halo4Tab.Name = "Halo4Tab";
            this.Halo4Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Halo4Tab.Size = new System.Drawing.Size(989, 361);
            this.Halo4Tab.TabIndex = 3;
            this.Halo4Tab.Text = "Halo 4";
            this.Halo4Tab.UseVisualStyleBackColor = true;
            // 
            // Halo4ExportPanel
            // 
            this.Halo4ExportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo4ExportPanel.Location = new System.Drawing.Point(3, 3);
            this.Halo4ExportPanel.Name = "Halo4ExportPanel";
            this.Halo4ExportPanel.Size = new System.Drawing.Size(983, 355);
            this.Halo4ExportPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 561);
            this.Controls.Add(this.exportAndSettingsTabControl);
            this.Controls.Add(this.OutputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Halo MCC PC Save Transfer Tool";
            this.ExportTab.ResumeLayout(false);
            this.FilesPannel.ResumeLayout(false);
            this.gameTabControl.ResumeLayout(false);
            this.ReachTab.ResumeLayout(false);
            this.Halo3.ResumeLayout(false);
            this.ODST.ResumeLayout(false);
            this.OpenPannel.ResumeLayout(false);
            this.OpenPannel.PerformLayout();
            this.exportAndSettingsTabControl.ResumeLayout(false);
            this.ManageTab.ResumeLayout(false);
            this.MapAndGameTypeTabControl.ResumeLayout(false);
            this.MapsTab.ResumeLayout(false);
            this.GameTypesTab.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.OtherTabPage.ResumeLayout(false);
            this.OtherTabPage.PerformLayout();
            this.Halo4Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.TabPage ExportTab;
        private System.Windows.Forms.TabControl exportAndSettingsTabControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TableLayoutPanel FilesPannel;
        private System.Windows.Forms.TabControl gameTabControl;
        private System.Windows.Forms.TabPage ReachTab;
        private System.Windows.Forms.Panel OpenPannel;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label OpenedLabel;
        private System.Windows.Forms.TabPage OtherTabPage;
        private System.Windows.Forms.LinkLabel ViewLicensesLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel HelpLink;
        private System.Windows.Forms.TabPage Halo3;
        private System.Windows.Forms.TabPage ODST;
        private System.Windows.Forms.TabPage ManageTab;
        private System.Windows.Forms.TabControl MapAndGameTypeTabControl;
        private System.Windows.Forms.TabPage MapsTab;
        private System.Windows.Forms.TabPage GameTypesTab;
        private ExportPanel ReachExportPanel;
        private ExportPanel Halo3ExportPanel;
        private ExportPanel Halo3ODSTExportPanel;
        private SettingsControl settingsControl;
        private ManagePanel ManageMapsPanel;
        private ManagePanel ManageGameTypesPanel;
        private System.Windows.Forms.LinkLabel IssuesLinkLabel;
        private System.Windows.Forms.TabPage Halo4Tab;
        private ExportPanel Halo4ExportPanel;
    }
}

