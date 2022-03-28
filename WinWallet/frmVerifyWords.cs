using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWallet
{
    public partial class frmVerifyWords : Form
    {
        public frmCreateWallet1 walletForm;

        public frmVerifyWords()
        {
            InitializeComponent();
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            if (
                (txtWord1.Text == walletForm.words[0]) &&
                (txtWord2.Text == walletForm.words[1]) &&
                (txtWord3.Text == walletForm.words[2]) &&
                (txtWord4.Text == walletForm.words[3]) &&
                (txtWord5.Text == walletForm.words[4]) &&
                (txtWord6.Text == walletForm.words[5]) &&
                (txtWord7.Text == walletForm.words[6]) &&
                (txtWord8.Text == walletForm.words[7]) &&
                (txtWord9.Text == walletForm.words[8]) &&
                (txtWord10.Text == walletForm.words[9]) &&
                (txtWord11.Text == walletForm.words[10]) &&
                (txtWord12.Text == walletForm.words[11])
                )
            {
                this.Hide();
                walletForm.SaveWallet();
            }
            else
                lblResult.Text = "Recovery seed words do not match";

        }
    }
}
