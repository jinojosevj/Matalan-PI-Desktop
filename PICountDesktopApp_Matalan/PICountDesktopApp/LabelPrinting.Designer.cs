namespace PICountDesktopApp
{
    partial class LabelPrinting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowseLabel = new System.Windows.Forms.Button();
            this.btnImportOffer = new System.Windows.Forms.Button();
            this.ofdFileName = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPost);
            this.groupBox1.Controls.Add(this.dgvFiles);
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnBrowseLabel);
            this.groupBox1.Controls.Add(this.btnImportOffer);
            this.groupBox1.Location = new System.Drawing.Point(11, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(848, 115);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 : Import Offer File";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewLinkColumn1});
            this.dgvFiles.Location = new System.Drawing.Point(252, 28);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(339, 75);
            this.dgvFiles.TabIndex = 14;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
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
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(175, 13);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(10, 13);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = ".";
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
            // btnBrowseLabel
            // 
            this.btnBrowseLabel.Location = new System.Drawing.Point(608, 32);
            this.btnBrowseLabel.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseLabel.Name = "btnBrowseLabel";
            this.btnBrowseLabel.Size = new System.Drawing.Size(62, 22);
            this.btnBrowseLabel.TabIndex = 10;
            this.btnBrowseLabel.Text = "Browse";
            this.btnBrowseLabel.UseVisualStyleBackColor = true;
            this.btnBrowseLabel.Click += new System.EventHandler(this.btnBrowseLabel_Click);
            // 
            // btnImportOffer
            // 
            this.btnImportOffer.Location = new System.Drawing.Point(685, 32);
            this.btnImportOffer.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportOffer.Name = "btnImportOffer";
            this.btnImportOffer.Size = new System.Drawing.Size(70, 21);
            this.btnImportOffer.TabIndex = 12;
            this.btnImportOffer.Text = "Import";
            this.btnImportOffer.UseVisualStyleBackColor = true;
            this.btnImportOffer.Click += new System.EventHandler(this.btnImportOffer_Click);
            // 
            // ofdFileName
            // 
            this.ofdFileName.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Document No :";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(98, 18);
            this.txtDocumentNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.ReadOnly = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(108, 20);
            this.txtDocumentNo.TabIndex = 45;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(685, 82);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(129, 21);
            this.btnPost.TabIndex = 15;
            this.btnPost.Text = "Post To Nav";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // LabelPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.groupBox1);
            this.Name = "LabelPrinting";
            this.Text = "Label Printing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBrowseLabel;
        private System.Windows.Forms.Button btnImportOffer;
        private System.Windows.Forms.OpenFileDialog ofdFileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Button btnPost;
    }
}