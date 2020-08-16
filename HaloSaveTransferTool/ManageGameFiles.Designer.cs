namespace HaloMCCPCSaveTransferTool
{
    partial class ManageGameFiles
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
            this.builtInMapsTable = new System.Windows.Forms.TableLayoutPanel();
            this.fileList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Delete = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.builtInMapsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // builtInMapsTable
            // 
            this.builtInMapsTable.ColumnCount = 1;
            this.builtInMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.builtInMapsTable.Controls.Add(this.fileList, 0, 1);
            this.builtInMapsTable.Controls.Add(this.locationLinkLabel, 0, 0);
            this.builtInMapsTable.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.builtInMapsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.builtInMapsTable.Location = new System.Drawing.Point(0, 0);
            this.builtInMapsTable.Name = "builtInMapsTable";
            this.builtInMapsTable.RowCount = 3;
            this.builtInMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.builtInMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.builtInMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.builtInMapsTable.Size = new System.Drawing.Size(500, 500);
            this.builtInMapsTable.TabIndex = 1;
            // 
            // fileList
            // 
            this.fileList.AllowUserToAddRows = false;
            this.fileList.AllowUserToDeleteRows = false;
            this.fileList.AllowUserToResizeRows = false;
            this.fileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn23});
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Location = new System.Drawing.Point(3, 33);
            this.fileList.Name = "fileList";
            this.fileList.RowHeadersVisible = false;
            this.fileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileList.Size = new System.Drawing.Size(494, 414);
            this.fileList.TabIndex = 6;
            this.fileList.SelectionChanged += new System.EventHandler(this.fileList_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn21.Frozen = true;
            this.dataGridViewTextBoxColumn21.HeaderText = "In Game Name";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 150;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "File Name";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Modified";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // locationLinkLabel
            // 
            this.locationLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.locationLinkLabel.AutoSize = true;
            this.locationLinkLabel.Location = new System.Drawing.Point(3, 8);
            this.locationLinkLabel.Name = "locationLinkLabel";
            this.locationLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.locationLinkLabel.TabIndex = 0;
            this.locationLinkLabel.TabStop = true;
            this.locationLinkLabel.Text = "Game Name";
            this.locationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.locationLinkLabel_LinkClicked);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.Delete, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Move, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Add, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 453);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(494, 44);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete.Location = new System.Drawing.Point(167, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(158, 38);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Move
            // 
            this.Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Move.Location = new System.Drawing.Point(331, 3);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(160, 38);
            this.Move.TabIndex = 1;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(3, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 38);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ManageGameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.builtInMapsTable);
            this.Name = "ManageGameFiles";
            this.Size = new System.Drawing.Size(500, 500);
            this.builtInMapsTable.ResumeLayout(false);
            this.builtInMapsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel builtInMapsTable;
        private System.Windows.Forms.DataGridView fileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.LinkLabel locationLinkLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button Add;
    }
}
