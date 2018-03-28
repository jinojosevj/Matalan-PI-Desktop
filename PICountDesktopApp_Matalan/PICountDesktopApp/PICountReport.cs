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
    public partial class PICountReport : Form
    {
        #region Events

        public string filterType = "Category";
        public int importCount = 0;

        #region PICountReport
        /// <summary>
        /// PICountReport
        /// </summary>
        public PICountReport()
        {
            InitializeComponent();

            ofdFileName.Filter = "CSV Files (*.csv)|*.csv";
                //+ "|All files (*.*)|*.*";
            this.ofdFileName.Multiselect = true;

            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "PI";

           
            DataTable dt = ObjPI.GetDocumentNo();

            if (dt.Rows.Count > 0)
            {
                txtDocumentNo.Text = dt.Rows[0]["DocNo"].ToString();
            }
           
            BindDivision();
            //txtCreatedBy.Text = Common.UserId;
        }
        #endregion PICountReport
        
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
            
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.CategoryCode = txtItemCategoryCode.Text.Trim().ToString();
            ObjPI.FilterType = filterType;
            ObjPI.DivisionCode = cmbDivision.Text;

            ObjPI.FamilyCode = txtFamilyCode.Text.Trim().ToString();
            ObjPI.LineCode12 = txtLineCode12.Text.Trim().ToString();
            ObjPI.Barcode = txtBarcode.Text.Trim().ToString();
            ObjPI.Quantity = Convert.ToInt32(txtQuantity.Value);

            ObjPI.ReciptDate = dtpReciptDate.Value;

            DataTable dt = null;
            dt = ObjPI.GetPIVarianceReport();

            if (dt.Rows.Count > 0)
            {
                dgvReport.DataSource = dt;
                gbStep1.Enabled = false;
                gbStep2.Enabled = false;
                gbStep3.Enabled = false;
            }
            else
            {
                lblMessage.Text = "No Data Found !";
                lblMessage.ForeColor = System.Drawing.Color.Red;
               
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
            saveFileDialog1.FileName =  "PI_"+ txtDocumentNo.Text.Trim().ToString()+"_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();
            
            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "All";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);


            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt,sw);
            sw.Close();
            lblExportFile.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        #endregion btnExportAll_Click

        #region btnVariance_Click
        /// <summary>
        /// btnVariance_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVariance_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "PI_Variance_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "Variance";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);

            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt,sw);

            sw.Close();
            lblExportFile.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        #endregion btnVariance_Click
                       
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
                      
        #region btnBrowse_Click
        /// <summary>
        /// btnBrowse_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
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

        #endregion btnBrowse_Click


        #region rdbDivision_CheckedChanged
        /// <summary>
        /// rdbDivision_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDivision.Checked)
            {
                CheckFilter(rdbDivision.Text);

            }
        }
        #endregion rdbDivision_CheckedChanged

        #region rdbCategory_CheckedChanged
        /// <summary>
        /// rdbCategory_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCategory.Checked)
            {
                CheckFilter(rdbCategory.Text);
            }
        }
        #endregion rdbCategory_CheckedChanged

        #region rdbFamily_CheckedChanged
        /// <summary>
        /// rdbFamily_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbFamily_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFamily.Checked)
            {
                CheckFilter(rdbFamily.Text);
            }
        }
        #endregion rdbFamily_CheckedChanged


        #region rdbLineCode12_CheckedChanged
        /// <summary>
        /// rdbLineCode12_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbLineCode12_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLineCode12.Checked)
            {
                CheckFilter(rdbLineCode12.Text);
            }
        }
        #endregion rdbLineCode12_CheckedChanged


        #region rdbBarcode_CheckedChanged
        /// <summary>
        /// rdbBarcode_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rdbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBarcode.Checked)
            {
                CheckFilter(rdbBarcode.Text);
            }
        }
        #endregion rdbBarcode_CheckedChanged


        #region rdbReciptDate_CheckedChanged
        /// <summary>
        /// rdbReciptDate_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbReciptDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReciptDate.Checked)
            {
                CheckFilter(rdbReciptDate.Text);
            }
        }
        #endregion rdbReciptDate_CheckedChanged


        #region rdbQuantity_CheckedChanged
        /// <summary>
        /// rdbQuantity_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQuantity.Checked)
            {
                CheckFilter(rdbQuantity.Text);
            }
        }
        #endregion rdbQuantity_CheckedChanged


        #region chkVariance_CheckedChanged
        /// <summary>
        /// chkVariance_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkVariance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVariance.Checked)
            {
                PICountBL ObjPI = new PICountBL();
                ObjPI.DocNo = txtDocumentNo.Text.Trim().ToString();
                ObjPI.Type = "Variance";
                DataTable dt = ObjPI.ExportPIVarianceReport();
                dgvReport.DataSource = dt;
            }
            else
            {
                PICountBL ObjPI = new PICountBL();
                ObjPI.DocNo = txtDocumentNo.Text.Trim().ToString();
                ObjPI.Type = "All";
                DataTable dt = ObjPI.ExportPIVarianceReport();
                dgvReport.DataSource = dt;
            }
        }
        #endregion chkVariance_CheckedChanged

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
            objPi.Type = "PI";
            Result=objPi.InsertVarianceReportHeader();
            
            return Result;
        }
        #endregion InsertVarianceReportHeader


        #region CheckFilter
        /// <summary>
        /// Check Filter
        /// </summary>
        /// <param name="Filter"></param>
        private void CheckFilter(string Filter)
        {
            filterType = Filter;
            switch (Filter)
            {
                case "Division":  cmbDivision.Enabled = true;
                                  txtItemCategoryCode.ReadOnly = true;
                                  txtFamilyCode.ReadOnly = true;
                                  txtLineCode12.ReadOnly = true;
                                  txtBarcode.ReadOnly = true;
                                  dtpReciptDate.Enabled = false;
                                  txtQuantity.ReadOnly = true;
                                  break;
                case "Category":  txtItemCategoryCode.ReadOnly = false;
                                  cmbDivision.Enabled = false;
                                  txtFamilyCode.ReadOnly = true;
                                  txtLineCode12.ReadOnly = true;
                                  txtBarcode.ReadOnly = true;
                                  dtpReciptDate.Enabled = false;
                                  txtQuantity.ReadOnly = true;
                                  break;
                case "Family":   txtFamilyCode.ReadOnly = false;
                                 txtItemCategoryCode.ReadOnly = true;
                                 cmbDivision.Enabled = false;
                                 txtLineCode12.ReadOnly = true;
                                 txtBarcode.ReadOnly = true;
                                 dtpReciptDate.Enabled = false;
                                 txtQuantity.ReadOnly = true;
                                   break;
                case "Linecode12": txtLineCode12.ReadOnly = false;
                                   txtFamilyCode.ReadOnly = true;
                                   txtItemCategoryCode.ReadOnly = true;
                                   cmbDivision.Enabled = false;
                                   txtBarcode.ReadOnly = true;
                                   dtpReciptDate.Enabled = false;
                                   txtQuantity.ReadOnly = true;

                                   break;
                case "Barcode":    txtBarcode.ReadOnly = false;
                                   txtLineCode12.ReadOnly = true;
                                   txtFamilyCode.ReadOnly = true;
                                   txtItemCategoryCode.ReadOnly = true;
                                   cmbDivision.Enabled = false;
                                   dtpReciptDate.Enabled = false;
                                   txtQuantity.ReadOnly = true;
                                 break;
                case "ReciptDate": dtpReciptDate.Enabled = true;
                                   txtBarcode.ReadOnly = true;
                                   txtLineCode12.ReadOnly = true;
                                   txtFamilyCode.ReadOnly = true;
                                   txtItemCategoryCode.ReadOnly = true;
                                   cmbDivision.Enabled = false;
                                   txtQuantity.ReadOnly = true;
                                   break;
                case "Quantity":   txtQuantity.ReadOnly = false;
                                   dtpReciptDate.Enabled = false;
                                   txtBarcode.ReadOnly = true;
                                   txtLineCode12.ReadOnly = true;
                                   txtFamilyCode.ReadOnly = true;
                                   txtItemCategoryCode.ReadOnly = true;
                                   cmbDivision.Enabled = false;
                                   break;

            }
        }
        #endregion CheckFilter
        
        #region BindDivision
        /// <summary>
        /// Bind Division
        /// </summary>
        private void BindDivision()
        {
            PICountBL ObjPI = new PICountBL();
            DataTable dt = ObjPI.GetDivision();
            cmbDivision.DataSource = dt;
            cmbDivision.DisplayMember = "Code";
        }
        #endregion BindDivision


       

        #endregion Methods


        //private void BindItemCategoryCode()
        //{   
        //    PICountBL ObjPI=new PICountBL();
        //    DataTable dt= ObjPI.GetItemCategoryCode();
        //    //clbItemCategoryCode

        //    foreach (DataRow dataRow in dt.Rows)
        //    {
        //        clbItemCategoryCode.Items.Add(dataRow["Code"]);
        //        // + ":" + dataRow["Description"]
        //        //int id = Convert.ToInt32(dataRow["Id"]);
        //        //string description = dataRow["Code"].ToString();

        //        //clbItemCategoryCode.Items.Insert(id, description);
        //    }
        //}


      




        //private void clbItemCategoryCode_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    //MessageBox.Show( clbItemCategoryCode.CheckedItems.ToString());
            //txtItemCategoryCode.Text = "";
            //string str = txtItemCategoryCode.Text.Trim().ToString();

            //for (int i = 0; i < clbItemCategoryCode.Items.Count; i++)
            //{
            //    if (clbItemCategoryCode.GetItemChecked(i) == true)
            //    {

            //        txtItemCategoryCode.Text = (str.Length > 0) ? str + "," + clbItemCategoryCode.Items[i].ToString() : clbItemCategoryCode.Items[i].ToString();
            //        str = txtItemCategoryCode.Text.Trim().ToString();
            //    }
            //}
        //}
    }
}
