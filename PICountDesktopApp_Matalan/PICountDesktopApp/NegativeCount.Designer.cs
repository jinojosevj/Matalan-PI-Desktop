namespace PICountDesktopApp
{
    partial class NegativeCount
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
            this.btnExportAdj = new System.Windows.Forms.Button();
            this.lblExportFile = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDocNo = new System.Windows.Forms.ComboBox();
            this.gbStep3 = new System.Windows.Forms.GroupBox();
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
            this.dgvNegative = new System.Windows.Forms.DataGridView();
            this.ofdFileName = new System.Windows.Forms.OpenFileDialog();
            this.gbStep2 = new System.Windows.Forms.GroupBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbStep1 = new System.Windows.Forms.GroupBox();
            this.lblBarcodeFile = new System.Windows.Forms.Label();
            this.btnExportNegative = new System.Windows.Forms.Button();
            this.gbStep3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegative)).BeginInit();
            this.gbStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.gbStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportAdj
            // 
            this.btnExportAdj.Location = new System.Drawing.Point(824, 448);
            this.btnExportAdj.Name = "btnExportAdj";
            this.btnExportAdj.Size = new System.Drawing.Size(135, 30);
            this.btnExportAdj.TabIndex = 40;
            this.btnExportAdj.Text = "Export Adj";
            this.btnExportAdj.UseVisualStyleBackColor = true;
            this.btnExportAdj.Click += new System.EventHandler(this.btnExportAdj_Click);
            // 
            // lblExportFile
            // 
            this.lblExportFile.AutoSize = true;
            this.lblExportFile.Location = new System.Drawing.Point(60, 448);
            this.lblExportFile.Name = "lblExportFile";
            this.lblExportFile.Size = new System.Drawing.Size(12, 17);
            this.lblExportFile.TabIndex = 39;
            this.lblExportFile.Text = ".";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1002, 448);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 30);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(374, 54);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(147, 23);
            this.btnNew.TabIndex = 37;
            this.btnNew.Text = "Create New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Document No :";
            // 
            // cmbDocNo
            // 
            this.cmbDocNo.FormattingEnabled = true;
            this.cmbDocNo.Location = new System.Drawing.Point(211, 53);
            this.cmbDocNo.Name = "cmbDocNo";
            this.cmbDocNo.Size = new System.Drawing.Size(121, 24);
            this.cmbDocNo.TabIndex = 35;
            this.cmbDocNo.SelectedIndexChanged += new System.EventHandler(this.cmbDocNo_SelectedIndexChanged);
            // 
            // gbStep3
            // 
            this.gbStep3.Controls.Add(this.label20);
            this.gbStep3.Controls.Add(this.label19);
            this.gbStep3.Controls.Add(this.label18);
            this.gbStep3.Controls.Add(this.txtScanningDoneBy);
            this.gbStep3.Controls.Add(this.btnReport);
            this.gbStep3.Controls.Add(this.txtDescription);
            this.gbStep3.Controls.Add(this.txtPDTName);
            this.gbStep3.Controls.Add(this.label5);
            this.gbStep3.Controls.Add(this.label3);
            this.gbStep3.Controls.Add(this.label4);
            this.gbStep3.Enabled = false;
            this.gbStep3.Location = new System.Drawing.Point(42, 339);
            this.gbStep3.Name = "gbStep3";
            this.gbStep3.Size = new System.Drawing.Size(1131, 93);
            this.gbStep3.TabIndex = 34;
            this.gbStep3.TabStop = false;
            this.gbStep3.Text = "Step 3 : Enter Details";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(679, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 17);
            this.label20.TabIndex = 44;
            this.label20.Text = "* Don\'t Put \",\"";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(427, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 17);
            this.label19.TabIndex = 43;
            this.label19.Text = "* Don\'t Put \",\"";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(122, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "* Don\'t Put \",\"";
            // 
            // txtScanningDoneBy
            // 
            this.txtScanningDoneBy.Location = new System.Drawing.Point(425, 32);
            this.txtScanningDoneBy.Name = "txtScanningDoneBy";
            this.txtScanningDoneBy.Size = new System.Drawing.Size(140, 22);
            this.txtScanningDoneBy.TabIndex = 16;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1018, 28);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 30);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(674, 23);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(327, 44);
            this.txtDescription.TabIndex = 18;
            // 
            // txtPDTName
            // 
            this.txtPDTName.Location = new System.Drawing.Point(121, 32);
            this.txtPDTName.Name = "txtPDTName";
            this.txtPDTName.Size = new System.Drawing.Size(140, 22);
            this.txtPDTName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "PDT Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Scanning Done By :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(133, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(12, 17);
            this.lblMessage.TabIndex = 33;
            this.lblMessage.Text = ".";
            // 
            // dgvNegative
            // 
            this.dgvNegative.AllowUserToAddRows = false;
            this.dgvNegative.AllowUserToDeleteRows = false;
            this.dgvNegative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNegative.Location = new System.Drawing.Point(42, 492);
            this.dgvNegative.Name = "dgvNegative";
            this.dgvNegative.ReadOnly = true;
            this.dgvNegative.RowTemplate.Height = 24;
            this.dgvNegative.Size = new System.Drawing.Size(1131, 218);
            this.dgvNegative.TabIndex = 32;
            // 
            // ofdFileName
            // 
            this.ofdFileName.FileName = "openFileDialog1";
            // 
            // gbStep2
            // 
            this.gbStep2.Controls.Add(this.dgvFiles);
            this.gbStep2.Controls.Add(this.lblCount);
            this.gbStep2.Controls.Add(this.label1);
            this.gbStep2.Controls.Add(this.txtDocumentNo);
            this.gbStep2.Controls.Add(this.label2);
            this.gbStep2.Controls.Add(this.btnBrowse);
            this.gbStep2.Controls.Add(this.btnImport);
            this.gbStep2.Enabled = false;
            this.gbStep2.Location = new System.Drawing.Point(42, 155);
            this.gbStep2.Name = "gbStep2";
            this.gbStep2.Size = new System.Drawing.Size(1131, 173);
            this.gbStep2.TabIndex = 31;
            this.gbStep2.TabStop = false;
            this.gbStep2.Text = "Step 2 : Import Data File";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Delete});
            this.dgvFiles.Location = new System.Drawing.Point(338, 39);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(452, 115);
            this.dgvFiles.TabIndex = 14;
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
            this.lblCount.Location = new System.Drawing.Point(233, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(12, 17);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document No :";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(122, 40);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.ReadOnly = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(100, 22);
            this.txtDocumentNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select File :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(821, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 27);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(1000, 45);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 26);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // gbStep1
            // 
            this.gbStep1.Controls.Add(this.lblBarcodeFile);
            this.gbStep1.Controls.Add(this.btnExportNegative);
            this.gbStep1.Controls.Add(this.cmbDocNo);
            this.gbStep1.Controls.Add(this.label6);
            this.gbStep1.Controls.Add(this.btnNew);
            this.gbStep1.Location = new System.Drawing.Point(42, 48);
            this.gbStep1.Name = "gbStep1";
            this.gbStep1.Size = new System.Drawing.Size(1131, 101);
            this.gbStep1.TabIndex = 41;
            this.gbStep1.TabStop = false;
            this.gbStep1.Text = "Step 1:Export Negative Barcodes ";
            // 
            // lblBarcodeFile
            // 
            this.lblBarcodeFile.AutoSize = true;
            this.lblBarcodeFile.Location = new System.Drawing.Point(74, 23);
            this.lblBarcodeFile.Name = "lblBarcodeFile";
            this.lblBarcodeFile.Size = new System.Drawing.Size(12, 17);
            this.lblBarcodeFile.TabIndex = 1;
            this.lblBarcodeFile.Text = ".";
            // 
            // btnExportNegative
            // 
            this.btnExportNegative.Location = new System.Drawing.Point(568, 51);
            this.btnExportNegative.Name = "btnExportNegative";
            this.btnExportNegative.Size = new System.Drawing.Size(172, 28);
            this.btnExportNegative.TabIndex = 0;
            this.btnExportNegative.Text = "Export -Ve";
            this.btnExportNegative.UseVisualStyleBackColor = true;
            this.btnExportNegative.Click += new System.EventHandler(this.btnExportNegative_Click);
            // 
            // NegativeCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 777);
            this.Controls.Add(this.gbStep1);
            this.Controls.Add(this.btnExportAdj);
            this.Controls.Add(this.lblExportFile);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbStep3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvNegative);
            this.Controls.Add(this.gbStep2);
            this.Name = "NegativeCount";
            this.Text = "Negative Count";
            this.gbStep3.ResumeLayout(false);
            this.gbStep3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegative)).EndInit();
            this.gbStep2.ResumeLayout(false);
            this.gbStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.gbStep1.ResumeLayout(false);
            this.gbStep1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportAdj;
        private System.Windows.Forms.Label lblExportFile;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDocNo;
        private System.Windows.Forms.GroupBox gbStep3;
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
        private System.Windows.Forms.DataGridView dgvNegative;
        private System.Windows.Forms.OpenFileDialog ofdFileName;
        private System.Windows.Forms.GroupBox gbStep2;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbStep1;
        private System.Windows.Forms.Button btnExportNegative;
        private System.Windows.Forms.Label lblBarcodeFile;
    }
}