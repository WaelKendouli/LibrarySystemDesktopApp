namespace LibrarySystemApp
{
    partial class frmSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlFillUserInfo1 = new LibrarySystemApp.ctrlFillUserInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(371, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign up";
            // 
            // ctrlFillUserInfo1
            // 
            this.ctrlFillUserInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlFillUserInfo1.Location = new System.Drawing.Point(44, 108);
            this.ctrlFillUserInfo1.Name = "ctrlFillUserInfo1";
            this.ctrlFillUserInfo1.Size = new System.Drawing.Size(907, 497);
            this.ctrlFillUserInfo1.TabIndex = 0;
            this.ctrlFillUserInfo1.OnUserInfosAdded += new System.EventHandler<LibraryLogicLayer.UserAddedEventsArgs>(this.ctrlFillUserInfo1_OnUserInfosAdded);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFillUserInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFillUserInfo ctrlFillUserInfo1;
        private System.Windows.Forms.Label label1;
    }
}