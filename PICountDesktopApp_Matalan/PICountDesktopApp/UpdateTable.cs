
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
    public partial class UpdateTable : Form
    {

        #region Events

        #region UpdateTable
        /// <summary>
        /// Update Table
        /// </summary>
        public UpdateTable()
        {
            InitializeComponent();
            lblMessage.Text = "Refresh process is going on ,don't close this window";
            lblMessage.ForeColor = System.Drawing.Color.Yellow;
            lblMessage.Visible = false;

        }
        #endregion UpdateTable

        #region btnRefresh_Click
        /// <summary>
        /// btnRefresh_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
            btnRefresh.Visible = false;
          
            PICountBL objPI = new PICountBL();
           bool Result= objPI.UpdateItemMaster();
            if(Result)
            {
                lblMessage.Text = "Successfully Completed";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion btnRefresh_Click

        #endregion Events
    }
}
