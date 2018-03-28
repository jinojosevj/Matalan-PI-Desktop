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
    public partial class TransferOrder : Form
    {
        public int importCount = 0;
        #region Events

                #region TransferOrder
                /// <summary>
                /// TransferOrder
                /// </summary>
                public TransferOrder()
                {
                    InitializeComponent();
                    CreateNewWorkSheet();

                    ofdFileName.Filter = "CSV Files (*.csv)|*.csv";
                    //+ "|All files (*.*)|*.*";
                    this.ofdFileName.Multiselect = true;

                    rdbReceiver.Checked = false;
                    gbStep2.Visible = false;
                    gbStep3.Visible = false;
                    dgvPOData.Visible = false;
                    btnExportAll.Visible = false;
                }
                #endregion TransferOrder
                
               
                #region rdbSender_CheckedChanged
                /// <summary>
                /// rdbSender_CheckedChanged
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void rdbSender_CheckedChanged(object sender, EventArgs e)
                {
                        if (rdbSender.Checked)
                        {
                            rdbReceiver.Checked = false;
                            gbStep2.Visible = false;
                            gbStep3.Visible = false;
                            dgvPOData.Visible = false;
                            btnExportAll.Visible = false;

                            btnExport.Visible = true;
                            lblReceiver.Visible = true;
                            txtStoreCode.Visible = true;
                            btnExportPDT.Visible = true;

                        }
                        else
                        {
                            rdbSender.Checked = false;

                            rdbReceiver.Checked = true;
                            gbStep2.Visible = true;
                            gbStep3.Visible = true;
                            dgvPOData.Visible = true;
                            btnExportAll.Visible = true;

                            btnExport.Visible = true;
                            lblReceiver.Visible = false;
                            txtStoreCode.Visible = false;
                            btnExportPDT.Visible = false;
            }
                }
                #endregion rdbSender_CheckedChanged

                #region rdbReceiver_CheckedChanged
                /// <summary>
                /// rdbReceiver_CheckedChanged
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void rdbReceiver_CheckedChanged(object sender, EventArgs e)
                {
                    if (rdbReceiver.Checked)
                        {
                            rdbSender.Checked = false;

                            rdbReceiver.Checked = true;
                            gbStep2.Visible = true;
                            gbStep3.Visible = true;
                            dgvPOData.Visible = true;
                            btnExportAll.Visible = true;

                            btnExport.Visible = true;
                            lblReceiver.Visible = false;
                            txtStoreCode.Visible = false;
                            btnExportPDT.Visible = false;
                       }
                    else
                       {
                            rdbReceiver.Checked = false;
                            gbStep2.Visible = false;
                            gbStep3.Visible = false;
                            dgvPOData.Visible = false;
                            btnExportAll.Visible = false;

                            btnExport.Visible = true;

                            lblReceiver.Visible = true;
                            txtStoreCode.Visible = true;
                            btnExportPDT.Visible = true;
                       }
                }
        #endregion rdbReceiver_CheckedChanged

        #region btnExport_Click
        /// <summary>
        /// btnExport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {

            if ((txtStoreCode.Text.Trim().Length > 0 && txtStoreCode.Text.Trim()!=Common.Location) || rdbReceiver.Checked==true)
            {
                saveFileDialog1.Filter = "CSV Files | *.csv";
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.FileName = "TO_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
                saveFileDialog1.ShowDialog();

                PICountBL ObjPI = new PICountBL();
                ObjPI.DocNo = txtDocumentNo.Text.Trim();


                string path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(@path, false);
                DataTable dt = ObjPI.GetTransferFile();
                ExportToCsv(EncodeData(dt), sw);

                sw.Close();
                //lblExportFile.Text = saveFileDialog1.FileName;

                lblMessage.Text = "Successfully Exported";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Put Proper Receiver Store Code";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }

        #endregion btnExport_Click

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
                dgvTransferFiles.DataSource = dt;
            }
        }

        #endregion btnBrowsePO_Click


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

        #region dgvTransferFiles_CellClick
        /// <summary>
        /// dgvTransferFiles_CellClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTransferFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTransferFiles.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dgvTransferFiles.CurrentCell != null && dgvTransferFiles.CurrentCell.Value != null)
                {
                    this.dgvTransferFiles.Rows.Remove(this.dgvTransferFiles.CurrentRow);
                    MessageBox.Show("This File Has Been Deleted!");
                }
            }
        }

        #endregion dgvTransferFiles_CellClick

        #region btnImportData_Click
        /// <summary>
        /// btnImportData_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportData_Click(object sender, EventArgs e)
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
        #endregion btnImportData_Click

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

                for (int i = 0; i < dgvTransferFiles.Rows.Count; i++)
                {
                    string file = dgvTransferFiles.Rows[i].Cells[1].Value.ToString();

                    if (file.ToString().Length > 0)
                    {
                        ImportTransferData(file);
                        lblCount.Text = importCount.ToString() + " Files Imported";
                        lblCount.ForeColor = System.Drawing.Color.Green;
                    }
                }


            }
        }
        #endregion btnImportPO_Click

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
                gbStep3.Enabled = false;
                lblMessage.Text = "";
            }
            else
            {
                lblMessage.Text = "No Data Found Where variance equal to zero!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dgvPOData.DataSource = dt;
                gbStep1.Enabled = true;
                gbStep2.Enabled = true;
                gbStep3.Enabled = true;
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
            saveFileDialog1.FileName = "TO_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "TO";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);


            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt, sw);
            sw.Close();
            //lblExportFile.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        #endregion btnExportAll_Click


        #region btnExportForChecking_Click
        /// <summary>
        /// btnExportForChecking_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportForChecking_Click(object sender, EventArgs e)
        {
            if ((txtStoreCode.Text.Trim().Length > 0 && txtStoreCode.Text.Trim() != Common.Location) || rdbReceiver.Checked == true)
            {
                saveFileDialog1.Filter = "CSV Files | *.csv";
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.FileName = "TO_Check" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
                saveFileDialog1.ShowDialog();

                PICountBL ObjPI = new PICountBL();
                ObjPI.DocNo = txtDocumentNo.Text.Trim();


                string path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(@path, false);
                DataTable dt = ObjPI.GetTranferFileForChecking();
                ExportToCsv(dt, sw);

                sw.Close();
                //lblExportFile.Text = saveFileDialog1.FileName;

                lblMessage.Text = "Successfully Exported";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Put Receiver Store Code";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion btnExportForChecking_Click


        #region btnExportPDT_Click
        /// <summary>
        /// btnExportPDT_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportPDT_Click(object sender, EventArgs e)
        {
            if (txtStoreCode.Text.Trim().Length > 0 && txtStoreCode.Text.Trim() != Common.Location)
            {
                saveFileDialog1.Filter = "CSV Files | *.csv";
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.FileName = "TO_Data";
                saveFileDialog1.ShowDialog();

                PICountBL ObjPI = new PICountBL();
                ObjPI.DocNo = txtDocumentNo.Text.Trim();


                string path = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(@path, false);
                DataTable dt = ObjPI.GetTransferFile();

                dt.Columns.Remove("Quantity");
                ExportToCsv(dt, sw);

                sw.Close();
                //lblExportFile.Text = saveFileDialog1.FileName;

                lblMessage.Text = "Successfully Exported";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Put Proper Receiver Store Code";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }


            //string file = dgvFiles.Rows[0].Cells[1].Value.ToString();

            //DataTable dtImport = CsvReader.ReadCSVFile(file, true);

            //saveFileDialog1.Filter = "CSV Files | *.csv";
            //saveFileDialog1.DefaultExt = "csv";
            //saveFileDialog1.FileName = "TO_Data";
            //saveFileDialog1.ShowDialog();

            //PICountBL ObjPI = new PICountBL();
            //ObjPI.DocNo = txtDocumentNo.Text.Trim();


            //string path = saveFileDialog1.FileName;
            //StreamWriter sw = new StreamWriter(@path, false);


            ////dt.Columns.Remove("Quantity");
            //ExportToCsv(EncodeTest(dtImport), sw);

            //sw.Close();
            ////lblExportFile.Text = saveFileDialog1.FileName;

            //lblMessage.Text = "Successfully Exported";
            //lblMessage.ForeColor = System.Drawing.Color.Green;

        }
        #endregion btnExportPDT_Click

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
                    
                    //lblMessage.Text = "Successfully Imported";


                    importCount++;
                    lblMessage.Text = "File :" + importCount.ToString() + " Successfully Imported";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
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
        #endregion Import Barcode Data


        #region ImportTransferData
        /// <summary>
        /// Import PO Data
        /// </summary>
        private void ImportTransferData(string file)
        {
            try
            {
                DataTable dtImport = CsvReader.ReadCSVFile(file, true);
                PICountBL objPI = new PICountBL();

                // for delete old data
                //objPI.DeleteTempBarcode();

                bool flag = false;

                dtImport = DecodeData(dtImport);

                dtImport.Columns.Add("DocNo");
                dtImport.Columns.Add("FileName");

                for (int i = 0; i < dtImport.Rows.Count; i++)
                {
                    if (dtImport.Rows[i]["R"].ToString() == Common.Location)
                    {
                        dtImport.Rows[i]["DocNo"] = txtDocumentNo.Text.Trim().ToString();
                        dtImport.Rows[i]["FileName"] = file;
                    }
                    else
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    bool Result = false;
                    objPI.DtSource = dtImport;
                    Result = objPI.ImportTransferData();

                    if (Result)
                    {
                        //lblMessage.ForeColor = System.Drawing.Color.Green;
                        //lblMessage.Text = "Successfully Imported";
                        importCount++;
                        lblMessage.Text = "File :" + importCount.ToString() + " Successfully Imported";
                        lblMessage.ForeColor = Color.Green;
                        //MessageBox.Show("File :" + importCount.ToString() + " Successfully Imported");
                    }
                    else
                    {
                        //lblMessage.ForeColor = System.Drawing.Color.Red;
                        //lblMessage.Text = "Faild To Import Data";
                        MessageBox.Show("Faild To Import Data");
                    }
                }
                else
                {
                    lblMessage.Text = "This File Is Not In Right Format ";
                    lblMessage.ForeColor = Color.Red;
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


        #endregion ImportTransferData

        #region CreateNewWorkSheet
        /// <summary>
        /// Create New WorkSheet
        /// </summary>
        private void CreateNewWorkSheet()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "TO";
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
        //private bool InsertVarianceReportHeader()
        //{
        //    bool Result = false;

        //    PICountBL objPi = new PICountBL();
        //    objPi.DocNo = txtDocumentNo.Text.Trim();
        //    objPi.PdtName = txtPDTName.Text.Trim();
        //    objPi.ScanningDoneBy = txtScanningDoneBy.Text.Trim();
        //    objPi.Description = txtDescription.Text.Trim();

        //    objPi.CreatedBy = Common.UserId;
        //    objPi.Type = "PO";

        //    Result = objPi.InsertVarianceReportHeader();

        //    return Result;
        //}



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


        #region EncodeData
        /// <summary>
        /// Export To Csv
        /// </summary>
        /// <param name="dt"></param>
        private DataTable EncodeData(DataTable dt)
        {
            DataTable EnData = new DataTable();
            EnData.Columns.Add("Quantity");
            EnData.Columns.Add("Barcode");
            EnData.Columns.Add("R");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EnData.Rows.Add();
                EnData.Rows[i]["Quantity"] = Common.Base64Encode(dt.Rows[i]["Quantity"].ToString());
                EnData.Rows[i]["Barcode"] = Common.Base64Encode(dt.Rows[i]["Barcode"].ToString());
                EnData.Rows[i]["R"] = Common.Base64Encode(txtStoreCode.Text.Trim());
            }

            return EnData;

        }

        #endregion EncodeData


        #region EncodeTest
        /// <summary>
        /// Export To Csv
        /// </summary>
        /// <param name="dt"></param>
        private DataTable EncodeTest(DataTable dt)
        {
            DataTable EnData = new DataTable();
            EnData.Columns.Add("Location");
            EnData.Columns.Add("Barcode");
           // EnData.Columns.Add("R");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EnData.Rows.Add();
                EnData.Rows[i]["Location"] = Common.Base64Encode(dt.Rows[i]["Location"].ToString());
                EnData.Rows[i]["Barcode"] = Common.Base64Encode(dt.Rows[i]["Barcode"].ToString());
                //EnData.Rows[i]["R"] = Common.Base64Encode(txtStoreCode.Text.Trim());
            }

            return EnData;

        }

        #endregion EncodeTest


        #region DecodeData
        /// <summary>
        /// DecodeData
        /// </summary>
        /// <param name="dt"></param>
        private DataTable DecodeData(DataTable dt)
        {
            DataTable DeData = new DataTable();
            DeData.Columns.Add("Quantity");
            DeData.Columns.Add("Barcode");
            DeData.Columns.Add("R");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DeData.Rows.Add();
                DeData.Rows[i]["Quantity"] = Common.Base64Decode(dt.Rows[i]["Quantity"].ToString());
                DeData.Rows[i]["Barcode"] = Common.Base64Decode(dt.Rows[i]["Barcode"].ToString());
                DeData.Rows[i]["R"] = Common.Base64Decode(dt.Rows[i]["R"].ToString());
            }

            return DeData;
        }

        #endregion Export To Csv

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
            objPi.Type = "TO";

            Result = objPi.InsertVarianceReportHeader();

            return Result;
        }
        #endregion InsertVarianceReportHeader

        #endregion Methods

        
    }
}
