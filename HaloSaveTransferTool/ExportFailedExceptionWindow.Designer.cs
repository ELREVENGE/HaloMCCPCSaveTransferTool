namespace HaloSaveTransferTool
{
    partial class ExportFailedExceptionWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FailedList = new System.Windows.Forms.DataGridView();
            this.Exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveAs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenameExisting = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FailedList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RenameExisting, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FailedList
            // 
            this.FailedList.AllowUserToAddRows = false;
            this.FailedList.AllowUserToDeleteRows = false;
            this.FailedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FailedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exception,
            this.SaveAs,
            this.SaveName,
            this.Created,
            this.Modified,
            this.Location,
            this.ExportLocation});
            this.FailedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FailedList.Location = new System.Drawing.Point(3, 48);
            this.FailedList.Name = "FailedList";
            this.FailedList.RowHeadersVisible = false;
            this.FailedList.Size = new System.Drawing.Size(677, 399);
            this.FailedList.TabIndex = 1;
            this.FailedList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FailedList_CellContentClick);
            // 
            // Exception
            // 
            this.Exception.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exception.HeaderText = "Exception";
            this.Exception.Name = "Exception";
            this.Exception.ReadOnly = true;
            // 
            // SaveAs
            // 
            this.SaveAs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaveAs.HeaderText = "Save As";
            this.SaveAs.Name = "SaveAs";
            // 
            // SaveName
            // 
            this.SaveName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaveName.HeaderText = "Save Name";
            this.SaveName.Name = "SaveName";
            this.SaveName.ReadOnly = true;
            // 
            // Created
            // 
            this.Created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Created.HeaderText = "Created";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            // 
            // Modified
            // 
            this.Modified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modified.HeaderText = "Modified";
            this.Modified.Name = "Modified";
            this.Modified.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // ExportLocation
            // 
            this.ExportLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExportLocation.HeaderText = "Export Location";
            this.ExportLocation.Name = "ExportLocation";
            this.ExportLocation.ReadOnly = true;
            // 
            // RenameExisting
            // 
            this.RenameExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenameExisting.Location = new System.Drawing.Point(3, 3);
            this.RenameExisting.Name = "RenameExisting";
            this.RenameExisting.Size = new System.Drawing.Size(677, 39);
            this.RenameExisting.TabIndex = 0;
            this.RenameExisting.Text = "Attempt to fix file already exists errors";
            this.RenameExisting.UseVisualStyleBackColor = true;
            this.RenameExisting.Click += new System.EventHandler(this.RenameExisting_Click);
            // 
            // ExportFailedExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExportFailedExceptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Failed Files";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView FailedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exception;
        private System.Windows.Forms.DataGridViewButtonColumn SaveAs;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportLocation;
        private System.Windows.Forms.Button RenameExisting;
    }
}