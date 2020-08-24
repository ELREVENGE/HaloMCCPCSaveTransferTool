namespace HaloMCCPCSaveTransferTool
{
    partial class ExportToWindow
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
            this.Other = new System.Windows.Forms.Button();
            this.Private = new System.Windows.Forms.Button();
            this.BuiltIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Other, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Private, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BuiltIn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Other
            // 
            this.Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Other.Location = new System.Drawing.Point(3, 107);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(143, 47);
            this.Other.TabIndex = 5;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.SetOther);
            // 
            // Private
            // 
            this.Private.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Private.Location = new System.Drawing.Point(3, 55);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(143, 46);
            this.Private.TabIndex = 2;
            this.Private.Text = "Private";
            this.Private.UseVisualStyleBackColor = true;
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // BuiltIn
            // 
            this.BuiltIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuiltIn.Location = new System.Drawing.Point(3, 3);
            this.BuiltIn.Name = "BuiltIn";
            this.BuiltIn.Size = new System.Drawing.Size(143, 46);
            this.BuiltIn.TabIndex = 0;
            this.BuiltIn.Text = "Built In";
            this.BuiltIn.UseVisualStyleBackColor = true;
            this.BuiltIn.Click += new System.EventHandler(this.BuiltIn_Click);
            // 
            // ExportToWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 157);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportToWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export To";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Other;
        private System.Windows.Forms.Button Private;
        private System.Windows.Forms.Button BuiltIn;
    }
}