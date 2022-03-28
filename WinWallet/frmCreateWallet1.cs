using NBitcoin;
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
    public partial class frmCreateWallet1 : Form
    {

        public string xprv;
        public string address;
        public string[] words = new string[12];

        public frmCreateWallet1()
        {
            InitializeComponent();
        }

        private void cmdGenerateKey_Click(object sender, EventArgs e)
        {
            Network network = NBitcoin.Altcoins.Dynamo.Instance.Mainnet;

            Mnemonic mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
            ExtKey hdRoot = mnemo.DeriveExtKey();
            KeyPath k = new KeyPath("m/0'/0'/0'");
            BitcoinWitPubKeyAddress a = hdRoot.Derive(k).GetPublicKey().Compress().WitHash.GetAddress(network); ;
            address = a.ToString();
            words = mnemo.Words;

            xprv = hdRoot.ToString(network);

            step3();

        }

        private void cmdSetPassword_Click(object sender, EventArgs e)
        {
            var frm = new frmSetPassword();
            frm.Show();
            frm.walletForm = this;
        }

        private void cmdShowSeed_Click(object sender, EventArgs e)
        {
            var frm = new frmShowWords();
            frm.Show();
            for (int i = 0; i < 12; i++)
                frm.words[i] = words[i];
        }


        public void step2()
        {
            cmdGenerateKey.Enabled = true;
            cmdSetPassword.Enabled = false;
        }

        public void step3()
        {
            cmdGenerateKey.Enabled = false;
            cmdShowSeed.Enabled = true;
        }
        public void step4()
        {
            cmdShowSeed.Enabled = false;
            cmdVerify.Enabled = true;
        }

        private void frmCreateWallet1_Load(object sender, EventArgs e)
        {

        }

        private void cmdVerify_Click(object sender, EventArgs e)
        {
            var frm = new frmVerifyWords();
            frm.walletForm = this;
        }

        public void SaveWallet()
        {
            this.Hide();
        }
    }
}
