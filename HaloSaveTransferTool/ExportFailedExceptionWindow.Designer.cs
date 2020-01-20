namespace HaloMCCPCSaveTransferTool
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
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.RenameExisting = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FixInvalidCharacter = new System.Windows.Forms.Button();
            this.FailedList = new System.Windows.Forms.DataGridView();
            this.Exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveAs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).BeginInit();
            this.SuspendLayout();
            // 
            // helpLinkLabel
            // 
            this.helpLinkLabel.AutoSize = true;
            this.helpLinkLabel.Location = new System.Drawing.Point(130, 9);
            this.helpLinkLabel.Name = "helpLinkLabel";
            this.helpLinkLabel.Size = new System.Drawing.Size(29, 13);
            this.helpLinkLabel.TabIndex = 1;
            this.helpLinkLabel.TabStop = true;
            this.helpLinkLabel.Text = "Help";
            this.helpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attempt to resolve errors";
            // 
            // RenameExisting
            // 
            this.RenameExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenameExisting.Location = new System.Drawing.Point(3, 3);
            this.RenameExisting.Name = "RenameExisting";
            this.RenameExisting.Size = new System.Drawing.Size(323, 25);
            this.RenameExisting.TabIndex = 3;
            this.RenameExisting.Text = "FixFiles that already exist ";
            this.RenameExisting.UseVisualStyleBackColor = true;
            this.RenameExisting.Click += new System.EventHandler(this.RenameExisting_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.RenameExisting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FixInvalidCharacter, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 31);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FixInvalidCharacter
            // 
            this.FixInvalidCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FixInvalidCharacter.Location = new System.Drawing.Point(332, 3);
            this.FixInvalidCharacter.Name = "FixInvalidCharacter";
            this.FixInvalidCharacter.Size = new System.Drawing.Size(324, 25);
            this.FixInvalidCharacter.TabIndex = 4;
            this.FixInvalidCharacter.Text = "Replace invalid characters with _";
            this.FixInvalidCharacter.UseVisualStyleBackColor = true;
            this.FixInvalidCharacter.Click += new System.EventHandler(this.FixInvalidCharacter_Click);
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
            this.FailedList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FailedList.Location = new System.Drawing.Point(0, 62);
            this.FailedList.Name = "FailedList";
            this.FailedList.RowHeadersVisible = false;
            this.FailedList.Size = new System.Drawing.Size(683, 388);
            this.FailedList.TabIndex = 5;
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
            // ExportFailedExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.FailedList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpLinkLabel);
            this.Name = "ExportFailedExceptionWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Failed";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel helpLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RenameExisting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FixInvalidCharacter;
        private System.Windows.Forms.DataGridView FailedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exception;
        private System.Windows.Forms.DataGridViewButtonColumn SaveAs;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportLocation;
    }
}