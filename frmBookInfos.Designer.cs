namespace LibrarySystemApp
{
    partial class frmBookInfos
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
            this.ctrlBookInfos1 = new LibrarySystemApp.ctrlBookInfos();
            this.SuspendLayout();
            // 
            // ctrlBookInfos1
            // 
            this.ctrlBookInfos1.BackColor = System.Drawing.Color.White;
            this.ctrlBookInfos1.Location = new System.Drawing.Point(27, 18);
            this.ctrlBookInfos1.Name = "ctrlBookInfos1";
            this.ctrlBookInfos1.Size = new System.Drawing.Size(1010, 576);
            this.ctrlBookInfos1.TabIndex = 0;
            // 
            // frmBookInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 606);
            this.Controls.Add(this.ctrlBookInfos1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookInfos";
            this.Text = "frmBookInfos";
            this.Load += new System.EventHandler(this.frmBookInfos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlBookInfos ctrlBookInfos1;
    }
}