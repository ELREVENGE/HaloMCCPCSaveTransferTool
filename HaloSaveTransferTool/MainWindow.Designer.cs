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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReachExportScreenShots = new System.Windows.Forms.Button();
            this.HaloReachScreenshotSaves = new System.Windows.Forms.DataGridView();
            this.ReachExportMaps = new System.Windows.Forms.Button();
            this.HaloReachGameTypeSaves = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaloReachMapSaves = new System.Windows.Forms.DataGridView();
            this.SaveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReachExportGametypes = new System.Windows.Forms.Button();
            this.Halo3 = new System.Windows.Forms.TabPage();
            this.Halo3TableLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.H3ExportScreenshots = new System.Windows.Forms.Button();
            this.Halo3ScreenshotSaves = new System.Windows.Forms.DataGridView();
            this.H3ExportMaps = new System.Windows.Forms.Button();
            this.Halo3GameTypeSaves = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Halo3MapSaves = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H3ExportGameTypes = new System.Windows.Forms.Button();
            this.OpenPannel = new System.Windows.Forms.Panel();
            this.OpenedLabel = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.exportAndSettingsTabControl = new System.Windows.Forms.TabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.OtherTabPage = new System.Windows.Forms.TabPage();
            this.HelpLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.settingsControl = new HaloMCCPCSaveTransferTool.SettingsControl();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thumbnail = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportTab.SuspendLayout();
            this.FilesPannel.SuspendLayout();
            this.gameTabControl.SuspendLayout();
            this.ReachTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HaloReachScreenshotSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaloReachGameTypeSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaloReachMapSaves)).BeginInit();
            this.Halo3.SuspendLayout();
            this.Halo3TableLayoutPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Halo3ScreenshotSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Halo3GameTypeSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Halo3MapSaves)).BeginInit();
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
            this.gameTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameTabControl.Location = new System.Drawing.Point(3, 43);
            this.gameTabControl.Name = "gameTabControl";
            this.gameTabControl.SelectedIndex = 0;
            this.gameTabControl.Size = new System.Drawing.Size(997, 387);
            this.gameTabControl.TabIndex = 16;
            // 
            // ReachTab
            // 
            this.ReachTab.Controls.Add(this.tableLayoutPanel1);
            this.ReachTab.Location = new System.Drawing.Point(4, 22);
            this.ReachTab.Name = "ReachTab";
            this.ReachTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReachTab.Size = new System.Drawing.Size(989, 361);
            this.ReachTab.TabIndex = 0;
            this.ReachTab.Text = "Reach";
            this.ReachTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ReachExportScreenShots, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.HaloReachScreenshotSaves, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReachExportMaps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HaloReachGameTypeSaves, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HaloReachMapSaves, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReachExportGametypes, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(983, 355);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ReachExportScreenShots
            // 
            this.ReachExportScreenShots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReachExportScreenShots.Location = new System.Drawing.Point(657, 308);
            this.ReachExportScreenShots.Name = "ReachExportScreenShots";
            this.ReachExportScreenShots.Size = new System.Drawing.Size(323, 44);
            this.ReachExportScreenShots.TabIndex = 9;
            this.ReachExportScreenShots.Text = "Export Selected Screenshots";
            this.ReachExportScreenShots.UseVisualStyleBackColor = true;
            this.ReachExportScreenShots.Click += new System.EventHandler(this.ReachExportScreenShots_Click);
            // 
            // HaloReachScreenshotSaves
            // 
            this.HaloReachScreenshotSaves.AllowUserToAddRows = false;
            this.HaloReachScreenshotSaves.AllowUserToDeleteRows = false;
            this.HaloReachScreenshotSaves.AllowUserToResizeRows = false;
            this.HaloReachScreenshotSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HaloReachScreenshotSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HaloReachScreenshotSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thumbnail,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.HaloReachScreenshotSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HaloReachScreenshotSaves.Location = new System.Drawing.Point(657, 3);
            this.HaloReachScreenshotSaves.Name = "HaloReachScreenshotSaves";
            this.HaloReachScreenshotSaves.RowHeadersVisible = false;
            this.HaloReachScreenshotSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HaloReachScreenshotSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HaloReachScreenshotSaves.Size = new System.Drawing.Size(323, 299);
            this.HaloReachScreenshotSaves.TabIndex = 9;
            // 
            // ReachExportMaps
            // 
            this.ReachExportMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReachExportMaps.Location = new System.Drawing.Point(3, 308);
            this.ReachExportMaps.Name = "ReachExportMaps";
            this.ReachExportMaps.Size = new System.Drawing.Size(321, 44);
            this.ReachExportMaps.TabIndex = 8;
            this.ReachExportMaps.Text = "Export Selected Maps";
            this.ReachExportMaps.UseVisualStyleBackColor = true;
            this.ReachExportMaps.Click += new System.EventHandler(this.ReachExportMaps_Click);
            // 
            // HaloReachGameTypeSaves
            // 
            this.HaloReachGameTypeSaves.AllowUserToAddRows = false;
            this.HaloReachGameTypeSaves.AllowUserToDeleteRows = false;
            this.HaloReachGameTypeSaves.AllowUserToResizeRows = false;
            this.HaloReachGameTypeSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HaloReachGameTypeSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HaloReachGameTypeSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.GTLocation});
            this.HaloReachGameTypeSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HaloReachGameTypeSaves.Location = new System.Drawing.Point(330, 3);
            this.HaloReachGameTypeSaves.Name = "HaloReachGameTypeSaves";
            this.HaloReachGameTypeSaves.RowHeadersVisible = false;
            this.HaloReachGameTypeSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HaloReachGameTypeSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HaloReachGameTypeSaves.Size = new System.Drawing.Size(321, 299);
            this.HaloReachGameTypeSaves.TabIndex = 6;
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
            // HaloReachMapSaves
            // 
            this.HaloReachMapSaves.AllowUserToAddRows = false;
            this.HaloReachMapSaves.AllowUserToDeleteRows = false;
            this.HaloReachMapSaves.AllowUserToResizeRows = false;
            this.HaloReachMapSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HaloReachMapSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HaloReachMapSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaveName,
            this.CreatedDate,
            this.ModifiedDate,
            this.MapLocationColumn});
            this.HaloReachMapSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HaloReachMapSaves.Location = new System.Drawing.Point(3, 3);
            this.HaloReachMapSaves.Name = "HaloReachMapSaves";
            this.HaloReachMapSaves.RowHeadersVisible = false;
            this.HaloReachMapSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HaloReachMapSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HaloReachMapSaves.Size = new System.Drawing.Size(321, 299);
            this.HaloReachMapSaves.TabIndex = 5;
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
            // MapLocationColumn
            // 
            this.MapLocationColumn.HeaderText = "Location";
            this.MapLocationColumn.Name = "MapLocationColumn";
            this.MapLocationColumn.ReadOnly = true;
            // 
            // ReachExportGametypes
            // 
            this.ReachExportGametypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReachExportGametypes.Location = new System.Drawing.Point(330, 308);
            this.ReachExportGametypes.Name = "ReachExportGametypes";
            this.ReachExportGametypes.Size = new System.Drawing.Size(321, 44);
            this.ReachExportGametypes.TabIndex = 7;
            this.ReachExportGametypes.Text = "Export Selected Gametypes";
            this.ReachExportGametypes.UseVisualStyleBackColor = true;
            this.ReachExportGametypes.Click += new System.EventHandler(this.ReachExportGametypes_Click);
            // 
            // Halo3
            // 
            this.Halo3.Controls.Add(this.Halo3TableLayoutPannel);
            this.Halo3.Location = new System.Drawing.Point(4, 22);
            this.Halo3.Name = "Halo3";
            this.Halo3.Padding = new System.Windows.Forms.Padding(3);
            this.Halo3.Size = new System.Drawing.Size(989, 361);
            this.Halo3.TabIndex = 1;
            this.Halo3.Text = "Halo 3";
            this.Halo3.UseVisualStyleBackColor = true;
            // 
            // Halo3TableLayoutPannel
            // 
            this.Halo3TableLayoutPannel.ColumnCount = 3;
            this.Halo3TableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Halo3TableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Halo3TableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Halo3TableLayoutPannel.Controls.Add(this.H3ExportScreenshots, 2, 1);
            this.Halo3TableLayoutPannel.Controls.Add(this.Halo3ScreenshotSaves, 2, 0);
            this.Halo3TableLayoutPannel.Controls.Add(this.H3ExportMaps, 0, 1);
            this.Halo3TableLayoutPannel.Controls.Add(this.Halo3GameTypeSaves, 0, 0);
            this.Halo3TableLayoutPannel.Controls.Add(this.Halo3MapSaves, 0, 0);
            this.Halo3TableLayoutPannel.Controls.Add(this.H3ExportGameTypes, 1, 1);
            this.Halo3TableLayoutPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo3TableLayoutPannel.Location = new System.Drawing.Point(3, 3);
            this.Halo3TableLayoutPannel.Name = "Halo3TableLayoutPannel";
            this.Halo3TableLayoutPannel.RowCount = 2;
            this.Halo3TableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Halo3TableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Halo3TableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Halo3TableLayoutPannel.Size = new System.Drawing.Size(983, 355);
            this.Halo3TableLayoutPannel.TabIndex = 17;
            // 
            // H3ExportScreenshots
            // 
            this.H3ExportScreenshots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.H3ExportScreenshots.Location = new System.Drawing.Point(657, 308);
            this.H3ExportScreenshots.Name = "H3ExportScreenshots";
            this.H3ExportScreenshots.Size = new System.Drawing.Size(323, 44);
            this.H3ExportScreenshots.TabIndex = 9;
            this.H3ExportScreenshots.Text = "Export Selected Screenshots";
            this.H3ExportScreenshots.UseVisualStyleBackColor = true;
            this.H3ExportScreenshots.Click += new System.EventHandler(this.H3ExportScreenshots_Click);
            // 
            // Halo3ScreenshotSaves
            // 
            this.Halo3ScreenshotSaves.AllowUserToAddRows = false;
            this.Halo3ScreenshotSaves.AllowUserToDeleteRows = false;
            this.Halo3ScreenshotSaves.AllowUserToResizeRows = false;
            this.Halo3ScreenshotSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Halo3ScreenshotSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Halo3ScreenshotSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11});
            this.Halo3ScreenshotSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo3ScreenshotSaves.Location = new System.Drawing.Point(657, 3);
            this.Halo3ScreenshotSaves.Name = "Halo3ScreenshotSaves";
            this.Halo3ScreenshotSaves.RowHeadersVisible = false;
            this.Halo3ScreenshotSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Halo3ScreenshotSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Halo3ScreenshotSaves.Size = new System.Drawing.Size(323, 299);
            this.Halo3ScreenshotSaves.TabIndex = 9;
            // 
            // H3ExportMaps
            // 
            this.H3ExportMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.H3ExportMaps.Location = new System.Drawing.Point(3, 308);
            this.H3ExportMaps.Name = "H3ExportMaps";
            this.H3ExportMaps.Size = new System.Drawing.Size(321, 44);
            this.H3ExportMaps.TabIndex = 8;
            this.H3ExportMaps.Text = "Export Selected Maps";
            this.H3ExportMaps.UseVisualStyleBackColor = true;
            this.H3ExportMaps.Click += new System.EventHandler(this.H3ExportMaps_Click);
            // 
            // Halo3GameTypeSaves
            // 
            this.Halo3GameTypeSaves.AllowUserToAddRows = false;
            this.Halo3GameTypeSaves.AllowUserToDeleteRows = false;
            this.Halo3GameTypeSaves.AllowUserToResizeRows = false;
            this.Halo3GameTypeSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Halo3GameTypeSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Halo3GameTypeSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.Halo3GameTypeSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo3GameTypeSaves.Location = new System.Drawing.Point(330, 3);
            this.Halo3GameTypeSaves.Name = "Halo3GameTypeSaves";
            this.Halo3GameTypeSaves.RowHeadersVisible = false;
            this.Halo3GameTypeSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Halo3GameTypeSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Halo3GameTypeSaves.Size = new System.Drawing.Size(321, 299);
            this.Halo3GameTypeSaves.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "Gametype";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Created";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Modified";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Location";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // Halo3MapSaves
            // 
            this.Halo3MapSaves.AllowUserToAddRows = false;
            this.Halo3MapSaves.AllowUserToDeleteRows = false;
            this.Halo3MapSaves.AllowUserToResizeRows = false;
            this.Halo3MapSaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Halo3MapSaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Halo3MapSaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.Halo3MapSaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Halo3MapSaves.Location = new System.Drawing.Point(3, 3);
            this.Halo3MapSaves.Name = "Halo3MapSaves";
            this.Halo3MapSaves.RowHeadersVisible = false;
            this.Halo3MapSaves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Halo3MapSaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Halo3MapSaves.Size = new System.Drawing.Size(321, 299);
            this.Halo3MapSaves.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn16.Frozen = true;
            this.dataGridViewTextBoxColumn16.HeaderText = "Map";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 81;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Created";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Modified";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Location";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // H3ExportGameTypes
            // 
            this.H3ExportGameTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.H3ExportGameTypes.Location = new System.Drawing.Point(330, 308);
            this.H3ExportGameTypes.Name = "H3ExportGameTypes";
            this.H3ExportGameTypes.Size = new System.Drawing.Size(321, 44);
            this.H3ExportGameTypes.TabIndex = 7;
            this.H3ExportGameTypes.Text = "Export Selected Gametypes";
            this.H3ExportGameTypes.UseVisualStyleBackColor = true;
            this.H3ExportGameTypes.Click += new System.EventHandler(this.H3ExportGameTypes_Click);
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
            this.exportAndSettingsTabControl.Controls.Add(this.SettingsTab);
            this.exportAndSettingsTabControl.Controls.Add(this.OtherTabPage);
            this.exportAndSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportAndSettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.exportAndSettingsTabControl.Name = "exportAndSettingsTabControl";
            this.exportAndSettingsTabControl.SelectedIndex = 0;
            this.exportAndSettingsTabControl.Size = new System.Drawing.Size(1017, 465);
            this.exportAndSettingsTabControl.TabIndex = 8;
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
            // OtherTabPage
            // 
            this.OtherTabPage.Controls.Add(this.HelpLink);
            this.OtherTabPage.Controls.Add(this.linkLabel3);
            this.OtherTabPage.Controls.Add(this.linkLabel1);
            this.OtherTabPage.Controls.Add(this.label1);
            this.OtherTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherTabPage.Name = "OtherTabPage";
            this.OtherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherTabPage.Size = new System.Drawing.Size(1009, 439);
            this.OtherTabPage.TabIndex = 2;
            this.OtherTabPage.Text = "Other";
            this.OtherTabPage.UseVisualStyleBackColor = true;
            // 
            // HelpLink
            // 
            this.HelpLink.AutoSize = true;
            this.HelpLink.Location = new System.Drawing.Point(84, 16);
            this.HelpLink.Name = "HelpLink";
            this.HelpLink.Size = new System.Drawing.Size(87, 13);
            this.HelpLink.TabIndex = 5;
            this.HelpLink.TabStop = true;
            this.HelpLink.Text = "Wiki/Help pages";
            this.HelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelpLink_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 16);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(75, 13);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "View Licenses";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
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
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(3, 3);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(1003, 433);
            this.settingsControl.TabIndex = 0;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "Screenshot";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 192;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Created";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Location";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Thumbnail
            // 
            this.Thumbnail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Thumbnail.Frozen = true;
            this.Thumbnail.HeaderText = "Screenshot";
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.ReadOnly = true;
            this.Thumbnail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Thumbnail.Width = 192;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Created";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Location";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HaloReachScreenshotSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaloReachGameTypeSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HaloReachMapSaves)).EndInit();
            this.Halo3.ResumeLayout(false);
            this.Halo3TableLayoutPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Halo3ScreenshotSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Halo3GameTypeSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Halo3MapSaves)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel FilesPannel;
        private System.Windows.Forms.TabControl gameTabControl;
        private System.Windows.Forms.TabPage ReachTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ReachExportMaps;
        private System.Windows.Forms.DataGridView HaloReachGameTypeSaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTLocation;
        private System.Windows.Forms.DataGridView HaloReachMapSaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapLocationColumn;
        private System.Windows.Forms.Button ReachExportGametypes;
        private System.Windows.Forms.Panel OpenPannel;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label OpenedLabel;
        private System.Windows.Forms.TabPage OtherTabPage;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReachExportScreenShots;
        private System.Windows.Forms.DataGridView HaloReachScreenshotSaves;
        private SettingsControl settingsControl;
        private System.Windows.Forms.LinkLabel HelpLink;
        private System.Windows.Forms.TabPage Halo3;
        private System.Windows.Forms.TableLayoutPanel Halo3TableLayoutPannel;
        private System.Windows.Forms.Button H3ExportScreenshots;
        private System.Windows.Forms.DataGridView Halo3ScreenshotSaves;
        private System.Windows.Forms.Button H3ExportMaps;
        private System.Windows.Forms.DataGridView Halo3GameTypeSaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView Halo3MapSaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Button H3ExportGameTypes;
        private System.Windows.Forms.DataGridViewImageColumn Thumbnail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}

