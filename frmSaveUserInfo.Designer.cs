namespace LibrarySystemApp
{
    partial class frmSaveUserInfo
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
            this.ctrlFillUserInfo1 = new LibrarySystemApp.ctrlFillUserInfo();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlFillUserInfo1
            // 
            this.ctrlFillUserInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlFillUserInfo1.Location = new System.Drawing.Point(36, 87);
            this.ctrlFillUserInfo1.Name = "ctrlFillUserInfo1";
            this.ctrlFillUserInfo1.Size = new System.Drawing.Size(907, 497);
            this.ctrlFillUserInfo1.TabIndex = 0;
            this.ctrlFillUserInfo1.OnUserInfosAdded += new System.EventHandler<LibraryLogicLayer.UserAddedEventsArgs>(this.ctrlFillUserInfo1_OnUserInfosAdded);
            this.ctrlFillUserInfo1.Load += new System.EventHandler(this.ctrlFillUserInfo1_Load);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(349, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(289, 46);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add New User";
            // 
            // frmSaveUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 609);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ctrlFillUserInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveUserInfo";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmSaveUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFillUserInfo ctrlFillUserInfo1;
        private System.Windows.Forms.Label lbTitle;
    }
}