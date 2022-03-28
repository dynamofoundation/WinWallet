
namespace WinWallet
{
    partial class frmStart
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
            this.cmdNewWallet = new System.Windows.Forms.Button();
            this.cmdRestoreWallet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNewWallet
            // 
            this.cmdNewWallet.Location = new System.Drawing.Point(76, 69);
            this.cmdNewWallet.Name = "cmdNewWallet";
            this.cmdNewWallet.Size = new System.Drawing.Size(226, 34);
            this.cmdNewWallet.TabIndex = 0;
            this.cmdNewWallet.Text = "Create New Wallet";
            this.cmdNewWallet.UseVisualStyleBackColor = true;
            this.cmdNewWallet.Click += new System.EventHandler(this.cmdNewWallet_Click);
            // 
            // cmdRestoreWallet
            // 
            this.cmdRestoreWallet.Location = new System.Drawing.Point(76, 172);
            this.cmdRestoreWallet.Name = "cmdRestoreWallet";
            this.cmdRestoreWallet.Size = new System.Drawing.Size(226, 34);
            this.cmdRestoreWallet.TabIndex = 1;
            this.cmdRestoreWallet.Text = "Restore Existing Wallet";
            this.cmdRestoreWallet.UseVisualStyleBackColor = true;
            this.cmdRestoreWallet.Click += new System.EventHandler(this.cmdRestoreWallet_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 274);
            this.ControlBox = false;
            this.Controls.Add(this.cmdRestoreWallet);
            this.Controls.Add(this.cmdNewWallet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamo WinWallet v0.1 alpha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNewWallet;
        private System.Windows.Forms.Button cmdRestoreWallet;
    }
}