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
    public partial class frmShowWords : Form
    {

        public string[] words = new string[12];
        frmCreateWallet1 walletForm;

        public frmShowWords()
        {
            InitializeComponent();
        }

        private void frmShowWords_Load(object sender, EventArgs e)
        {
            lblWord1.Text = "";
            lblWord2.Text = "";
            lblWord3.Text = "";
            lblWord4.Text = "";
            lblWord5.Text = "";
            lblWord6.Text = "";
            lblWord7.Text = "";
            lblWord8.Text = "";
            lblWord9.Text = "";
            lblWord10.Text = "";
            lblWord11.Text = "";
            lblWord12.Text = "";
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            lblWord1.Text = "Word1: " + words[0];
            lblWord2.Text = "Word2: " + words[1];
            lblWord3.Text = "Word3: " + words[2];
            lblWord4.Text = "Word4: " + words[3];
            lblWord5.Text = "Word5: " + words[4];
            lblWord6.Text = "Word6: " + words[5];
            lblWord7.Text = "Word7: " + words[6];
            lblWord8.Text = "Word8: " + words[7];
            lblWord9.Text = "Word9: " + words[8];
            lblWord10.Text = "Word10: " + words[9];
            lblWord11.Text = "Word11: " + words[10];
            lblWord12.Text = "Word12: " + words[11];
        }

        private void cmdDone_Click(object sender, EventArgs e)
        {
            walletForm.step4();
            this.Hide();
        }
    }
}
