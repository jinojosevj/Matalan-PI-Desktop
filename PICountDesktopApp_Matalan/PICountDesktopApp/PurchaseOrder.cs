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
    public partial class PurchaseOrder : Form
    {
        public int importCount = 0;

        #region Events


        #region PurchaseOrder
        /// <summary>
        /// PurchaseOrder
        /// </summary>
        public PurchaseOrder()
        {
            InitializeComponent();
            CreateNewWorkSheet();

            ofdFileName.Filter = "CSV Files (*.csv)|*.csv";
            //+ "|All files (*.*)|*.*";
            this.ofdFileName.Multiselect = true;
        }
        #endregion PurchaseOrder


        #region dgvPOFiles_CellClick
        /// <summary>
        /// dgvPOFiles_CellClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPOFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPOFiles.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dgvPOFiles.CurrentCell != null && dgvPOFiles.CurrentCell.Value != null)
                {
                    this.dgvPOFiles.Rows.Remove(this.dgvPOFiles.CurrentRow);
                    MessageBox.Show("This File Has Been Deleted!");
                }
            }
        }
        #endregion dgvPOFiles_CellClick


        #region btnImport_Click
        /// <summary>
        /// btnImport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
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
                        ImportBarcodeData(file);

                        lblCount.Text = importCount.ToString() + " Files Imported";
                        lblCount.ForeColor = System.Drawing.Color.Green;
                    }
                }


            }
        }
        #endregion btnImport_Click


        #region btnBrowseData_Click
        /// <summary>
        /// btnBrowseData_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseData_Click(object sender, EventArgs e)
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
        #endregion btnBrowseData_Click


        #region btnBrowsePO_Click
        /// <summary>
        /// btnBrowsePO_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowsePO_Click(object sender, EventArgs e)
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
                dgvPOFiles.DataSource = dt;
            }
        }
        #endregion btnBrowsePO_Click


        #region btnImportPO_Click
        /// <summary>
        /// btnImportPO_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportPO_Click(object sender, EventArgs e)
        {
            if (Common.Privilege != "Super" && importCount >= Common.Files)
            {
                MessageBox.Show("You Can Not Import More Files");
            }
            else
            {

                for (int i = 0; i < dgvPOFiles.Rows.Count; i++)
                {
                    string file = dgvPOFiles.Rows[i].Cells[1].Value.ToString();

                    if (file.ToString().Length > 0)
                    {
                        ImportPOData(file);
                        lblCount.Text = importCount.ToString() + " Files Imported";
                        lblCount.ForeColor = System.Drawing.Color.Green;
                    }
                }


            }
        }

        #endregion btnImportPO_Click

        #region btnNew_Click
        /// <summary>
        /// btnNew_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
           
        }
        #endregion btnNew_Click


        #region btnReport_Click
        /// <summary>
        /// btnReport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            InsertVarianceReportHeader();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.ToString();
            DataTable dt = ObjPI.GetPOReport();
            if (dt.Rows.Count > 0)
            {
                dgvPOData.DataSource = dt;
                gbStep1.Enabled = false;
                gbStep2.Enabled = false;
                groupBox1.Enabled = false;
                lblMessage.Text = "";
            }
            else
            {
                lblMessage.Text = "No Data Found Where variance equal to zero!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dgvPOData.DataSource = dt;
                gbStep1.Enabled = true;
                gbStep2.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
        #endregion btnReport_Click


        #region btnExportAll_Click
        /// <summary>
        /// btnExportAll_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportAll_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "PO_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "PO";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);


            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt, sw);
            sw.Close();
            lblExportFile.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        #endregion btnExportAll_Click


        #region btnExportVariance_Click
        /// <summary>
        /// btnExportVariance_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportVariance_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "PO_Variance_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "Variance";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);

            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt, sw);

            sw.Close();
            lblExportFile.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }

        #endregion btnExportVariance_Click


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

        #region btnPrintPO_Click
        /// <summary>
        /// btnPrintPO_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintPO_Click(object sender, EventArgs e)
        {
            PICountBL objPI = new PICountBL();
            objPI.DocNo = txtDocumentNo.Text;
            bool Result = objPI.InsertItemBarcodePrint();

            if (Result)
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
        #endregion btnPrintPO_Click

        #endregion Events

        #region Methods

        #region Import Barcode Data
        /// <summary>
        ///  Import Barcode Data
        /// </summary>
        private void ImportBarcodeData(string file)
        {
            try
            {
                DataTable dtImport = CsvReader.ReadCSVFile(file, true);
                PICountBL objPI = new PICountBL();

                // for delete old data
                //objPI.DeleteTempBarcode();

                dtImport.Columns.Add("CreatedDate");
                dtImport.Columns.Add("CreatedBy");
                dtImport.Columns.Add("DocNo");
                dtImport.Columns.Add("FileName");

                for (int i = 0; i < dtImport.Rows.Count; i++)
                {
                    dtImport.Rows[i]["Location"] = Common.Base64Decode(dtImport.Rows[i]["Location"].ToString());
                    dtImport.Rows[i]["Barcode"] = Common.Base64Decode(dtImport.Rows[i]["Barcode"].ToString());
                    dtImport.Rows[i]["CreatedDate"] = DateTime.Now;
                    dtImport.Rows[i]["CreatedBy"] = Common.UserId;

                    dtImport.Rows[i]["DocNo"] = txtDocumentNo.Text.Trim().ToString();
                    dtImport.Rows[i]["FileName"] = file;
                }

                bool Result = false;
                objPI.DtSource = dtImport;
                Result = objPI.ImportBarcodeData();

                if (Result)
                {
                    //lblMessage.ForeColor = System.Drawing.Color.Green;
                    //lblMessage.Text = "Successfully Imported";


                    importCount++;
                    lblMessage.Text = "";
                    MessageBox.Show("File :" + importCount.ToString() + " Successfully Imported");
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
        #endregion Import Barcode Data


        #region ImportPOData
        /// <summary>
        /// Import PO Data
        /// </summary>
        private void ImportPOData(string file)
        {
            try
            {
                DataTable dtImport = CsvReader.ReadCSVFile(file, true);
                PICountBL objPI = new PICountBL();

                // for delete old data
                //objPI.DeleteTempBarcode();

                
                dtImport.Columns.Add("DocNo");
                dtImport.Columns.Add("FileName");

                for (int i = 0; i < dtImport.Rows.Count; i++)
                {

                    dtImport.Rows[i]["DocNo"] = txtDocumentNo.Text.Trim().ToString();
                    dtImport.Rows[i]["FileName"] = file;
                }

                bool Result = false;
                objPI.DtSource = dtImport;
                Result = objPI.ImportPOData();

                if (Result)
                {
                    //lblMessage.ForeColor = System.Drawing.Color.Green;
                    //lblMessage.Text = "Successfully Imported";
                    importCount++;
                    //lblMessage.Text = "File :" + importCount.ToString() + " Successfully Imported";
                    MessageBox.Show("File :" + importCount.ToString() + " Successfully Imported");
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


        #endregion Import PO Data

        #region CreateNewWorkSheet
        /// <summary>
        /// Create New WorkSheet
        /// </summary>
        private void CreateNewWorkSheet()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "PO";
            DataTable dt = ObjPI.GetDocumentNo();
            if (dt.Rows.Count > 0)
            {
                txtDocumentNo.Text = dt.Rows[0]["DocNo"].ToString();
            }
        }

        #endregion CreateNewWorkSheet



        #region InsertVarianceReportHeader
        /// <summary>
        /// Insert Variance Report Header
        /// </summary>
        /// <returns></returns>
        private bool InsertVarianceReportHeader()
        {
            bool Result = false;

            PICountBL objPi = new PICountBL();
            objPi.DocNo = txtDocumentNo.Text.Trim();
            objPi.PdtName = txtPDTName.Text.Trim();
            objPi.ScanningDoneBy = txtScanningDoneBy.Text.Trim();
            objPi.Description = txtDescription.Text.Trim();

            objPi.CreatedBy = Common.UserId;
            objPi.Type = "PO";

            Result = objPi.InsertVarianceReportHeader();

            return Result;
        }



        #endregion InsertVarianceReportHeader


        #region Export To Csv
        /// <summary>
        /// Export To Csv
        /// </summary>
        /// <param name="dt"></param>
        private void ExportToCsv(DataTable dt, StreamWriter sw)
        {

            int iColCount = dt.Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                        sw.Write(dr[i].ToString());
                    if (i < iColCount - 1)
                        sw.Write(",");
                }
                sw.Write(sw.NewLine);
            }

        }




        #endregion Export To Csv

        #endregion Methods

       
    }
}
