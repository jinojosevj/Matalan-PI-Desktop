using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PICountDesktopApp.BAL;

namespace PICountDesktopApp
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            PICountBL objPi = new PICountBL();
            objPi.Username = Common.UserId;
            objPi.Password = txtCurrentPassword.Text.Trim().ToString();
            objPi.NewPassword = txtNewPassword.Text.Trim().ToString();
            bool Result=objPi.ChangePassword();
            if (Result)
            {
                lblMessage.Text = "Your Password has been changed!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Faild!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
                
        }
    }
}
