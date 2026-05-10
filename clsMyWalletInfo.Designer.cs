namespace LibrarySystemApp
{
    partial class clsMyWalletInfo
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
            this.ctrlUserInfo1 = new LibrarySystemApp.ctrlUserInfo();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlUserInfo1.Location = new System.Drawing.Point(42, 19);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(1271, 586);
            this.ctrlUserInfo1.TabIndex = 0;
            // 
            // clsMyWalletInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 617);
            this.Controls.Add(this.ctrlUserInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clsMyWalletInfo";
            this.Text = "My Wallet Info";
            this.Load += new System.EventHandler(this.clsMyWalletInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
    }
}