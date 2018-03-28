namespace PICountDesktopApp
{
    partial class PurchaseOrder
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
            this.btnExportVariance = new System.Windows.Forms.Button();
            this.lblExportFile = new System.Windows.Forms.Label();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.gbStep2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtScanningDoneBy = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPDTName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dgvPOData = new System.Windows.Forms.DataGridView();
            this.ofdFileName = new System.Windows.Forms.OpenFileDialog();
            this.gbStep1 = new System.Windows.Forms.GroupBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPOFiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowsePO = new System.Windows.Forms.Button();
            this.btnImportPO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.btnPrintPO = new System.Windows.Forms.Button();
            this.gbStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOData)).BeginInit();
            this.gbStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportVariance
            // 
            this.btnExportVariance.Location = new System.Drawing.Point(682, 414);
            this.btnExportVariance.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportVariance.Name = "btnExportVariance";
            this.btnExportVariance.Size = new System.Drawing.Size(101, 24);
            this.btnExportVariance.TabIndex = 40;
            this.btnExportVariance.Text = "Export Variance";
            this.btnExportVariance.UseVisualStyleBackColor = true;
            this.btnExportVariance.Click += new System.EventHandler(this.btnExportVariance_Click);
            // 
            // lblExportFile
            // 
            this.lblExportFile.AutoSize = true;
            this.lblExportFile.Location = new System.Drawing.Point(68, 419);
            this.lblExportFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExportFile.Name = "lblExportFile";
            this.lblExportFile.Size = new System.Drawing.Size(10, 13);
            this.lblExportFile.TabIndex = 39;
            this.lblExportFile.Text = ".";
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(803, 414);
            this.btnExportAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(100, 24);
            this.btnExportAll.TabIndex = 38;
            this.btnExportAll.Text = "Export";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // gbStep2
            // 
            this.gbStep2.Controls.Add(this.label20);
            this.gbStep2.Controls.Add(this.label19);
            this.gbStep2.Controls.Add(this.label18);
            this.gbStep2.Controls.Add(this.txtScanningDoneBy);
            this.gbStep2.Controls.Add(this.btnReport);
            this.gbStep2.Controls.Add(this.txtDescription);
            this.gbStep2.Controls.Add(this.txtPDTName);
            this.gbStep2.Controls.Add(this.label5);
            this.gbStep2.Controls.Add(this.label3);
            this.gbStep2.Controls.Add(this.label4);
            this.gbStep2.Location = new System.Drawing.Point(55, 333);
            this.gbStep2.Margin = new System.Windows.Forms.Padding(2);
            this.gbStep2.Name = "gbStep2";
            this.gbStep2.Padding = new System.Windows.Forms.Padding(2);
            this.gbStep2.Size = new System.Drawing.Size(848, 76);
            this.gbStep2.TabIndex = 34;
            this.gbStep2.TabStop = false;
            this.gbStep2.Text = "Step 3 : Enter Details";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(509, 57);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "* Don\'t Put \",\"";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(320, 47);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "* Don\'t Put \",\"";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(92, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "* Don\'t Put \",\"";
            // 
            // txtScanningDoneBy
            // 
            this.txtScanningDoneBy.Location = new System.Drawing.Point(319, 26);
            this.txtScanningDoneBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtScanningDoneBy.Name = "txtScanningDoneBy";
            this.txtScanningDoneBy.Size = new System.Drawing.Size(106, 20);
            this.txtScanningDoneBy.TabIndex = 16;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(764, 23);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(56, 24);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(506, 19);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 36);
            this.txtDescription.TabIndex = 18;
            // 
            // txtPDTName
            // 
            this.txtPDTName.Location = new System.Drawing.Point(91, 26);
            this.txtPDTName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPDTName.Name = "txtPDTName";
            this.txtPDTName.Size = new System.Drawing.Size(106, 20);
            this.txtPDTName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "PDT Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Scanning Done By :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(110, 42);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 13);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = ".";
            // 
            // dgvPOData
            // 
            this.dgvPOData.AllowUserToAddRows = false;
            this.dgvPOData.AllowUserToDeleteRows = false;
            this.dgvPOData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOData.Location = new System.Drawing.Point(55, 446);
            this.dgvPOData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPOData.Name = "dgvPOData";
            this.dgvPOData.ReadOnly = true;
            this.dgvPOData.RowTemplate.Height = 24;
            this.dgvPOData.Size = new System.Drawing.Size(848, 136);
            this.dgvPOData.TabIndex = 32;
            // 
            // ofdFileName
            // 
            this.ofdFileName.FileName = "openFileDialog1";
            // 
            // gbStep1
            // 
            this.gbStep1.Controls.Add(this.dgvFiles);
            this.gbStep1.Controls.Add(this.lblCount);
            this.gbStep1.Controls.Add(this.label2);
            this.gbStep1.Controls.Add(this.btnBrowseData);
            this.gbStep1.Controls.Add(this.btnImportData);
            this.gbStep1.Location = new System.Drawing.Point(55, 174);
            this.gbStep1.Margin = new System.Windows.Forms.Padding(2);
            this.gbStep1.Name = "gbStep1";
            this.gbStep1.Padding = new System.Windows.Forms.Padding(2);
            this.gbStep1.Size = new System.Drawing.Size(848, 141);
            this.gbStep1.TabIndex = 31;
            this.gbStep1.TabStop = false;
            this.gbStep1.Text = "Step 2 : Import Data File";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Delete});
            this.dgvFiles.Location = new System.Drawing.Point(254, 32);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(339, 93);
            this.dgvFiles.TabIndex = 14;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(202, -129);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(10, 13);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select File :";
            // 
            // btnBrowseData
            // 
            this.btnBrowseData.Location = new System.Drawing.Point(608, 32);
            this.btnBrowseData.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseData.Name = "btnBrowseData";
            this.btnBrowseData.Size = new System.Drawing.Size(62, 22);
            this.btnBrowseData.TabIndex = 10;
            this.btnBrowseData.Text = "Browse";
            this.btnBrowseData.UseVisualStyleBackColor = true;
            this.btnBrowseData.Click += new System.EventHandler(this.btnBrowseData_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(707, 32);
            this.btnImportData.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(70, 21);
            this.btnImportData.TabIndex = 12;
            this.btnImportData.Text = "Import";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPOFiles);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnBrowsePO);
            this.groupBox1.Controls.Add(this.btnImportPO);
            this.groupBox1.Location = new System.Drawing.Point(55, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(848, 111);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 : Import PO File";
            // 
            // dgvPOFiles
            // 
            this.dgvPOFiles.AllowUserToAddRows = false;
            this.dgvPOFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewLinkColumn1});
            this.dgvPOFiles.Location = new System.Drawing.Point(252, 28);
            this.dgvPOFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPOFiles.Name = "dgvPOFiles";
            this.dgvPOFiles.ReadOnly = true;
            this.dgvPOFiles.RowTemplate.Height = 24;
            this.dgvPOFiles.Size = new System.Drawing.Size(339, 75);
            this.dgvPOFiles.TabIndex = 14;
            this.dgvPOFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPOFiles_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn1.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "Delete";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Text = "Delete";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Select File :";
            // 
            // btnBrowsePO
            // 
            this.btnBrowsePO.Location = new System.Drawing.Point(608, 32);
            this.btnBrowsePO.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowsePO.Name = "btnBrowsePO";
            this.btnBrowsePO.Size = new System.Drawing.Size(62, 22);
            this.btnBrowsePO.TabIndex = 10;
            this.btnBrowsePO.Text = "Browse";
            this.btnBrowsePO.UseVisualStyleBackColor = true;
            this.btnBrowsePO.Click += new System.EventHandler(this.btnBrowsePO_Click);
            // 
            // btnImportPO
            // 
            this.btnImportPO.Location = new System.Drawing.Point(707, 32);
            this.btnImportPO.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportPO.Name = "btnImportPO";
            this.btnImportPO.Size = new System.Drawing.Size(70, 21);
            this.btnImportPO.TabIndex = 12;
            this.btnImportPO.Text = "Import";
            this.btnImportPO.UseVisualStyleBackColor = true;
            this.btnImportPO.Click += new System.EventHandler(this.btnImportPO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Document No :";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(137, 20);
            this.txtDocumentNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.ReadOnly = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(108, 20);
            this.txtDocumentNo.TabIndex = 43;
            // 
            // btnPrintPO
            // 
            this.btnPrintPO.Location = new System.Drawing.Point(559, 414);
            this.btnPrintPO.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintPO.Name = "btnPrintPO";
            this.btnPrintPO.Size = new System.Drawing.Size(100, 24);
            this.btnPrintPO.TabIndex = 44;
            this.btnPrintPO.Text = "Print PO";
            this.btnPrintPO.UseVisualStyleBackColor = true;
            this.btnPrintPO.Click += new System.EventHandler(this.btnPrintPO_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 607);
            this.Controls.Add(this.btnPrintPO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportVariance);
            this.Controls.Add(this.lblExportFile);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.gbStep2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvPOData);
            this.Controls.Add(this.gbStep1);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.gbStep2.ResumeLayout(false);
            this.gbStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOData)).EndInit();
            this.gbStep1.ResumeLayout(false);
            this.gbStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportVariance;
        private System.Windows.Forms.Label lblExportFile;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.GroupBox gbStep2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtScanningDoneBy;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPDTName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dgvPOData;
        private System.Windows.Forms.OpenFileDialog ofdFileName;
        private System.Windows.Forms.GroupBox gbStep1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseData;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPOFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBrowsePO;
        private System.Windows.Forms.Button btnImportPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Button btnPrintPO;
    }
}