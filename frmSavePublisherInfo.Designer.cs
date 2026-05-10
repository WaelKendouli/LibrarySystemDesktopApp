namespace LibrarySystemApp
{
    partial class frmSavePublisherInfo
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlPublisherInfosSaved1 = new LibrarySystemApp.ctrlPublisherInfosSaved();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbTitle.Location = new System.Drawing.Point(307, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(375, 50);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add new Publisher";
            // 
            // ctrlPublisherInfosSaved1
            // 
            this.ctrlPublisherInfosSaved1.BackColor = System.Drawing.Color.White;
            this.ctrlPublisherInfosSaved1.Location = new System.Drawing.Point(12, 82);
            this.ctrlPublisherInfosSaved1.Name = "ctrlPublisherInfosSaved1";
            this.ctrlPublisherInfosSaved1.Size = new System.Drawing.Size(902, 458);
            this.ctrlPublisherInfosSaved1.TabIndex = 0;
            this.ctrlPublisherInfosSaved1.OnPublisherSaved += new System.EventHandler<LibraryLogicLayer.clsOnPublisherSavedEventsArgs>(this.ctrlPublisherInfosSaved1_OnPublisherSaved);
            // 
            // frmSavePublisherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 592);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ctrlPublisherInfosSaved1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSavePublisherInfo";
            this.Text = "Save Publisher Info";
            this.Load += new System.EventHandler(this.frmSavePublisherInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPublisherInfosSaved ctrlPublisherInfosSaved1;
        private System.Windows.Forms.Label lbTitle;
    }
}