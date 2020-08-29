namespace HaloMCCPCSaveTransferTool
{
    partial class ManagePanel
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
            this.LocationTabControl = new System.Windows.Forms.TabControl();
            this.BuiltIn = new System.Windows.Forms.TabPage();
            this.BuiltInTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Private = new System.Windows.Forms.TabPage();
            this.PrivateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LocationTabControl.SuspendLayout();
            this.BuiltIn.SuspendLayout();
            this.Private.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationTabControl
            // 
            this.LocationTabControl.Controls.Add(this.BuiltIn);
            this.LocationTabControl.Controls.Add(this.Private);
            this.LocationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocationTabControl.Location = new System.Drawing.Point(0, 0);
            this.LocationTabControl.Name = "LocationTabControl";
            this.LocationTabControl.SelectedIndex = 0;
            this.LocationTabControl.Size = new System.Drawing.Size(995, 407);
            this.LocationTabControl.TabIndex = 1;
            // 
            // BuiltIn
            // 
            this.BuiltIn.Controls.Add(this.BuiltInTableLayoutPanel);
            this.BuiltIn.Location = new System.Drawing.Point(4, 22);
            this.BuiltIn.Name = "BuiltIn";
            this.BuiltIn.Padding = new System.Windows.Forms.Padding(3);
            this.BuiltIn.Size = new System.Drawing.Size(987, 381);
            this.BuiltIn.TabIndex = 0;
            this.BuiltIn.Text = "Built In";
            this.BuiltIn.UseVisualStyleBackColor = true;
            // 
            // BuiltInTableLayoutPanel
            // 
            this.BuiltInTableLayoutPanel.ColumnCount = 3;
            this.BuiltInTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BuiltInTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BuiltInTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BuiltInTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BuiltInTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BuiltInTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuiltInTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.BuiltInTableLayoutPanel.Name = "BuiltInTableLayoutPanel";
            this.BuiltInTableLayoutPanel.RowCount = 1;
            this.BuiltInTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BuiltInTableLayoutPanel.Size = new System.Drawing.Size(981, 375);
            this.BuiltInTableLayoutPanel.TabIndex = 0;
            // 
            // Private
            // 
            this.Private.Controls.Add(this.PrivateTableLayoutPanel);
            this.Private.Location = new System.Drawing.Point(4, 22);
            this.Private.Name = "Private";
            this.Private.Padding = new System.Windows.Forms.Padding(3);
            this.Private.Size = new System.Drawing.Size(987, 381);
            this.Private.TabIndex = 1;
            this.Private.Text = "Private";
            this.Private.UseVisualStyleBackColor = true;
            // 
            // PrivateTableLayoutPanel
            // 
            this.PrivateTableLayoutPanel.ColumnCount = 3;
            this.PrivateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PrivateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PrivateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PrivateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrivateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrivateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrivateTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PrivateTableLayoutPanel.Name = "PrivateTableLayoutPanel";
            this.PrivateTableLayoutPanel.RowCount = 1;
            this.PrivateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PrivateTableLayoutPanel.Size = new System.Drawing.Size(981, 375);
            this.PrivateTableLayoutPanel.TabIndex = 1;
            // 
            // ManagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocationTabControl);
            this.Name = "ManagePanel";
            this.Size = new System.Drawing.Size(995, 407);
            this.LocationTabControl.ResumeLayout(false);
            this.BuiltIn.ResumeLayout(false);
            this.Private.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LocationTabControl;
        private System.Windows.Forms.TabPage BuiltIn;
        private System.Windows.Forms.TableLayoutPanel BuiltInTableLayoutPanel;
        private System.Windows.Forms.TabPage Private;
        private System.Windows.Forms.TableLayoutPanel PrivateTableLayoutPanel;
    }
}
