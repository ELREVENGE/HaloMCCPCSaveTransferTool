namespace HaloMCCPCSaveTransferTool
{
    partial class ExportFailedWindow
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
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoResolve = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FailedList = new System.Windows.Forms.DataGridView();
            this.Exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveAs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.Location = new System.Drawing.Point(130, 9);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(29, 13);
            this.HelpLinkLabel.TabIndex = 1;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Help";
            this.HelpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLinkLabel_LinkClicked);
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
            // AutoResolve
            // 
            this.AutoResolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoResolve.Location = new System.Drawing.Point(3, 3);
            this.AutoResolve.Name = "AutoResolve";
            this.AutoResolve.Size = new System.Drawing.Size(653, 25);
            this.AutoResolve.TabIndex = 3;
            this.AutoResolve.Text = "Auto resolve ";
            this.AutoResolve.UseVisualStyleBackColor = true;
            this.AutoResolve.Click += new System.EventHandler(this.AutoResolve_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AutoResolve, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 31);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.CreatedColumn,
            this.Modified,
            this.LocationColumn,
            this.ExportLocation});
            this.FailedList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FailedList.Location = new System.Drawing.Point(0, 62);
            this.FailedList.Name = "FailedList";
            this.FailedList.RowHeadersVisible = false;
            this.FailedList.Size = new System.Drawing.Size(683, 388);
            this.FailedList.TabIndex = 5;
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
            // CreatedColumn
            // 
            this.CreatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedColumn.HeaderText = "Created";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            // 
            // Modified
            // 
            this.Modified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modified.HeaderText = "Modified";
            this.Modified.Name = "Modified";
            this.Modified.ReadOnly = true;
            // 
            // LocationColumn
            // 
            this.LocationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // ExportLocation
            // 
            this.ExportLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExportLocation.HeaderText = "Export Location";
            this.ExportLocation.Name = "ExportLocation";
            this.ExportLocation.ReadOnly = true;
            // 
            // ExportFailedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.FailedList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelpLinkLabel);
            this.Name = "ExportFailedWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Failed";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AutoResolve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView FailedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exception;
        private System.Windows.Forms.DataGridViewButtonColumn SaveAs;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modified;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportLocation;
    }
}