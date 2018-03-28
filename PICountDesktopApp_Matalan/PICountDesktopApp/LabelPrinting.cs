#region NameSpace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PICountDesktopApp.BAL;
using System.IO;
#endregion NameSpace

namespace PICountDesktopApp
{
    public partial class LabelPrinting : Form
    {
        public int importCount = 0;
        #region Events

        #region Offer
        /// <summary>
        /// Offer
        /// </summary>
        public LabelPrinting()
        {
            InitializeComponent();

            CreateNewWorkSheet();

            ofdFileName.Filter = "CSV Files (*.csv)|*.csv";
            //+ "|All files (*.*)|*.*";
            this.ofdFileName.Multiselect = true;
        }
        #endregion Offer

        

        #region btnImportOffer_Click
        /// <summary>
        /// btnImportOffer_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportOffer_Click(object sender, EventArgs e)
        {

            if (Common.Privilege != "Super" && importCount >= Common.Files)
            {
                MessageBox.Show("You Can Not Import More Files");
            }
            else
            {

                for (int i = 0; i < dgvFiles.Rows.Count; i++)
                {
                    string file = dgvFiles.Rows[i].Cells[1].Value.ToString();

                    if (file.ToString().Length > 0)
                    {
                        ImportLabelData(file);
                        lblMessage.Text = importCount.ToString() + " Files Imported";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }

            }

        }

        #endregion btnImportOffer_Click


        #region btnBrowseLabel_Click
        /// <summary>
        /// btnBrowseLabel_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdFileName.ShowDialog();
            //ofdFileName.Filter = "CSV Files (*.csv)|*.csv" + "All files (*.csv)|*.CSV";
            //this.ofdFileName.Multiselect = true;

            //dataGridView1.DataSource = 

            DataTable dt = new DataTable();
            dt.Columns.Add("FileName");

            int i = 0;
            foreach (String file in ofdFileName.FileNames)
            {
                dt.Rows.Add();
                dt.Rows[i]["FileName"] = file;
                i++;
            }
            //string str=  ofdFileName.FileName[0].ToString();

            if (result == DialogResult.OK) // Test result.
            {
                //txtFileName.Text = ofdFileName.FileName;
                dgvFiles.DataSource = dt;
            }

        }
        #endregion btnBrowseLabel_Click


        #region btnPost_Click
        /// <summary>
        /// btnPost_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPost_Click(object sender, EventArgs e)
        {
            PICountBL objPI = new PICountBL();
            objPI.DocNo = txtDocumentNo.Text;
            bool Result = objPI.UpdateItemBarcodePrint();

            if(Result)
            {
                lblMessage.Text = "Successfully Posted To Nav";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion btnPost_Click


        #region dgvFiles_CellClick
        /// <summary>
        /// dgvFiles_CellClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFiles.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dgvFiles.CurrentCell != null && dgvFiles.CurrentCell.Value != null)
                {
                    this.dgvFiles.Rows.Remove(this.dgvFiles.CurrentRow);
                    MessageBox.Show("This File Has Been Deleted!");
                }
            }
        }
        #endregion dgvFiles_CellClick

        #endregion Events

        #region Methods


        #region ImportLabelData
        /// <summary>
        /// ImportLabelData
        /// </summary>
        private void ImportLabelData(string file)
        {
            try
            {
                DataTable dtImport = CsvReader.ReadCSVFile(file, true);
                PICountBL objPI = new PICountBL();

                // for delete old data
                //objPI.DeleteTempBarcode();

              
                dtImport.Columns.Add("FileName");
                dtImport.Columns.Add("DocNo");

                for (int i = 0; i < dtImport.Rows.Count; i++)
                {
                    dtImport.Rows[i]["Quantity"] = Common.Base64Decode(dtImport.Rows[i]["Quantity"].ToString());
                    dtImport.Rows[i]["Barcode"] = Common.Base64Decode(dtImport.Rows[i]["Barcode"].ToString());
                    dtImport.Rows[i]["FileName"] = file;
                    dtImport.Rows[i]["DocNo"] = txtDocumentNo.Text;
                }

                bool Result = false;
                objPI.DtSource = dtImport;
                Result = objPI.ImportLabelData();

                if (Result)
                {
                    //lblMessage.ForeColor = System.Drawing.Color.Green;
                    //lblMessage.Text = "Successfully Imported";

                    importCount++;
                    lblMessage.Text = "";
                    //MessageBox.Show("File :" + importCount.ToString() + " Successfully Imported");
                }
                else
                {
                    //lblMessage.ForeColor = System.Drawing.Color.Red;
                    //lblMessage.Text = "Faild To Import Data";
                    MessageBox.Show("Faild To Import Data");
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().Length > 0)
                {
                    lblMessage.Text = "Your selected file is wrong";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        #endregion ImportLabelData


        #region CreateNewWorkSheet
        /// <summary>
        /// Create New WorkSheet
        /// </summary>
        private void CreateNewWorkSheet()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "LP";
            DataTable dt = ObjPI.GetDocumentNo();
            if (dt.Rows.Count > 0)
            {
                txtDocumentNo.Text = dt.Rows[0]["DocNo"].ToString();
            }
        }




        #endregion CreateNewWorkSheet

        #endregion Methods

       
    }
}
