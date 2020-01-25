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
            this.SettingsGrid = new System.Windows.Forms.DataGridView();
            this.Setting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Manual = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkForUpdateCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsGrid)).BeginInit();
            this.SuspendLayout();
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
            this.Location});
            this.SettingsGrid.Location = new System.Drawing.Point(0, 30);
            this.SettingsGrid.Name = "SettingsGrid";
            this.SettingsGrid.RowHeadersVisible = false;
            this.SettingsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SettingsGrid.Size = new System.Drawing.Size(370, 60);
            this.SettingsGrid.TabIndex = 0;
            this.SettingsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SettingsGrid_CellClick);
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
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // checkForUpdateCheckBox
            // 
            this.checkForUpdateCheckBox.AutoSize = true;
            this.checkForUpdateCheckBox.Location = new System.Drawing.Point(3, 7);
            this.checkForUpdateCheckBox.Name = "checkForUpdateCheckBox";
            this.checkForUpdateCheckBox.Size = new System.Drawing.Size(309, 17);
            this.checkForUpdateCheckBox.TabIndex = 1;
            this.checkForUpdateCheckBox.Text = "Check for updates (Only preformed when the program starts)";
            this.checkForUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkForUpdateCheckBox);
            this.Controls.Add(this.SettingsGrid);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(370, 90);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SettingsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting;
        private System.Windows.Forms.DataGridViewButtonColumn Auto;
        private System.Windows.Forms.DataGridViewButtonColumn Manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.CheckBox checkForUpdateCheckBox;
    }
}
