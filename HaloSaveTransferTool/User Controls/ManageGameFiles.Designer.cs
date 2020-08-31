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
            this.mainTableLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.LocationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.FileList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileList)).BeginInit();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPannel
            // 
            this.mainTableLayoutPannel.ColumnCount = 1;
            this.mainTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPannel.Controls.Add(this.LocationLinkLabel, 0, 0);
            this.mainTableLayoutPannel.Controls.Add(this.FileList, 0, 1);
            this.mainTableLayoutPannel.Controls.Add(this.buttonsTableLayoutPanel, 0, 2);
            this.mainTableLayoutPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPannel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPannel.Name = "mainTableLayoutPannel";
            this.mainTableLayoutPannel.RowCount = 3;
            this.mainTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPannel.Size = new System.Drawing.Size(500, 500);
            this.mainTableLayoutPannel.TabIndex = 1;
            // 
            // LocationLinkLabel
            // 
            this.LocationLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationLinkLabel.AutoSize = true;
            this.LocationLinkLabel.Location = new System.Drawing.Point(3, 11);
            this.LocationLinkLabel.Name = "LocationLinkLabel";
            this.LocationLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.LocationLinkLabel.TabIndex = 9;
            this.LocationLinkLabel.TabStop = true;
            this.LocationLinkLabel.Text = "Game Name";
            this.LocationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LocationLinkLabel_LinkClicked);
            // 
            // FileList
            // 
            this.FileList.AllowUserToAddRows = false;
            this.FileList.AllowUserToDeleteRows = false;
            this.FileList.AllowUserToResizeRows = false;
            this.FileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.Description,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn23});
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.Location = new System.Drawing.Point(3, 38);
            this.FileList.Name = "FileList";
            this.FileList.ReadOnly = true;
            this.FileList.RowHeadersVisible = false;
            this.FileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileList.Size = new System.Drawing.Size(494, 409);
            this.FileList.TabIndex = 6;
            this.FileList.SelectionChanged += new System.EventHandler(this.FileList_SelectionChanged);
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
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
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
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.buttonsTableLayoutPanel.Controls.Add(this.DeleteButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.MoveButton, 1, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 453);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(494, 44);
            this.buttonsTableLayoutPanel.TabIndex = 8;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(167, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(158, 38);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveButton.Location = new System.Drawing.Point(331, 3);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(160, 38);
            this.MoveButton.TabIndex = 1;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.Move_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(158, 38);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // ManageGameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainTableLayoutPannel);
            this.Name = "ManageGameFiles";
            this.Size = new System.Drawing.Size(500, 500);
            this.mainTableLayoutPannel.ResumeLayout(false);
            this.mainTableLayoutPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileList)).EndInit();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPannel;
        private System.Windows.Forms.DataGridView FileList;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.LinkLabel LocationLinkLabel;
    }
}
