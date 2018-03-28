namespace PICountDesktopApp
{
    partial class PICountReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PICountReport));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnExportAll = new System.Windows.Forms.Button();
            this.btnVariance = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdFileName = new System.Windows.Forms.OpenFileDialog();
            this.txtPDTName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScanningDoneBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.gbStep1 = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.gbStep3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chkVariance = new System.Windows.Forms.CheckBox();
            this.lblExportFile = new System.Windows.Forms.Label();
            this.gbStep2 = new System.Windows.Forms.GroupBox();
            this.dtpReciptDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLineCode12 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFamilyCode = new System.Windows.Forms.TextBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbQuantity = new System.Windows.Forms.RadioButton();
            this.rdbFamily = new System.Windows.Forms.RadioButton();
            this.rdbReciptDate = new System.Windows.Forms.RadioButton();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.rdbCategory = new System.Windows.Forms.RadioButton();
            this.rdbLineCode12 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemCategoryCode = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbStep1.SuspendLayout();
            this.gbStep3.SuspendLayout();
            this.gbStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
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
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(82, 491);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1381, 254);
            this.dgvReport.TabIndex = 4;
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(886, 780);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(104, 28);
            this.btnExportAll.TabIndex = 5;
            this.btnExportAll.Text = "Export All";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnVariance
            // 
            this.btnVariance.Location = new System.Drawing.Point(1000, 780);
            this.btnVariance.Name = "btnVariance";
            this.btnVariance.Size = new System.Drawing.Size(138, 28);
            this.btnVariance.TabIndex = 6;
            this.btnVariance.Text = "Export Variance";
            this.btnVariance.UseVisualStyleBackColor = true;
            this.btnVariance.Click += new System.EventHandler(this.btnVariance_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1050, 28);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 30);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(225, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(12, 17);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = ".";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(918, 40);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 26);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(825, 41);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 27);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            // ofdFileName
            // 
            this.ofdFileName.FileName = "openFileDialog1";
            // 
            // txtPDTName
            // 
            this.txtPDTName.Location = new System.Drawing.Point(121, 32);
            this.txtPDTName.Name = "txtPDTName";
            this.txtPDTName.Size = new System.Drawing.Size(140, 22);
            this.txtPDTName.TabIndex = 13;
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
            // txtScanningDoneBy
            // 
            this.txtScanningDoneBy.Location = new System.Drawing.Point(425, 32);
            this.txtScanningDoneBy.Name = "txtScanningDoneBy";
            this.txtScanningDoneBy.Size = new System.Drawing.Size(140, 22);
            this.txtScanningDoneBy.TabIndex = 16;
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(674, 23);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(327, 44);
            this.txtDescription.TabIndex = 18;
            // 
            // gbStep1
            // 
            this.gbStep1.Controls.Add(this.dgvFiles);
            this.gbStep1.Controls.Add(this.lblCount);
            this.gbStep1.Controls.Add(this.label1);
            this.gbStep1.Controls.Add(this.txtDocumentNo);
            this.gbStep1.Controls.Add(this.label2);
            this.gbStep1.Controls.Add(this.btnBrowse);
            this.gbStep1.Controls.Add(this.btnImport);
            this.gbStep1.Location = new System.Drawing.Point(82, 39);
            this.gbStep1.Name = "gbStep1";
            this.gbStep1.Size = new System.Drawing.Size(1131, 126);
            this.gbStep1.TabIndex = 19;
            this.gbStep1.TabStop = false;
            this.gbStep1.Text = "Step 1 : Import Data File";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(233, 13);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(12, 17);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = ".";
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
            this.gbStep3.Location = new System.Drawing.Point(82, 374);
            this.gbStep3.Name = "gbStep3";
            this.gbStep3.Size = new System.Drawing.Size(1180, 93);
            this.gbStep3.TabIndex = 20;
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
            // chkVariance
            // 
            this.chkVariance.AutoSize = true;
            this.chkVariance.Location = new System.Drawing.Point(1295, 464);
            this.chkVariance.Name = "chkVariance";
            this.chkVariance.Size = new System.Drawing.Size(119, 21);
            this.chkVariance.TabIndex = 19;
            this.chkVariance.Text = "Variance Only";
            this.chkVariance.UseVisualStyleBackColor = true;
            this.chkVariance.CheckedChanged += new System.EventHandler(this.chkVariance_CheckedChanged);
            // 
            // lblExportFile
            // 
            this.lblExportFile.AutoSize = true;
            this.lblExportFile.Location = new System.Drawing.Point(169, 761);
            this.lblExportFile.Name = "lblExportFile";
            this.lblExportFile.Size = new System.Drawing.Size(12, 17);
            this.lblExportFile.TabIndex = 21;
            this.lblExportFile.Text = ".";
            // 
            // gbStep2
            // 
            this.gbStep2.Controls.Add(this.dtpReciptDate);
            this.gbStep2.Controls.Add(this.label17);
            this.gbStep2.Controls.Add(this.label16);
            this.gbStep2.Controls.Add(this.label15);
            this.gbStep2.Controls.Add(this.label14);
            this.gbStep2.Controls.Add(this.label13);
            this.gbStep2.Controls.Add(this.txtQuantity);
            this.gbStep2.Controls.Add(this.label12);
            this.gbStep2.Controls.Add(this.label11);
            this.gbStep2.Controls.Add(this.label10);
            this.gbStep2.Controls.Add(this.txtBarcode);
            this.gbStep2.Controls.Add(this.label9);
            this.gbStep2.Controls.Add(this.txtLineCode12);
            this.gbStep2.Controls.Add(this.label8);
            this.gbStep2.Controls.Add(this.txtFamilyCode);
            this.gbStep2.Controls.Add(this.cmbDivision);
            this.gbStep2.Controls.Add(this.label7);
            this.gbStep2.Controls.Add(this.groupBox4);
            this.gbStep2.Controls.Add(this.label6);
            this.gbStep2.Controls.Add(this.txtItemCategoryCode);
            this.gbStep2.Location = new System.Drawing.Point(82, 171);
            this.gbStep2.Name = "gbStep2";
            this.gbStep2.Size = new System.Drawing.Size(1381, 199);
            this.gbStep2.TabIndex = 23;
            this.gbStep2.TabStop = false;
            this.gbStep2.Text = "Step 2 : Select Filters";
            // 
            // dtpReciptDate
            // 
            this.dtpReciptDate.Enabled = false;
            this.dtpReciptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReciptDate.Location = new System.Drawing.Point(1112, 113);
            this.dtpReciptDate.Name = "dtpReciptDate";
            this.dtpReciptDate.Size = new System.Drawing.Size(130, 22);
            this.dtpReciptDate.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1109, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "dd/MM/yyyy";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(863, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 17);
            this.label16.TabIndex = 44;
            this.label16.Text = "1020612000044,1020613000005";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(606, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "B02061200004,B02061300000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(364, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "C020101,C090201";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "C01,C02";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(1266, 113);
            this.txtQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(91, 22);
            this.txtQuantity.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1263, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Quantity :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1109, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Recipt Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(863, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Barcode :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(866, 112);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(228, 49);
            this.txtBarcode.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Linecode 12 :";
            // 
            // txtLineCode12
            // 
            this.txtLineCode12.Location = new System.Drawing.Point(607, 112);
            this.txtLineCode12.Multiline = true;
            this.txtLineCode12.Name = "txtLineCode12";
            this.txtLineCode12.ReadOnly = true;
            this.txtLineCode12.Size = new System.Drawing.Size(237, 49);
            this.txtLineCode12.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Family :";
            // 
            // txtFamilyCode
            // 
            this.txtFamilyCode.Location = new System.Drawing.Point(356, 112);
            this.txtFamilyCode.Multiline = true;
            this.txtFamilyCode.Name = "txtFamilyCode";
            this.txtFamilyCode.ReadOnly = true;
            this.txtFamilyCode.Size = new System.Drawing.Size(228, 49);
            this.txtFamilyCode.TabIndex = 28;
            // 
            // cmbDivision
            // 
            this.cmbDivision.Enabled = false;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(13, 108);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(70, 24);
            this.cmbDivision.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Division :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbQuantity);
            this.groupBox4.Controls.Add(this.rdbFamily);
            this.groupBox4.Controls.Add(this.rdbReciptDate);
            this.groupBox4.Controls.Add(this.rdbDivision);
            this.groupBox4.Controls.Add(this.rdbBarcode);
            this.groupBox4.Controls.Add(this.rdbCategory);
            this.groupBox4.Controls.Add(this.rdbLineCode12);
            this.groupBox4.Location = new System.Drawing.Point(380, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(712, 55);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filters";
            // 
            // rdbQuantity
            // 
            this.rdbQuantity.AutoSize = true;
            this.rdbQuantity.Location = new System.Drawing.Point(580, 21);
            this.rdbQuantity.Name = "rdbQuantity";
            this.rdbQuantity.Size = new System.Drawing.Size(82, 21);
            this.rdbQuantity.TabIndex = 32;
            this.rdbQuantity.Text = "Quantity";
            this.rdbQuantity.UseVisualStyleBackColor = true;
            this.rdbQuantity.CheckedChanged += new System.EventHandler(this.rdbQuantity_CheckedChanged);
            // 
            // rdbFamily
            // 
            this.rdbFamily.AutoSize = true;
            this.rdbFamily.Location = new System.Drawing.Point(198, 21);
            this.rdbFamily.Name = "rdbFamily";
            this.rdbFamily.Size = new System.Drawing.Size(69, 21);
            this.rdbFamily.TabIndex = 28;
            this.rdbFamily.Text = "Family";
            this.rdbFamily.UseVisualStyleBackColor = true;
            this.rdbFamily.CheckedChanged += new System.EventHandler(this.rdbFamily_CheckedChanged);
            // 
            // rdbReciptDate
            // 
            this.rdbReciptDate.AutoSize = true;
            this.rdbReciptDate.Location = new System.Drawing.Point(471, 21);
            this.rdbReciptDate.Name = "rdbReciptDate";
            this.rdbReciptDate.Size = new System.Drawing.Size(99, 21);
            this.rdbReciptDate.TabIndex = 31;
            this.rdbReciptDate.Text = "ReciptDate";
            this.rdbReciptDate.UseVisualStyleBackColor = true;
            this.rdbReciptDate.CheckedChanged += new System.EventHandler(this.rdbReciptDate_CheckedChanged);
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new System.Drawing.Point(22, 21);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(78, 21);
            this.rdbDivision.TabIndex = 26;
            this.rdbDivision.Text = "Division";
            this.rdbDivision.UseVisualStyleBackColor = true;
            this.rdbDivision.CheckedChanged += new System.EventHandler(this.rdbDivision_CheckedChanged);
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Location = new System.Drawing.Point(373, 21);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(82, 21);
            this.rdbBarcode.TabIndex = 30;
            this.rdbBarcode.Text = "Barcode";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            this.rdbBarcode.CheckedChanged += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // rdbCategory
            // 
            this.rdbCategory.AutoSize = true;
            this.rdbCategory.Location = new System.Drawing.Point(106, 21);
            this.rdbCategory.Name = "rdbCategory";
            this.rdbCategory.Size = new System.Drawing.Size(86, 21);
            this.rdbCategory.TabIndex = 27;
            this.rdbCategory.Text = "Category";
            this.rdbCategory.UseVisualStyleBackColor = true;
            this.rdbCategory.CheckedChanged += new System.EventHandler(this.rdbCategory_CheckedChanged);
            // 
            // rdbLineCode12
            // 
            this.rdbLineCode12.AutoSize = true;
            this.rdbLineCode12.Location = new System.Drawing.Point(273, 21);
            this.rdbLineCode12.Name = "rdbLineCode12";
            this.rdbLineCode12.Size = new System.Drawing.Size(103, 21);
            this.rdbLineCode12.TabIndex = 29;
            this.rdbLineCode12.Text = "Linecode12";
            this.rdbLineCode12.UseVisualStyleBackColor = true;
            this.rdbLineCode12.CheckedChanged += new System.EventHandler(this.rdbLineCode12_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Category :";
            // 
            // txtItemCategoryCode
            // 
            this.txtItemCategoryCode.Location = new System.Drawing.Point(105, 112);
            this.txtItemCategoryCode.Multiline = true;
            this.txtItemCategoryCode.Name = "txtItemCategoryCode";
            this.txtItemCategoryCode.ReadOnly = true;
            this.txtItemCategoryCode.Size = new System.Drawing.Size(228, 49);
            this.txtItemCategoryCode.TabIndex = 24;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Delete});
            this.dgvFiles.Location = new System.Drawing.Point(339, 33);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(452, 85);
            this.dgvFiles.TabIndex = 15;
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
            // PICountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 822);
            this.Controls.Add(this.chkVariance);
            this.Controls.Add(this.gbStep2);
            this.Controls.Add(this.lblExportFile);
            this.Controls.Add(this.gbStep3);
            this.Controls.Add(this.gbStep1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnVariance);
            this.Controls.Add(this.btnExportAll);
            this.Controls.Add(this.dgvReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PICountReport";
            this.Text = "PI Count Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbStep1.ResumeLayout(false);
            this.gbStep1.PerformLayout();
            this.gbStep3.ResumeLayout(false);
            this.gbStep3.PerformLayout();
            this.gbStep2.ResumeLayout(false);
            this.gbStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Button btnVariance;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdFileName;
        private System.Windows.Forms.TextBox txtPDTName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScanningDoneBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox gbStep1;
        private System.Windows.Forms.GroupBox gbStep3;
        private System.Windows.Forms.CheckBox chkVariance;
        private System.Windows.Forms.Label lblExportFile;
        private System.Windows.Forms.GroupBox gbStep2;
        private System.Windows.Forms.TextBox txtItemCategoryCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbFamily;
        private System.Windows.Forms.RadioButton rdbReciptDate;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.RadioButton rdbCategory;
        private System.Windows.Forms.RadioButton rdbLineCode12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFamilyCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLineCode12;
        private System.Windows.Forms.RadioButton rdbQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpReciptDate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}