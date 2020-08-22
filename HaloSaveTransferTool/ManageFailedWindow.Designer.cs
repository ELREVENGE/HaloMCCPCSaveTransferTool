namespace HaloMCCPCSaveTransferTool
{
    partial class ManageFailedWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AutoResolve = new System.Windows.Forms.Button();
            this.FailedList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResolveAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attempt to resolve errors";
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.Location = new System.Drawing.Point(130, 5);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(29, 13);
            this.HelpLinkLabel.TabIndex = 6;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Help";
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
            // FailedList
            // 
            this.FailedList.AllowUserToAddRows = false;
            this.FailedList.AllowUserToDeleteRows = false;
            this.FailedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FailedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exception,
            this.ResolveAction,
            this.InGameName,
            this.Description,
            this.FileName,
            this.LastModified});
            this.FailedList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FailedList.Location = new System.Drawing.Point(0, 62);
            this.FailedList.Name = "FailedList";
            this.FailedList.RowHeadersVisible = false;
            this.FailedList.Size = new System.Drawing.Size(683, 388);
            this.FailedList.TabIndex = 9;
            this.FailedList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FailedList_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AutoResolve, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 31);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Exception
            // 
            this.Exception.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exception.HeaderText = "Exception";
            this.Exception.Name = "Exception";
            this.Exception.ReadOnly = true;
            // 
            // ResolveAction
            // 
            this.ResolveAction.HeaderText = "Resolve Action";
            this.ResolveAction.Name = "ResolveAction";
            this.ResolveAction.ReadOnly = true;
            this.ResolveAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResolveAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InGameName
            // 
            this.InGameName.HeaderText = "In Game Name";
            this.InGameName.Name = "InGameName";
            this.InGameName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // LastModified
            // 
            this.LastModified.HeaderText = "Last Modified";
            this.LastModified.Name = "LastModified";
            this.LastModified.ReadOnly = true;
            // 
            // ManageFailedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HelpLinkLabel);
            this.Controls.Add(this.FailedList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageFailedWindow";
            this.ShowIcon = false;
            this.Text = "Manage Failed";
            ((System.ComponentModel.ISupportInitialize)(this.FailedList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.Button AutoResolve;
        private System.Windows.Forms.DataGridView FailedList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exception;
        private System.Windows.Forms.DataGridViewButtonColumn ResolveAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn InGameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastModified;
    }
}