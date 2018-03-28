namespace PICountDesktopApp
{
    partial class PIAdjustment
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
            this.cmbDocNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExportFile = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvPIData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.ofdFileName = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnPostToNav = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbJournalTempalate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExternalDocNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBatchName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNavDocNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowseData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFileNameData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPIData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDocNo
            // 
            this.cmbDocNo.FormattingEnabled = true;
            this.cmbDocNo.Location = new System.Drawing.Point(100, 30);
            this.cmbDocNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDocNo.Name = "cmbDocNo";
            this.cmbDocNo.Size = new System.Drawing.Size(92, 21);
            this.cmbDocNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document No. :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblExportFile);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBatchName);
            this.groupBox1.Controls.Add(this.cmbDocNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(48, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(524, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // lblExportFile
            // 
            this.lblExportFile.AutoSize = true;
            this.lblExportFile.Location = new System.Drawing.Point(58, 15);
            this.lblExportFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExportFile.Name = "lblExportFile";
            this.lblExportFile.Size = new System.Drawing.Size(10, 13);
            this.lblExportFile.TabIndex = 8;
            this.lblExportFile.Text = ".";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(449, 30);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(63, 21);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(389, 30);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(56, 21);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvPIData
            // 
            this.dgvPIData.AllowUserToAddRows = false;
            this.dgvPIData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPIData.Location = new System.Drawing.Point(48, 318);
            this.dgvPIData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPIData.Name = "dgvPIData";
            this.dgvPIData.ReadOnly = true;
            this.dgvPIData.RowTemplate.Height = 24;
            this.dgvPIData.Size = new System.Drawing.Size(1251, 372);
            this.dgvPIData.TabIndex = 3;
            this.dgvPIData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPIData_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Location = new System.Drawing.Point(48, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(497, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Adjustments (Optional)";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(340, 17);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 19);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(409, 17);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(56, 19);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name :";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(77, 17);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(250, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // ofdFileName
            // 
            this.ofdFileName.FileName = "openFileDialog1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(46, 2);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = ".";
            // 
            // btnPostToNav
            // 
            this.btnPostToNav.Location = new System.Drawing.Point(836, 24);
            this.btnPostToNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPostToNav.Name = "btnPostToNav";
            this.btnPostToNav.Size = new System.Drawing.Size(95, 27);
            this.btnPostToNav.TabIndex = 6;
            this.btnPostToNav.Text = "Post To Nav";
            this.btnPostToNav.UseVisualStyleBackColor = true;
            this.btnPostToNav.Click += new System.EventHandler(this.btnPostToNav_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbJournalTempalate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtExternalDocNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNavDocNo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnPostToNav);
            this.groupBox3.Location = new System.Drawing.Point(48, 218);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(948, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Post To Nav";
            this.groupBox3.Visible = false;
            // 
            // cmbJournalTempalate
            // 
            this.cmbJournalTempalate.FormattingEnabled = true;
            this.cmbJournalTempalate.Items.AddRange(new object[] {
            "PHYS. INV.",
            "ITEM",
            "PHYS. INVE"});
            this.cmbJournalTempalate.Location = new System.Drawing.Point(517, 28);
            this.cmbJournalTempalate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbJournalTempalate.Name = "cmbJournalTempalate";
            this.cmbJournalTempalate.Size = new System.Drawing.Size(92, 21);
            this.cmbJournalTempalate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Journal Template :";
            // 
            // txtExternalDocNo
            // 
            this.txtExternalDocNo.Location = new System.Drawing.Point(728, 29);
            this.txtExternalDocNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExternalDocNo.Name = "txtExternalDocNo";
            this.txtExternalDocNo.Size = new System.Drawing.Size(98, 20);
            this.txtExternalDocNo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "External Doc No. :";
            // 
            // cmbBatchName
            // 
            this.cmbBatchName.FormattingEnabled = true;
            this.cmbBatchName.Location = new System.Drawing.Point(280, 30);
            this.cmbBatchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBatchName.Name = "cmbBatchName";
            this.cmbBatchName.Size = new System.Drawing.Size(83, 21);
            this.cmbBatchName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Batch Name :";
            // 
            // txtNavDocNo
            // 
            this.txtNavDocNo.Location = new System.Drawing.Point(119, 28);
            this.txtNavDocNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNavDocNo.Name = "txtNavDocNo";
            this.txtNavDocNo.Size = new System.Drawing.Size(98, 20);
            this.txtNavDocNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nav Document No. :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowseData);
            this.groupBox4.Controls.Add(this.btnImportData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtFileNameData);
            this.groupBox4.Location = new System.Drawing.Point(48, 92);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(497, 53);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Import Data (Optional)";
            // 
            // btnBrowseData
            // 
            this.btnBrowseData.Location = new System.Drawing.Point(340, 17);
            this.btnBrowseData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowseData.Name = "btnBrowseData";
            this.btnBrowseData.Size = new System.Drawing.Size(56, 19);
            this.btnBrowseData.TabIndex = 5;
            this.btnBrowseData.Text = "Browse";
            this.btnBrowseData.UseVisualStyleBackColor = true;
            this.btnBrowseData.Click += new System.EventHandler(this.btnBrowseData_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(409, 17);
            this.btnImportData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(56, 19);
            this.btnImportData.TabIndex = 5;
            this.btnImportData.Text = "Import";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "File Name :";
            // 
            // txtFileNameData
            // 
            this.txtFileNameData.Location = new System.Drawing.Point(77, 17);
            this.txtFileNameData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFileNameData.Name = "txtFileNameData";
            this.txtFileNameData.ReadOnly = true;
            this.txtFileNameData.Size = new System.Drawing.Size(250, 20);
            this.txtFileNameData.TabIndex = 0;
            // 
            // PIAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPIData);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PIAdjustment";
            this.Text = "PI Adjustment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPIData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvPIData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdFileName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnPostToNav;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNavDocNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBatchName;
        private System.Windows.Forms.TextBox txtExternalDocNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbJournalTempalate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblExportFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseData;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileNameData;
    }
}