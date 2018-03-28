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
    using System.Configuration;
using System.IO;
#endregion NameSpace

namespace PICountDesktopApp
{
    public partial class PIAdjustment : Form
    {

        #region Events

        #region PIAdjustment
        /// <summary>
        /// PIAdjustment
        /// </summary>
        public PIAdjustment()
        {
            InitializeComponent();
            BindDocNo();
            BindBatchName();
            cmbJournalTempalate.Text = "PHYS. INV.";
        }
        #endregion PIAdjustment

        #region btnReport_Click
        /// <summary>
        /// btnReport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = cmbDocNo.Text.Trim().ToString();
            ObjPI.Type = "Adjustment";
            DataTable dt = ObjPI.ExportPIVarianceReport();
            dgvPIData.DataSource = dt;
        }
        #endregion btnReport_Click

        #region btnBrowse_Click
        /// <summary>
        /// btnBrowse_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdFileName.ShowDialog();
            ofdFileName.Filter = "CSV Files (*.csv)|*.csv";

            if (result == DialogResult.OK) // Test result.
            {
                txtFileName.Text = ofdFileName.FileName;
            }
        }
        #endregion btnBrowse_Click

        #region btnImport_Click
        /// <summary>
        /// btnImport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportAdjustments();
        }

        #endregion btnImport_Click


        #region btnPostToNav_Click
        /// <summary>
        /// btnPostToNav_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostToNav_Click(object sender, EventArgs e)
        {
            PostToNav();
        }
        #endregion btnPostToNav_Click


        #region dgvPIData_MouseClick
        /// <summary>
        /// dgvPIData_MouseClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPIData_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuCopy = new ToolStripMenuItem("Copy");

                mnuCopy.Click += new EventHandler(mnuCopy_Click);

                //Add to main context menu
                mnu.Items.AddRange(new ToolStripItem[] { mnuCopy });
                //Assign to datagridview
                dgvPIData.ContextMenuStrip = mnu;
            }
        }
        #endregion dgvPIData_MouseClick

        #region mnuCopy_Click
        /// <summary>
        /// mnuCopy_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuCopy_Click(object sender, EventArgs e)
        {

            //Copy With Header

            dgvPIData.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dgvPIData.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }
        #endregion mnuCopy_Click


        #region btnExport_Click
        /// <summary>
        /// btnExport_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            

            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "DATA_" +cmbDocNo.Text.Trim().ToString()+ "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = cmbBatchName.Text;
            DataTable dtBatch = ObjPI.GetBatchNameById();

            int BatchTransfer = 0;

            if (dtBatch.Rows.Count > 0)
            {
                BatchTransfer = Convert.ToInt32(dtBatch.Rows[0]["Transfer"].ToString());
            }
                       
            ObjPI.DocNo = cmbDocNo.Text.Trim().ToString();

            if (BatchTransfer == 1)
            {
                ObjPI.Type = "PIAdjWO";
            }
            else
            {
                ObjPI.Type = "PIAdj";
            }

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);

            //DataTable dt = ObjPI.GetVarianceReportHeaderById();
            //ExportToCsv(dt, sw);

            DataTable dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt, sw);
            sw.Close();
            lblExportFile.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;

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
            ofdFileName.Filter = "CSV Files (*.csv)|*.csv";

            if (result == DialogResult.OK) // Test result.
            {
                txtFileNameData.Text = ofdFileName.FileName;
            }
        }
        #endregion btnBrowseData_Click


        #region btnImportData_Click
        /// <summary>
        /// btnImportData_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportData_Click(object sender, EventArgs e)
        {
            ImportVarianceHeader();
            ImportData();
        }
        #endregion btnImportData_Click

        #endregion Events


        #region Methods

        #region ImportAdjustments
        /// <summary>
        /// ImportAdjustments
        /// </summary>
        private void ImportAdjustments()
        {
            DataTable dtImport = CsvReader.ReadCSVFile(ofdFileName.FileName, false);
            bool Result = false;
            for(int i=3;i<dtImport.Rows.Count;i++)
            {
                PICountBL ObjPI = new PICountBL();
               
                ObjPI.Remarks = dtImport.Rows[i]["Column12"].ToString();
                ObjPI.VarianceAdjustment = Convert.ToInt32(dtImport.Rows[i]["Column11"].ToString());
                ObjPI.Id = Convert.ToInt32(dtImport.Rows[i]["Column1"].ToString());
                ObjPI.ManualCount = Convert.ToInt32(dtImport.Rows[i]["Column13"].ToString());
               
                ObjPI.UnitCost = Convert.ToDecimal(dtImport.Rows[i]["Column14"].ToString());
                Result = ObjPI.UpdateVarianceReport();
            }

            if (Result)
            {
                lblMessage.Text = "Successfully Updated";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Faild !";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }
        #endregion ImportAdjustments

        #region BindDocNo
        /// <summary>
        /// BindDocNo
        /// </summary>
        private void BindDocNo()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "All";
            DataTable dt = ObjPI.GetVarianceReportHeader();
            if (dt.Rows.Count > 0)
            {
                cmbDocNo.DataSource = dt;
                cmbDocNo.DisplayMember = "DocNo";
            }
        }
        #endregion BindDocNo

        #region Bind Batch Name
        /// <summary>
        /// Bind Batch Name
        /// </summary>
        private void BindBatchName()
        {
            PICountBL ObjPI = new PICountBL();
            DataTable dt = ObjPI.GetBatchName();
            if (dt.Rows.Count > 0)
            {
                cmbBatchName.DataSource = dt;
                cmbBatchName.DisplayMember = "BatchName";
            }
        }
        #endregion Bind Batch Name

        #region PostToNav
        /// <summary>
        /// PostToNav
        /// </summary>
        private void PostToNav()
        {
         
            PICountBL ObjPI = new PICountBL();

            ObjPI.DocNo = cmbDocNo.Text.Trim().ToString();
            ObjPI.Type = "Adjustment";
            DataTable dt = ObjPI.ExportPIVarianceReport();
            bool Result = false;

            ObjPI.DocNo = cmbBatchName.Text;
            DataTable dtBatch = ObjPI.GetBatchNameById();

            int BatchTransfer = 0;

            if (dtBatch.Rows.Count>0)
            {
                BatchTransfer = Convert.ToInt32(dtBatch.Rows[0]["Transfer"].ToString());
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Decimal Variance = 0;


                if (BatchTransfer == 1 )
                {
                    Variance = (DBNull.Value != dt.Rows[i]["CountQty"]) ? Convert.ToDecimal(dt.Rows[i]["CountQty"].ToString()) : 0;
                }
                else
                {
                    Variance = (DBNull.Value != dt.Rows[i]["ActualVariance"]) ? Convert.ToDecimal(dt.Rows[i]["ActualVariance"].ToString()) : 0;
                }

                Decimal Amount = (DBNull.Value != dt.Rows[i]["Amount"]) ? Convert.ToDecimal(dt.Rows[i]["Amount"].ToString()) : 0;

                if (Amount < 0)
                    Amount = Amount * -1;

                if (Variance < 0)
                    Variance = (Variance * -1);

                
                ObjPI.CompanyName = (null != ConfigurationManager.AppSettings["NAVCompanyName"].ToString()) ? ConfigurationManager.AppSettings["NAVCompanyName"].ToString() : "";
                ObjPI.JournalTemplateName = cmbJournalTempalate.Text;
                ObjPI.JournalBatchName = cmbBatchName.Text.ToString();
                ObjPI.ItemNo = (DBNull.Value != dt.Rows[i]["ItemNo"]) ? dt.Rows[i]["ItemNo"].ToString() : "";

                ObjPI.PostingDate = (DBNull.Value != dt.Rows[i]["DocumentDate"]) ? Convert.ToDateTime(dt.Rows[i]["DocumentDate"].ToString()) : DateTime.Now;
                ObjPI.EntryType = (Convert.ToInt32(dt.Rows[i]["ActualVariance"])<0)?3:2;
                ObjPI.DocumentNo = txtNavDocNo.Text.Trim().ToString();
                ObjPI.LocationCode = (null != ConfigurationManager.AppSettings["StoreCode"].ToString()) ? ConfigurationManager.AppSettings["StoreCode"].ToString() : "";

                ObjPI.StoreCode = (null != ConfigurationManager.AppSettings["StoreCode"].ToString()) ? ConfigurationManager.AppSettings["StoreCode"].ToString() : "";
                ObjPI.QuantityD = Variance;
                ObjPI.UnitAmount = (DBNull.Value != dt.Rows[i]["UnitAmount"]) ? Convert.ToDecimal(dt.Rows[i]["UnitAmount"].ToString()) : 0;
                ObjPI.UnitCost = (DBNull.Value != dt.Rows[i]["UnitCost"]) ? Convert.ToDecimal(dt.Rows[i]["UnitCost"].ToString()) : 0;

                ObjPI.Amount = Amount;
                ObjPI.Qty_Calculated = 0;
                ObjPI.Qty_Phys_Inventory = 0;
                ObjPI.DocumentDate = (null != dt.Rows[i]["DocumentDate"].ToString()) ? Convert.ToDateTime(dt.Rows[i]["DocumentDate"].ToString()) : DateTime.Now;

                ObjPI.ExternalDocNo = txtExternalDocNo.Text.Trim().ToString();

                if(Variance!=0)
                     Result = ObjPI.InsertInventoryToNav();
            }

            if (Result)
                MessageBox.Show("Successfully Posted");
            else
                MessageBox.Show("Failed!");

        }
        #endregion PostToNav


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



        #region ImportVarianceHeader
        /// <summary>
        /// ImportVarianceHeader
        /// </summary>
        private void ImportVarianceHeader()
        {
            DataTable dtImport = CsvReader.ReadCSVFile(ofdFileName.FileName, false);
            bool Result = false;
           
                PICountBL ObjPI = new PICountBL();

                if (dtImport.Rows.Count > 0)
                {
                    ObjPI.DocNo = dtImport.Rows[1]["Column1"].ToString();
                    ObjPI.PdtName = dtImport.Rows[1]["Column2"].ToString();
                    ObjPI.ScanningDoneBy = dtImport.Rows[1]["Column3"].ToString();
                    ObjPI.Description= dtImport.Rows[1]["Column4"].ToString();

                    ObjPI.CreatedBy = dtImport.Rows[1]["Column6"].ToString();
                    ObjPI.Type = dtImport.Rows[1]["Column7"].ToString();
                    
                    ObjPI.DeleteVarianceReport();
                    Result = ObjPI.InsertVarianceReportHeader();
                }

            if (Result)
            {
                lblMessage.Text = "Successfully Updated";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Faild !";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }
        #endregion ImportVarianceHeader


        #region ImportData
        /// <summary>
        /// ImportData
        /// </summary>
        private void ImportData()
        {
            DataTable dtImport = CsvReader.ReadCSVFile(ofdFileName.FileName, false);
            bool Result = false;
            for (int i = 3; i < dtImport.Rows.Count; i++)
            {
                PICountBL ObjPI = new PICountBL();

                ObjPI.DocNo = dtImport.Rows[i]["Column2"].ToString();
                ObjPI.LocationCode = dtImport.Rows[i]["Column3"].ToString();
                ObjPI.Barcode = dtImport.Rows[i]["Column4"].ToString();
                ObjPI.ItemNo = dtImport.Rows[i]["Column5"].ToString();

                ObjPI.CategoryCode = dtImport.Rows[i]["Column6"].ToString();
                ObjPI.Description = dtImport.Rows[i]["Column7"].ToString();
                ObjPI.SystemQty = Convert.ToInt32(dtImport.Rows[i]["Column8"].ToString());
                ObjPI.CountQty = Convert.ToInt32(dtImport.Rows[i]["Column9"].ToString());

                ObjPI.Variance = Convert.ToInt32(dtImport.Rows[i]["Column10"].ToString());
                ObjPI.VarianceAdjustment = Convert.ToInt32(dtImport.Rows[i]["Column11"].ToString());
                ObjPI.Remarks = dtImport.Rows[i]["Column12"].ToString();
                ObjPI.ManualCount = Convert.ToInt32(dtImport.Rows[i]["Column13"].ToString());

                Result = ObjPI.ImportVarianceReportData();

            }

            if (Result)
            {
                lblMessage.Text = "Successfully Updated";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Faild !";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }

        }
        #endregion ImportData

        #endregion Methods

    }
}
