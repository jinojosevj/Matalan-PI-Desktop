namespace PICountDesktopApp
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorksheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIAdjustmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTablesToolStripMenuItem,
            this.newWorksheetToolStripMenuItem,
            this.writeOffToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.pIAdjustmentsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.labelPrintToolStripMenuItem,
            this.transferOrderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateTablesToolStripMenuItem
            // 
            this.updateTablesToolStripMenuItem.Name = "updateTablesToolStripMenuItem";
            this.updateTablesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateTablesToolStripMenuItem.Text = "Update Item Master";
            this.updateTablesToolStripMenuItem.Click += new System.EventHandler(this.updateTablesToolStripMenuItem_Click);
            // 
            // newWorksheetToolStripMenuItem
            // 
            this.newWorksheetToolStripMenuItem.Name = "newWorksheetToolStripMenuItem";
            this.newWorksheetToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newWorksheetToolStripMenuItem.Text = "New PI Worksheet";
            this.newWorksheetToolStripMenuItem.Click += new System.EventHandler(this.newWorksheetToolStripMenuItem_Click);
            // 
            // writeOffToolStripMenuItem
            // 
            this.writeOffToolStripMenuItem.Name = "writeOffToolStripMenuItem";
            this.writeOffToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.writeOffToolStripMenuItem.Text = "Write Off";
            this.writeOffToolStripMenuItem.Click += new System.EventHandler(this.writeOffToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // pIAdjustmentsToolStripMenuItem
            // 
            this.pIAdjustmentsToolStripMenuItem.Name = "pIAdjustmentsToolStripMenuItem";
            this.pIAdjustmentsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pIAdjustmentsToolStripMenuItem.Text = "PI Adjustments";
            this.pIAdjustmentsToolStripMenuItem.Click += new System.EventHandler(this.pIAdjustmentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // labelPrintToolStripMenuItem
            // 
            this.labelPrintToolStripMenuItem.Name = "labelPrintToolStripMenuItem";
            this.labelPrintToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.labelPrintToolStripMenuItem.Text = "Label Print";
            this.labelPrintToolStripMenuItem.Click += new System.EventHandler(this.labelPrintToolStripMenuItem_Click);
            // 
            // transferOrderToolStripMenuItem
            // 
            this.transferOrderToolStripMenuItem.Name = "transferOrderToolStripMenuItem";
            this.transferOrderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.transferOrderToolStripMenuItem.Text = "Transfer Order";
            this.transferOrderToolStripMenuItem.Click += new System.EventHandler(this.transferOrderToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 539);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.Text = "PI Count Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorksheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIAdjustmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelPrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferOrderToolStripMenuItem;
    }
}