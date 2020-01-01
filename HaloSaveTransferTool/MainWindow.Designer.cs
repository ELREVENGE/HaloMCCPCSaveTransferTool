namespace HaloSaveTransferTool
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
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ExportTab = new System.Windows.Forms.TabPage();
            this.FilesPannel = new System.Windows.Forms.TableLayoutPanel();
            this.gameTabControl = new System.Windows.Forms.TabControl();
            this.ReachTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExportMaps = new System.Windows.Forms.Button();
            this.GameTypeSaves = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapSaves = new System.Windows.Forms.DataGridView();
            this.SaveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportGametypes = new System.Windows.Forms.Button();
            this.OpenPannel = new System.Windows.Forms.Panel();
            this.OpenedLabel = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.exportAndSettingsTabControl = new System.Windows.Forms.TabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.settingsControl = new HaloSaveTransferTool.SettingsControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OtherTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.ExportTab.SuspendLayout();
            this.FilesPannel.SuspendLayout();
            this.gameTabControl.SuspendLayout();
            this.ReachTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapSaves)).BeginInit();
            this.OpenPannel.SuspendLayout();
            this.exportAndSettingsTabControl.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.OtherTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputTextBox.Location = new System.Drawing.Point(0, 465);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.OutputTextBox.Size = new System.Drawing.Size(684, 96);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.Text = "";
            // 
            // ExportTab
            // 
            this.ExportTab.Controls.Add(this.FilesPannel);
            this.ExportTab.Location = new System.Drawing.Point(4, 22);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExportTab.Size = new System.Drawing.Size(676, 439);
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
            this.FilesPannel.Size = new System.Drawing.Size(670, 433);
            this.FilesPannel.TabIndex = 13;
            // 
            // gameTabControl
            // 
            this.gameTabControl.Controls.Add(this.ReachTab);
            this.gameTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTabControl.Location = new System.Drawing.Point(3, 43);
            this.gameTabControl.Name = "gameTabControl";
            this.gameTabControl.SelectedIndex = 0;
            this.gameTabControl.Size = new System.Drawing.Size(664, 387);
            this.gameTabControl.TabIndex = 16;
            // 
            // ReachTab
            // 
            this.ReachTab.Controls.Add(this.tableLayoutPanel1);
            this.ReachTab.Location = new System.Drawing.Point(4, 22);
            this.ReachTab.Name = "ReachTab";
            this.ReachTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReachTab.Size = new System.Drawing.Size(656, 361);
            this.ReachTab.TabIndex = 0;
            this.ReachTab.Text = "Reach";
            this.ReachTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ExportMaps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameTypeSaves, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MapSaves, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExportGametypes, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 355);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ExportMaps
            // 
            this.ExportMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportMaps.Location = new System.Drawing.Point(3, 308);
            this.ExportMaps.Name = "ExportMaps";
            this.ExportMaps.Size = new System.Drawing.Size(319, 44);
            this.ExportMaps.TabIndex = 8;
            this.ExportMaps.Text = "Export Selected Maps";
            this.ExportMaps.UseVisualStyleBackColor = true;
            this.ExportMaps.Click += new System.EventHandler(this.ExportMaps_Click);
            // 
            // GameTypeSaves
            // 
            this.GameTypeSaves.AllowUserToAddRows = false;
            this.GameTypeSaves.AllowUserToDeleteRows = false;
            this.GameTypeSaves.AllowUserToResizeRows = false;
            this.GameTypeSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameTypeSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameTypeSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.GTLocation});
            this.GameTypeSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameTypeSaves.Location = new System.Drawing.Point(328, 3);
            this.GameTypeSaves.Name = "GameTypeSaves";
            this.GameTypeSaves.RowHeadersVisible = false;
            this.GameTypeSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameTypeSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameTypeSaves.Size = new System.Drawing.Size(319, 299);
            this.GameTypeSaves.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Gametype";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Created";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Modified";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // GTLocation
            // 
            this.GTLocation.HeaderText = "Location";
            this.GTLocation.Name = "GTLocation";
            this.GTLocation.ReadOnly = true;
            // 
            // MapSaves
            // 
            this.MapSaves.AllowUserToAddRows = false;
            this.MapSaves.AllowUserToDeleteRows = false;
            this.MapSaves.AllowUserToResizeRows = false;
            this.MapSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MapSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaveName,
            this.CreatedDate,
            this.ModifiedDate,
            this.Location});
            this.MapSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapSaves.Location = new System.Drawing.Point(3, 3);
            this.MapSaves.Name = "MapSaves";
            this.MapSaves.RowHeadersVisible = false;
            this.MapSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MapSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MapSaves.Size = new System.Drawing.Size(319, 299);
            this.MapSaves.TabIndex = 5;
            // 
            // SaveName
            // 
            this.SaveName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SaveName.Frozen = true;
            this.SaveName.HeaderText = "Map";
            this.SaveName.Name = "SaveName";
            this.SaveName.ReadOnly = true;
            this.SaveName.Width = 81;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Created";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.HeaderText = "Modified";
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // ExportGametypes
            // 
            this.ExportGametypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportGametypes.Location = new System.Drawing.Point(328, 308);
            this.ExportGametypes.Name = "ExportGametypes";
            this.ExportGametypes.Size = new System.Drawing.Size(319, 44);
            this.ExportGametypes.TabIndex = 7;
            this.ExportGametypes.Text = "Export Selected Gametypes";
            this.ExportGametypes.UseVisualStyleBackColor = true;
            this.ExportGametypes.Click += new System.EventHandler(this.ExportGametypes_Click);
            // 
            // OpenPannel
            // 
            this.OpenPannel.Controls.Add(this.OpenedLabel);
            this.OpenPannel.Controls.Add(this.Open);
            this.OpenPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenPannel.Location = new System.Drawing.Point(3, 3);
            this.OpenPannel.Name = "OpenPannel";
            this.OpenPannel.Size = new System.Drawing.Size(664, 34);
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
            this.exportAndSettingsTabControl.Controls.Add(this.SettingsTab);
            this.exportAndSettingsTabControl.Controls.Add(this.OtherTabPage);
            this.exportAndSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportAndSettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.exportAndSettingsTabControl.Name = "exportAndSettingsTabControl";
            this.exportAndSettingsTabControl.SelectedIndex = 0;
            this.exportAndSettingsTabControl.Size = new System.Drawing.Size(684, 465);
            this.exportAndSettingsTabControl.TabIndex = 8;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.settingsControl);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(676, 439);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(3, 3);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(670, 433);
            this.settingsControl.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AddExtension = false;
            this.saveFileDialog.CheckFileExists = true;
            // 
            // OtherTabPage
            // 
            this.OtherTabPage.Controls.Add(this.linkLabel3);
            this.OtherTabPage.Controls.Add(this.linkLabel2);
            this.OtherTabPage.Controls.Add(this.label2);
            this.OtherTabPage.Controls.Add(this.linkLabel1);
            this.OtherTabPage.Controls.Add(this.label1);
            this.OtherTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherTabPage.Name = "OtherTabPage";
            this.OtherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherTabPage.Size = new System.Drawing.Size(676, 439);
            this.OtherTabPage.TabIndex = 2;
            this.OtherTabPage.Text = "Other";
            this.OtherTabPage.UseVisualStyleBackColor = true;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(267, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(277, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/ELREVENGE/HaloSaveTransferTool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "This program uses";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(102, 32);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(174, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "DJ SkunkieButt\'s X360 .NET library";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(282, 32);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(69, 13);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Open license";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.exportAndSettingsTabControl);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Halo Map Transfer Tool";
            this.ExportTab.ResumeLayout(false);
            this.FilesPannel.ResumeLayout(false);
            this.gameTabControl.ResumeLayout(false);
            this.ReachTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MapSaves)).EndInit();
            this.OpenPannel.ResumeLayout(false);
            this.OpenPannel.PerformLayout();
            this.exportAndSettingsTabControl.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.OtherTabPage.ResumeLayout(false);
            this.OtherTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.TabPage ExportTab;
        private System.Windows.Forms.TabControl exportAndSettingsTabControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage SettingsTab;
        private SettingsControl settingsControl;
        private System.Windows.Forms.TableLayoutPanel FilesPannel;
        private System.Windows.Forms.TabControl gameTabControl;
        private System.Windows.Forms.TabPage ReachTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ExportMaps;
        private System.Windows.Forms.DataGridView GameTypeSaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTLocation;
        private System.Windows.Forms.DataGridView MapSaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.Button ExportGametypes;
        private System.Windows.Forms.Panel OpenPannel;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label OpenedLabel;
        private System.Windows.Forms.TabPage OtherTabPage;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

