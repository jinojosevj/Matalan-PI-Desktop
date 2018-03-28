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
#endregion NameSpace
namespace PICountDesktopApp
{
    public partial class frmHome : Form
    {

        #region frmHome
        /// <summary>
        /// frmHome
        /// </summary>
        public frmHome()
        {
            InitializeComponent();

            if (Common.Privilege == "User")
                pIAdjustmentsToolStripMenuItem.Enabled = false;

        }
        #endregion frmHome

        #region newWorksheetToolStripMenuItem_Click
        /// <summary>
        /// newWorksheetToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newWorksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
             PICountBL Obj = new PICountBL();

             Obj.Username = Common.UserId;
             DataTable dtHeader = Obj.GetVarianceReportHeaderByDate();
             

             if (dtHeader.Rows.Count >= Common.WorkSheets && Common.Privilege != "Super")
             {
                 MessageBox.Show("You Cannot Create Any More PI Documents Today !");
             }
             else
             {
                 PICountReport ObjPi = new PICountReport();
                 ObjPi.MdiParent = this;
                 ObjPi.Show();
             }
        }
        #endregion newWorksheetToolStripMenuItem_Click


        #region ShowPICountReport
        /// <summary>
        /// Show PI Count Report 
        /// </summary>
        public void ShowPICountReport()
        {
            PICountReport objPi = new PICountReport();
            objPi.MdiParent = this;
            objPi.Show();
        }
        #endregion ShowPICountReport

               

        #region updateTablesToolStripMenuItem_Click
        /// <summary>
        /// updateTablesToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTable ObjPi = new UpdateTable();
            ObjPi.MdiParent = this;
            ObjPi.Show();
        }
        #endregion updateTablesToolStripMenuItem_Click


        #region changePasswordToolStripMenuItem_Click
        /// <summary>
        /// changePasswordToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword objPI = new ChangePassword();
            objPI.MdiParent = this;
            objPI.Show();
        }
        #endregion changePasswordToolStripMenuItem_Click


        #region reportsToolStripMenuItem_Click
        /// <summary>
        /// reportsToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports objPI = new Reports();
            objPI.MdiParent = this;
            objPI.Show();
        }
        #endregion reportsToolStripMenuItem_Click


        #region pIAdjustmentsToolStripMenuItem_Click
        /// <summary>
        /// pIAdjustmentsToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pIAdjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PIAdjustment ObjPi = new PIAdjustment();
            ObjPi.MdiParent = this;
            ObjPi.Show();
        }
        #endregion pIAdjustmentsToolStripMenuItem_Click


        #region writeOffToolStripMenuItem_Click
        /// <summary>
        /// writeOffToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PICountBL Obj = new PICountBL();

            Obj.Username = Common.UserId;
            DataTable dtHeader = Obj.GetVarianceReportHeaderByDate();

            if (dtHeader.Rows.Count >= Common.WorkSheets && Common.Privilege != "Super")
            {
                MessageBox.Show("You Cannot Create Any More Write Off Documents Today !");
            }
            else
            {
                WriteOff ObjWo = new WriteOff();
                ObjWo.MdiParent = this;
                ObjWo.Show();
            }
        }
        #endregion writeOffToolStripMenuItem_Click


        #region negativeToolStripMenuItem_Click
        /// <summary>
        /// negativeToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PICountBL Obj = new PICountBL();

            Obj.Username = Common.UserId;
            DataTable dtHeader = Obj.GetVarianceReportHeaderByDate();
            if (dtHeader.Rows.Count >= Common.WorkSheets && Common.Privilege != "Super")
            {
                MessageBox.Show("You Cannot Create Any More Negative Documents Today !");
            }
            else
            {
                NegativeCount ObjNA = new NegativeCount();
                ObjNA.MdiParent = this;
                ObjNA.Show();
            }
        }
        #endregion negativeToolStripMenuItem_Click


        #region  purchaseOrderToolStripMenuItem_Click
        /// <summary>
        /// purchaseOrderToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder ObjPO = new PurchaseOrder();
            ObjPO.MdiParent = this;
            ObjPO.Show();
        }
        #endregion purchaseOrderToolStripMenuItem_Click


        #region labelPrintToolStripMenuItem_Click
        /// <summary>
        /// labelPrintToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelPrinting ObjLP = new LabelPrinting();
            ObjLP.MdiParent = this;
            ObjLP.Show();
        }
        #endregion labelPrintToolStripMenuItem_Click


        #region transferOrderToolStripMenuItem_Click
        /// <summary>
        /// transferOrderToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transferOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferOrder ObjTO = new TransferOrder();
            ObjTO.MdiParent = this;
            ObjTO.Show();
        }
        #endregion transferOrderToolStripMenuItem_Click
    }
}
