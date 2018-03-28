
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
#endregion NameSpace
namespace PICountDesktopApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region btnLogin_Click
        /// <summary>
        /// btnLogin_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PICountBL objPi = new PICountBL();
            objPi.Username = txtUsername.Text.Trim().ToString();
            objPi.Password = txtPassword.Text.Trim().ToString();

            
            DataTable dt = objPi.CheckLogin();

            if(dt.Rows.Count>0)
            {
                Common.Privilege = dt.Rows[0]["Privilege"].ToString();
                Common.Location= dt.Rows[0]["Location"].ToString();
                Common.WorkSheets = Convert.ToInt32(dt.Rows[0]["WorkSheets"].ToString());
                Common.Files = Convert.ToInt32(dt.Rows[0]["Files"].ToString());


                frmHome ObjHome = new frmHome();
                ObjHome.Show();
                this.Hide();
                Common.UserId = txtUsername.Text.Trim().ToString();
            }
            else
            {
                lblMessage.Text = "Invalid Username / Password";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion btnLogin_Click
    }
}
