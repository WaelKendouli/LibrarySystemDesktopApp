namespace LibrarySystemApp
{
    partial class frmCopyDetails
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
            this.ctrlCopyBookInfo1 = new LibrarySystemApp.ctrlCopyBookInfo();
            this.SuspendLayout();
            // 
            // ctrlCopyBookInfo1
            // 
            this.ctrlCopyBookInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlCopyBookInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlCopyBookInfo1.Name = "ctrlCopyBookInfo1";
            this.ctrlCopyBookInfo1.Size = new System.Drawing.Size(1085, 725);
            this.ctrlCopyBookInfo1.TabIndex = 0;
            // 
            // frmCopyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 741);
            this.Controls.Add(this.ctrlCopyBookInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCopyDetails";
            this.Text = "frmCopyDetails";
            this.Load += new System.EventHandler(this.frmCopyDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCopyBookInfo ctrlCopyBookInfo1;
    }
}