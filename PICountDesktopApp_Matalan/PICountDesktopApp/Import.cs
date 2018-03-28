#region NameSpace
    using PICountDesktopApp.BAL;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
#endregion NameSpace
namespace PICountDesktopApp
{
    public partial class Import : Form
    {

        #region Events

        #region Import
        /// <summary>
        /// Import
        /// </summary>
        public Import()
        {
            InitializeComponent();
        }

        #endregion Import

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
            
            if(txtFileName.Text.ToString().Length>0)
            {
               ImportBarcodeData();
            }
        }
        #endregion btnImport_Click

        #endregion Events

        #region Methods

         #region Import Barcode Data
        /// <summary>
        ///  Import Barcode Data
        /// </summary>
        private void ImportBarcodeData()
        {
            try
            {
                DataTable dtImport = CsvReader.ReadCSVFile(ofdFileName.FileName, true);
                PICountBL objPI = new PICountBL();

                //for delete old data
                objPI.DeleteTempBarcode();

                    dtImport.Columns.Add("CreatedDate");
                    dtImport.Columns.Add("CreatedBy");

                for(int i=0;i<dtImport.Rows.Count;i++)
                {
                    dtImport.Rows[i]["Location"] = Common.Base64Decode(dtImport.Rows[i]["Location"].ToString());
                    dtImport.Rows[i]["Barcode"] = Common.Base64Decode(dtImport.Rows[i]["Barcode"].ToString());
                    
                    dtImport.Rows[i]["CreatedDate"] = DateTime.Now;
                    dtImport.Rows[i]["CreatedBy"] = Common.UserId;
                }
                
                    bool Result = false;
                    objPI.DtSource = dtImport;
                    Result = objPI.ImportBarcodeData();

                    if (Result)
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Successfully Imported";
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Faild To Import Data";
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

        #endregion Methods
    }
}
