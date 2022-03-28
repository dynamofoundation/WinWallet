
namespace WinWallet
{
    partial class frmCreateWallet1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGenerateKey = new System.Windows.Forms.Button();
            this.cmdShowSeed = new System.Windows.Forms.Button();
            this.cmdVerify = new System.Windows.Forms.Button();
            this.cmdSetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdGenerateKey
            // 
            this.cmdGenerateKey.Enabled = false;
            this.cmdGenerateKey.Location = new System.Drawing.Point(134, 122);
            this.cmdGenerateKey.Name = "cmdGenerateKey";
            this.cmdGenerateKey.Size = new System.Drawing.Size(267, 34);
            this.cmdGenerateKey.TabIndex = 0;
            this.cmdGenerateKey.Text = "Generate Master Key";
            this.cmdGenerateKey.UseVisualStyleBackColor = true;
            this.cmdGenerateKey.Click += new System.EventHandler(this.cmdGenerateKey_Click);
            // 
            // cmdShowSeed
            // 
            this.cmdShowSeed.Enabled = false;
            this.cmdShowSeed.Location = new System.Drawing.Point(134, 191);
            this.cmdShowSeed.Name = "cmdShowSeed";
            this.cmdShowSeed.Size = new System.Drawing.Size(267, 34);
            this.cmdShowSeed.TabIndex = 1;
            this.cmdShowSeed.Text = "Show Recovery Seed";
            this.cmdShowSeed.UseVisualStyleBackColor = true;
            this.cmdShowSeed.Click += new System.EventHandler(this.cmdShowSeed_Click);
            // 
            // cmdVerify
            // 
            this.cmdVerify.Enabled = false;
            this.cmdVerify.Location = new System.Drawing.Point(134, 263);
            this.cmdVerify.Name = "cmdVerify";
            this.cmdVerify.Size = new System.Drawing.Size(267, 34);
            this.cmdVerify.TabIndex = 2;
            this.cmdVerify.Text = "Verify Recovery Seed";
            this.cmdVerify.UseVisualStyleBackColor = true;
            this.cmdVerify.Click += new System.EventHandler(this.cmdVerify_Click);
            // 
            // cmdSetPassword
            // 
            this.cmdSetPassword.Location = new System.Drawing.Point(134, 50);
            this.cmdSetPassword.Name = "cmdSetPassword";
            this.cmdSetPassword.Size = new System.Drawing.Size(267, 34);
            this.cmdSetPassword.TabIndex = 3;
            this.cmdSetPassword.Text = "Set Wallet Password";
            this.cmdSetPassword.UseVisualStyleBackColor = true;
            this.cmdSetPassword.Click += new System.EventHandler(this.cmdSetPassword_Click);
            // 
            // frmCreateWallet1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 337);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSetPassword);
            this.Controls.Add(this.cmdVerify);
            this.Controls.Add(this.cmdShowSeed);
            this.Controls.Add(this.cmdGenerateKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateWallet1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Dynamo Wallet";
            this.Load += new System.EventHandler(this.frmCreateWallet1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGenerateKey;
        private System.Windows.Forms.Button cmdShowSeed;
        private System.Windows.Forms.Button cmdVerify;
        private System.Windows.Forms.Button cmdSetPassword;
    }
}