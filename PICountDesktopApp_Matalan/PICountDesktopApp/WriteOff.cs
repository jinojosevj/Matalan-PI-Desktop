#region NameSpace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PICountDesktopApp.BAL;
using System.IO;
using System.Globalization;
using Microsoft.Office.Core;
using Excel1 = Microsoft.Office.Interop.Excel;
#endregion NameSpace
namespace PICountDesktopApp
{
    public partial class WriteOff : Form
    {
        public int importCount = 0;
        #region Events


        #region WriteOff
        /// <summary>
        /// Write Off
        /// </summary>
        public WriteOff()
        {
            InitializeComponent();
            ofdFileName.Filter = "CSV Files (*.csv)|*.csv";
            //+ "|All files (*.*)|*.*";
            this.ofdFileName.Multiselect = true;
            BindDocNo();

        }
        #endregion WriteOff

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

            DataTable dt=new DataTable();
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

                for (int i = 0; i < dgvFiles.Rows.Count;i++ )
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
            DataTable dt = ObjPI.GetWriteOffReport();
            if (dt.Rows.Count > 0)
            {
                dgvWriteOff.DataSource = dt;
                gbStep1.Enabled = false;
                gbStep2.Enabled = false;
                lblMessage.Text = "";
            }
            else
            {
                lblMessage.Text = "No Data Found!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                dgvWriteOff.DataSource = dt;
                gbStep1.Enabled = true;
                gbStep2.Enabled = true;
            }

        }
        #endregion btnReport_Click

        #region btnNew_Click
        /// <summary>
        /// btnNew_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNewWorkSheet();
            gbStep1.Enabled = true;
            gbStep2.Enabled = true;

