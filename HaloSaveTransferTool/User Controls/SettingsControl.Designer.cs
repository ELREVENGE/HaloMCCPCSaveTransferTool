namespace HaloMCCPCSaveTransferTool
{
    partial class SettingsControl
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
            this.settingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CheckForUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.RecycleInsteadOfDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.WarnBeforeDeletingCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingsGrid = new System.Windows.Forms.DataGridView();
            this.Setting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Manual = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTableLayoutPanel
            // 
            this.settingsTableLayoutPanel.ColumnCount = 1;
            this.settingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.Controls.Add(this.SettingsGrid, 0, 3);
            this.settingsTableLayoutPanel.Controls.Add(this.WarnBeforeDeletingCheckBox, 0, 2);
            this.settingsTableLayoutPanel.Controls.Add(this.RecycleInsteadOfDeleteCheckBox, 0, 1);
            this.settingsTableLayoutPanel.Controls.Add(this.CheckForUpdateCheckBox, 0, 0);
            this.settingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTableLayoutPanel.Name = "settingsTableLayoutPanel";
            this.settingsTableLayoutPanel.RowCount = 4;
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.settingsTableLayoutPanel.Size = new System.Drawing.Size(370, 412);
            this.settingsTableLayoutPanel.TabIndex = 0;
            // 
            // CheckForUpdateCheckBox
            // 
            this.CheckForUpdateCheckBox.AutoSize = true;
            this.CheckForUpdateCheckBox.Location = new System.Drawing.Point(3, 3);
            this.CheckForUpdateCheckBox.Name = "CheckForUpdateCheckBox";
            this.CheckForUpdateCheckBox.Size = new System.Drawing.Size(309, 17);
            this.CheckForUpdateCheckBox.TabIndex = 4;
            this.CheckForUpdateCheckBox.Text = "Check for updates (Only preformed when the program starts)";
            this.CheckForUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // RecycleInsteadOfDeleteCheckBox
            // 
            this.RecycleInsteadOfDeleteCheckBox.AutoSize = true;
            this.RecycleInsteadOfDeleteCheckBox.Checked = true;
            this.RecycleInsteadOfDeleteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecycleInsteadOfDeleteCheckBox.Location = new System.Drawing.Point(3, 33);
            this.RecycleInsteadOfDeleteCheckBox.Name = "RecycleInsteadOfDeleteCheckBox";
            this.RecycleInsteadOfDeleteCheckBox.Size = new System.Drawing.Size(315, 17);
            this.RecycleInsteadOfDeleteCheckBox.TabIndex = 6;
            this.RecycleInsteadOfDeleteCheckBox.Text = "Send files to the recycling bin instead of deleting them forever";
            this.RecycleInsteadOfDeleteCheckBox.UseVisualStyleBackColor = true;
            this.RecycleInsteadOfDeleteCheckBox.CheckedChanged += new System.EventHandler(this.RecycleInsteadOfDeleteCheckBox_CheckedChanged);
            // 
            // WarnBeforeDeletingCheckBox
            // 
            this.WarnBeforeDeletingCheckBox.AutoSize = true;
            this.WarnBeforeDeletingCheckBox.Checked = true;
            this.WarnBeforeDeletingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WarnBeforeDeletingCheckBox.Location = new System.Drawing.Point(3, 63);
            this.WarnBeforeDeletingCheckBox.Name = "WarnBeforeDeletingCheckBox";
            this.WarnBeforeDeletingCheckBox.Size = new System.Drawing.Size(187, 17);
            this.WarnBeforeDeletingCheckBox.TabIndex = 7;
            this.WarnBeforeDeletingCheckBox.Text = "Show warning before deleting files";
            this.WarnBeforeDeletingCheckBox.UseVisualStyleBackColor = true;
            this.WarnBeforeDeletingCheckBox.CheckedChanged += new System.EventHandler(this.WarnBeforeDeletingCheckBox_CheckedChanged);
            // 
            // SettingsGrid
            // 
            this.SettingsGrid.AllowUserToAddRows = false;
            this.SettingsGrid.AllowUserToDeleteRows = false;
            this.SettingsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Setting,
            this.Auto,
            this.Manual,
            this.LocationColumn});
            this.SettingsGrid.Location = new System.Drawing.Point(3, 93);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.RowHeadersVisible = false;
            this.SettingsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SettingsGrid.Size = new System.Drawing.Size(364, 316);
            this.SettingsGrid.TabIndex = 8;
            // 
            // Setting
            // 
            this.Setting.HeaderText = "Setting";
            this.Setting.Name = "Setting";
            this.Setting.ReadOnly = true;
            this.Setting.Width = 75;
            // 
            // Auto
            // 
            this.Auto.HeaderText = "Auto";
            this.Auto.Name = "Auto";
            this.Auto.ReadOnly = true;
            this.Auto.Width = 50;
            // 
            // Manual
            // 
            this.Manual.HeaderText = "Manual";
            this.Manual.Name = "Manual";
            this.Manual.ReadOnly = true;
            this.Manual.Width = 50;
            // 
            // LocationColumn
            // 
            this.LocationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsTableLayoutPanel);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(370, 412);
            this.settingsTableLayoutPanel.ResumeLayout(false);
            this.settingsTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel settingsTableLayoutPanel;
        private System.Windows.Forms.CheckBox RecycleInsteadOfDeleteCheckBox;
        private System.Windows.Forms.CheckBox CheckForUpdateCheckBox;
        private System.Windows.Forms.CheckBox WarnBeforeDeletingCheckBox;
        private System.Windows.Forms.DataGridView SettingsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting;
        private System.Windows.Forms.DataGridViewButtonColumn Auto;
        private System.Windows.Forms.DataGridViewButtonColumn Manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
    }
}
