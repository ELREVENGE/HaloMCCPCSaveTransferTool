namespace HaloMCCPCSaveTransferTool
{
    partial class ExportPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExportGametypesButton = new System.Windows.Forms.Button();
            this.MapModifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapList = new System.Windows.Forms.DataGridView();
            this.MapLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportMapsButton = new System.Windows.Forms.Button();
            this.ScreenshotLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenshotCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenshotNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThumbnailColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExportScreenShotsButton = new System.Windows.Forms.Button();
            this.ScreenshotList = new System.Windows.Forms.DataGridView();
            this.GameTypeList = new System.Windows.Forms.DataGridView();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MapList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeList)).BeginInit();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportGametypesButton
            // 
            this.ExportGametypesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportGametypesButton.Location = new System.Drawing.Point(330, 308);
            this.ExportGametypesButton.Name = "ExportGametypesButton";
            this.ExportGametypesButton.Size = new System.Drawing.Size(321, 44);
            this.ExportGametypesButton.TabIndex = 7;
            this.ExportGametypesButton.Text = "Export Selected Gametypes";
            this.ExportGametypesButton.UseVisualStyleBackColor = true;
            this.ExportGametypesButton.Click += new System.EventHandler(this.ExportGametypesButton_Click);
            // 
            // MapModifiedDateColumn
            // 
            this.MapModifiedDateColumn.HeaderText = "Modified";
            this.MapModifiedDateColumn.Name = "MapModifiedDateColumn";
            this.MapModifiedDateColumn.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Created";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // MapNameColumn
            // 
            this.MapNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MapNameColumn.Frozen = true;
            this.MapNameColumn.HeaderText = "Map";
            this.MapNameColumn.Name = "MapNameColumn";
            this.MapNameColumn.ReadOnly = true;
            this.MapNameColumn.Width = 81;
            // 
            // MapList
            // 
            this.MapList.AllowUserToAddRows = false;
            this.MapList.AllowUserToDeleteRows = false;
            this.MapList.AllowUserToResizeRows = false;
            this.MapList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MapList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MapList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MapNameColumn,
            this.CreatedDate,
            this.MapModifiedDateColumn,
            this.MapLocationColumn});
            this.MapList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapList.Location = new System.Drawing.Point(3, 3);
            this.MapList.Name = "MapList";
            this.MapList.RowHeadersVisible = false;
            this.MapList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MapList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MapList.Size = new System.Drawing.Size(321, 299);
            this.MapList.TabIndex = 5;
            // 
            // MapLocationColumn
            // 
            this.MapLocationColumn.HeaderText = "Location";
            this.MapLocationColumn.Name = "MapLocationColumn";
            this.MapLocationColumn.ReadOnly = true;
            // 
            // GameTypeLocationColumn
            // 
            this.GameTypeLocationColumn.HeaderText = "Location";
            this.GameTypeLocationColumn.Name = "GameTypeLocationColumn";
            this.GameTypeLocationColumn.ReadOnly = true;
            // 
            // GameTypeModifiedColumn
            // 
            this.GameTypeModifiedColumn.HeaderText = "Modified";
            this.GameTypeModifiedColumn.Name = "GameTypeModifiedColumn";
            this.GameTypeModifiedColumn.ReadOnly = true;
            // 
            // GameTypeCreatedColumn
            // 
            this.GameTypeCreatedColumn.HeaderText = "Created";
            this.GameTypeCreatedColumn.Name = "GameTypeCreatedColumn";
            this.GameTypeCreatedColumn.ReadOnly = true;
            // 
            // GameTypeNameColumn
            // 
            this.GameTypeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GameTypeNameColumn.Frozen = true;
            this.GameTypeNameColumn.HeaderText = "Gametype";
            this.GameTypeNameColumn.Name = "GameTypeNameColumn";
            this.GameTypeNameColumn.ReadOnly = true;
            this.GameTypeNameColumn.Width = 80;
            // 
            // ExportMapsButton
            // 
            this.ExportMapsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportMapsButton.Location = new System.Drawing.Point(3, 308);
            this.ExportMapsButton.Name = "ExportMapsButton";
            this.ExportMapsButton.Size = new System.Drawing.Size(321, 44);
            this.ExportMapsButton.TabIndex = 8;
            this.ExportMapsButton.Text = "Export Selected Maps";
            this.ExportMapsButton.UseVisualStyleBackColor = true;
            this.ExportMapsButton.Click += new System.EventHandler(this.ExportMapsButton_Click);
            // 
            // ScreenshotLocationColumn
            // 
            this.ScreenshotLocationColumn.HeaderText = "Location";
            this.ScreenshotLocationColumn.Name = "ScreenshotLocationColumn";
            this.ScreenshotLocationColumn.ReadOnly = true;
            // 
            // ScreenshotCreatedColumn
            // 
            this.ScreenshotCreatedColumn.HeaderText = "Created";
            this.ScreenshotCreatedColumn.Name = "ScreenshotCreatedColumn";
            this.ScreenshotCreatedColumn.ReadOnly = true;
            // 
            // ScreenshotNameColumn
            // 
            this.ScreenshotNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ScreenshotNameColumn.Frozen = true;
            this.ScreenshotNameColumn.HeaderText = "Name";
            this.ScreenshotNameColumn.Name = "ScreenshotNameColumn";
            this.ScreenshotNameColumn.ReadOnly = true;
            this.ScreenshotNameColumn.Width = 80;
            // 
            // ThumbnailColumn
            // 
            this.ThumbnailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThumbnailColumn.Frozen = true;
            this.ThumbnailColumn.HeaderText = "Screenshot";
            this.ThumbnailColumn.Name = "ThumbnailColumn";
            this.ThumbnailColumn.ReadOnly = true;
            this.ThumbnailColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThumbnailColumn.Width = 192;
            // 
            // ExportScreenShotsButton
            // 
            this.ExportScreenShotsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportScreenShotsButton.Location = new System.Drawing.Point(657, 308);
            this.ExportScreenShotsButton.Name = "ExportScreenShotsButton";
            this.ExportScreenShotsButton.Size = new System.Drawing.Size(323, 44);
            this.ExportScreenShotsButton.TabIndex = 9;
            this.ExportScreenShotsButton.Text = "Export Selected Screenshots";
            this.ExportScreenShotsButton.UseVisualStyleBackColor = true;
            this.ExportScreenShotsButton.Click += new System.EventHandler(this.ExportScreenShotsButton_Click);
            // 
            // ScreenshotList
            // 
            this.ScreenshotList.AllowUserToAddRows = false;
            this.ScreenshotList.AllowUserToDeleteRows = false;
            this.ScreenshotList.AllowUserToResizeRows = false;
            this.ScreenshotList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScreenshotList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScreenshotList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThumbnailColumn,
            this.ScreenshotNameColumn,
            this.ScreenshotCreatedColumn,
            this.ScreenshotLocationColumn});
            this.ScreenshotList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenshotList.Location = new System.Drawing.Point(657, 3);
            this.ScreenshotList.Name = "ScreenshotList";
            this.ScreenshotList.RowHeadersVisible = false;
            this.ScreenshotList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScreenshotList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScreenshotList.Size = new System.Drawing.Size(323, 299);
            this.ScreenshotList.TabIndex = 9;
            // 
            // GameTypeList
            // 
            this.GameTypeList.AllowUserToAddRows = false;
            this.GameTypeList.AllowUserToDeleteRows = false;
            this.GameTypeList.AllowUserToResizeRows = false;
            this.GameTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameTypeNameColumn,
            this.GameTypeCreatedColumn,
            this.GameTypeModifiedColumn,
            this.GameTypeLocationColumn});
            this.GameTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameTypeList.Location = new System.Drawing.Point(330, 3);
            this.GameTypeList.Name = "GameTypeList";
            this.GameTypeList.RowHeadersVisible = false;
            this.GameTypeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameTypeList.Size = new System.Drawing.Size(321, 299);
            this.GameTypeList.TabIndex = 6;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 3;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LayoutPanel.Controls.Add(this.ExportScreenShotsButton, 2, 1);
            this.LayoutPanel.Controls.Add(this.ScreenshotList, 2, 0);
            this.LayoutPanel.Controls.Add(this.ExportMapsButton, 0, 1);
            this.LayoutPanel.Controls.Add(this.GameTypeList, 0, 0);
            this.LayoutPanel.Controls.Add(this.MapList, 0, 0);
            this.LayoutPanel.Controls.Add(this.ExportGametypesButton, 1, 1);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 2;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanel.Size = new System.Drawing.Size(983, 355);
            this.LayoutPanel.TabIndex = 18;
            // 
            // ExportPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutPanel);
            this.Name = "ExportPanel";
            this.Size = new System.Drawing.Size(983, 355);
            ((System.ComponentModel.ISupportInitialize)(this.MapList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameTypeList)).EndInit();
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportGametypesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapModifiedDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapNameColumn;
        private System.Windows.Forms.DataGridView MapList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapLocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeLocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeModifiedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTypeNameColumn;
        private System.Windows.Forms.Button ExportMapsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenshotLocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenshotCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenshotNameColumn;
        private System.Windows.Forms.DataGridViewImageColumn ThumbnailColumn;
        private System.Windows.Forms.Button ExportScreenShotsButton;
        private System.Windows.Forms.DataGridView ScreenshotList;
        private System.Windows.Forms.DataGridView GameTypeList;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
    }
}