            dgvFiles.DataSource = null;
            dgvWriteOff.DataSource = null;

        }
        #endregion btnNew_Click

        #region btnExport_Click
        /// <summary>
        /// btnExport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "CSV Files | *.csv";
            //saveFileDialog1.DefaultExt = "csv";
            //saveFileDialog1.FileName = "WO_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            //saveFileDialog1.ShowDialog();

            //PICountBL ObjPI = new PICountBL();
            //ObjPI.DocNo = txtDocumentNo.Text.Trim();
            //ObjPI.Type = "WO";

            //string path = saveFileDialog1.FileName;
            //StreamWriter sw = new StreamWriter(@path, false);
            //DataTable dt = ObjPI.GetVarianceReportHeaderById();
            //// ExportToCsv(dt, sw);


            //dt = ObjPI.ExportPIVarianceReport();
            //// ExportToCsv(dt, sw);
            //sw.Close();
            //lblExportFile.Text = saveFileDialog1.FileName;

            //lblMessage.Text = "Successfully Exported";
            //lblMessage.ForeColor = System.Drawing.Color.Green;

            GenerateWriteOffReport();
        }
        #endregion btnExport_Click


        #region btnExportAdj_Click
        /// <summary>
        /// btnExportAdj_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportAdj_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "WO_" + txtDocumentNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "All";

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
        #endregion btnExportAdj_Click

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
            objPi.Type = "WO";

            Result = objPi.InsertVarianceReportHeader();

            return Result;
        }
        #endregion InsertVarianceReportHeader

        
        #region CreateNewWorkSheet
        /// <summary>
        /// Create New WorkSheet
        /// </summary>
        private void CreateNewWorkSheet()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "WO";
            DataTable dt = ObjPI.GetDocumentNo();
            if (dt.Rows.Count > 0)
            {
                txtDocumentNo.Text = dt.Rows[0]["DocNo"].ToString();
            }
        }
        #endregion CreateNewWorkSheet

        #region BindDocNo
        /// <summary>
        /// BindDocNo
        /// </summary>
        private void BindDocNo()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "WO";
            DataTable dt = ObjPI.GetVarianceReportHeader();
            if (dt.Rows.Count > 0)
            {
                cmbDocNo.DataSource = dt;
                cmbDocNo.DisplayMember = "DocNo";

                cmbDocNo.Text = dt.Rows[0]["DocNo"].ToString();
            }
        }
        #endregion BindDocNo

      

        #region Generate Write Off Report
        /// <summary>
        /// Generate Write Off Report
        /// </summary>
        private void GenerateWriteOffReport()
        {
            //try
            //{

            saveFileDialog1.Filter = "Xlsx Files | *.xlsx";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.ShowDialog();
            lblExportFile.Text = saveFileDialog1.FileName;

            Excel1.Application myExcelApp;
            Excel1.Workbooks myExcelWorkbooks;
            Excel1.Workbook myExcelWorkbook;
            object misValue = System.Reflection.Missing.Value;

            myExcelApp = new Excel1.Application();

            myExcelApp.Visible = false;

            myExcelWorkbooks = myExcelApp.Workbooks;
            string fileName = System.AppDomain.CurrentDomain.BaseDirectory + "//Templates//WOReport.xlsx";
            string country = Common.Location;


            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            Excel1.Worksheet xlSheet = (Excel1.Worksheet)myExcelWorkbook.Sheets[1];

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "WO";

            DataTable dtPI = ObjPI.GetVarianceReportHeaderById();

            WriteToExcelWOHeader(dtPI, xlSheet);

            dtPI = ObjPI.ExportPIVarianceReport();

            if (dtPI.Rows.Count > 0)
            {
                WriteToExcelWODetail(dtPI, xlSheet);
                MessageBox.Show("Successfully Exported");
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "No Data Found";
            }

            Random rnd = new Random();
            string filePath = lblExportFile.Text.Trim();

            //myExcelWorkbook.Password = "123";
            myExcelWorkbook.SaveAs(@filePath);

            myExcelWorkbook.Close();
            myExcelWorkbooks.Close();

            ////}

            ////catch (Exception e)
            ////{

            //}
        }
        #endregion Generate Write Off Report

        #region WriteToExcelWOHeader
        /// <summary>
        /// WriteToExcelWOHeader
        /// </summary>
        /// <param name="dtStock"></param>
        /// <param name="myExcelWorksheet"></param>
        /// <param name="location"></param>
        private void WriteToExcelWOHeader(DataTable dtSalary, Excel1.Worksheet myExcelWorksheet)
        {
            object misValue = System.Reflection.Missing.Value;

            // myExcelWorksheet.get_Range("A2", misValue).Formula = cmbLocation.Text + "  Salary Report -: " + dtpMonthYear.Text;

            for (int i = 0; i < dtSalary.Rows.Count; i++)
            {
                myExcelWorksheet.get_Range("A" + (i + 2), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["DocNo"]) ? dtSalary.Rows[i]["DocNo"] : "-";
                BorderAround(myExcelWorksheet.get_Range("A" + (i + 2), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("B" + (i + 2), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["PdtName"]) ? dtSalary.Rows[i]["PdtName"].ToString() : "-";
                BorderAround(myExcelWorksheet.get_Range("B" + (i + 2), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("C" + (i + 2), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["ScanningDoneBy"]) ? dtSalary.Rows[i]["ScanningDoneBy"].ToString() : "-";
                BorderAround(myExcelWorksheet.get_Range("C" + (i + 2), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("D" + (i + 2), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["Description"]) ? dtSalary.Rows[i]["Description"].ToString() : "-";
                BorderAround(myExcelWorksheet.get_Range("D" + (i + 2), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("E" + (i + 2), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["CreatedDate"]) ? dtSalary.Rows[i]["CreatedDate"] : "-";
                BorderAround(myExcelWorksheet.get_Range("E" + (i + 2), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("F" + (i + 2), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["CreatedBy"]) ? dtSalary.Rows[i]["CreatedBy"] : "-";
                BorderAround(myExcelWorksheet.get_Range("F" + (i + 2), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));



            }
        }

        #endregion WriteToExcelWOHeader

        #region WriteToExcelWODetail
        /// <summary>
        /// Write To Excel WO Detail
        /// </summary>
        /// <param name="dtStock"></param>
        /// <param name="myExcelWorksheet"></param>
        /// <param name="location"></param>
        private void WriteToExcelWODetail(DataTable dtSalary, Excel1.Worksheet myExcelWorksheet)
        {
            object misValue = System.Reflection.Missing.Value;

            // myExcelWorksheet.get_Range("A2", misValue).Formula = cmbLocation.Text + "  Salary Report -: " + dtpMonthYear.Text;

            for (int i = 0; i < dtSalary.Rows.Count; i++)
            {
                myExcelWorksheet.get_Range("A" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["Id"]) ? dtSalary.Rows[i]["Id"] : "-";
                BorderAround(myExcelWorksheet.get_Range("A" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("B" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["Location"]) ? dtSalary.Rows[i]["Location"].ToString() : "-";
                BorderAround(myExcelWorksheet.get_Range("B" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("C" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["Barcode"]) ? dtSalary.Rows[i]["Barcode"].ToString() : "-";
                BorderAround(myExcelWorksheet.get_Range("C" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("D" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["ItemNo"]) ? dtSalary.Rows[i]["ItemNo"].ToString() : "-";
                BorderAround(myExcelWorksheet.get_Range("D" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("E" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["CategoryCode"]) ? dtSalary.Rows[i]["CategoryCode"] : "-";
                BorderAround(myExcelWorksheet.get_Range("E" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("F" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["Description"]) ? dtSalary.Rows[i]["Description"] : "-";
                BorderAround(myExcelWorksheet.get_Range("F" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("G" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["SystemQty"]) ? dtSalary.Rows[i]["SystemQty"] : "-";
                BorderAround(myExcelWorksheet.get_Range("G" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("H" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["CountQty"]) ? dtSalary.Rows[i]["CountQty"] : "-";
                BorderAround(myExcelWorksheet.get_Range("H" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

                myExcelWorksheet.get_Range("I" + (i + 5), misValue).Formula = (DBNull.Value != dtSalary.Rows[i]["Variance"]) ? dtSalary.Rows[i]["Variance"] : "-";
                BorderAround(myExcelWorksheet.get_Range("I" + (i + 5), misValue), System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));

            }
        }

        #endregion WriteToExcelWODetail


        #region BorderAround
        /// <summary>
        /// Border Around
        /// </summary>
        /// <param name="range"></param>
        /// <param name="colour"></param>
        private void BorderAround(Excel1.Range range, int colour)
        {
            Excel1.Borders borders = range.Borders;
            borders[Excel1.XlBordersIndex.xlEdgeLeft].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders[Excel1.XlBordersIndex.xlEdgeTop].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders[Excel1.XlBordersIndex.xlEdgeBottom].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders[Excel1.XlBordersIndex.xlEdgeRight].LineStyle = Excel1.XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[Excel1.XlBordersIndex.xlInsideVertical].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders[Excel1.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders[Excel1.XlBordersIndex.xlDiagonalUp].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders[Excel1.XlBordersIndex.xlDiagonalDown].LineStyle = Excel1.XlLineStyle.xlLineStyleNone;
            borders = null;
        }

        #endregion BorderArounds

       


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

        private void cmbDocNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbStep1.Enabled = false;
            gbStep2.Enabled = false;

            PICountBL ObjPI = new PICountBL();
            txtDocumentNo.Text = cmbDocNo.Text;

            ObjPI.DocNo = txtDocumentNo.Text.Trim();
            ObjPI.Type = "WO";

            DataTable dtPI = ObjPI.ExportPIVarianceReport();

            dgvWriteOff.DataSource = dtPI;
        }
        #endregion Methods



    }
}
