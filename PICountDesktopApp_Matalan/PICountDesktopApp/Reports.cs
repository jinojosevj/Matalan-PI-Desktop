#region Name Space
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
#endregion Name Space
namespace PICountDesktopApp
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            BindDocNo();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
          string str = cmbReportType.Text;
          
              switch(str)
              {
                  case "PICountAll": ExportPICountAll();  
                                     break;

                  case "PICountVariance": ExportPICountVariance();
                                        break;

                  default : lblMessage.Text="Please Select Report Type";
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                            break;
              }
          
        }

        #region ExportPICountAll
        /// <summary>
        /// ExportPICountAll
        /// </summary>
        private void ExportPICountAll()
        {
            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "PI_" + cmbDocNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = cmbDocNo.Text.Trim().ToString();
            ObjPI.Type = "All";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);


            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt, sw);
            sw.Close();
            lblFileName.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        #endregion ExportPICountAll


        #region ExportPICountVariance
        /// <summary>
        /// ExportPICountVariance
        /// </summary>
        private void ExportPICountVariance()
        {
            saveFileDialog1.Filter = "CSV Files | *.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.FileName = "PI_Variance_" + cmbDocNo.Text.Trim().ToString() + "_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Ticks.ToString().Substring(0, 5);
            saveFileDialog1.ShowDialog();

            PICountBL ObjPI = new PICountBL();
            ObjPI.DocNo = cmbDocNo.Text.Trim();
            ObjPI.Type = "Variance";

            string path = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(@path, false);
            DataTable dt = ObjPI.GetVarianceReportHeaderById();
            ExportToCsv(dt, sw);

            dt = ObjPI.ExportPIVarianceReport();
            ExportToCsv(dt, sw);

            sw.Close();
            lblFileName.Text = saveFileDialog1.FileName;

            lblMessage.Text = "Successfully Exported";
            lblMessage.ForeColor = System.Drawing.Color.Green;
        }
        #endregion ExportPICountVariance

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


        #region BindDocNo
        /// <summary>
        /// BindDocNo
        /// </summary>
        private void BindDocNo()
        {
            PICountBL ObjPI = new PICountBL();
            ObjPI.Type = "All";
            DataTable dt=ObjPI.GetVarianceReportHeader();
            if (dt.Rows.Count > 0)
            {
                cmbDocNo.DataSource = dt;
                cmbDocNo.DisplayMember = "DocNo";
            }
        }
        #endregion BindDocNo
    }
}
