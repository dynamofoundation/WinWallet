using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWallet
{
    public partial class frmSetPassword : Form
    {

        public frmCreateWallet1 walletForm;

        public frmSetPassword()
        {
            InitializeComponent();
        }

        private void cmdSetPassword_Click(object sender, EventArgs e)
        {
            string pass1 = txtPassword1.Text;
            string pass2 = txtPassword2.Text;

            if (pass1.Length == 0)
                lblMessage.Text = "Please enter a password";
            else if (pass2.Length == 0)
                lblMessage.Text = "Please confirm password";
            else if (pass1 != pass2)
                lblMessage.Text = "Passwords do not match";
            else
            {
                Global.password = pass1;
                walletForm.step2();
                this.Close();
            }


        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
