namespace LibrarySystemApp
{
    partial class frmRecieveRequestFromUsers
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
            this.ctrlSeeRequestMessage1 = new LibrarySystemApp.ctrlSeeRequestMessage();
            this.SuspendLayout();
            // 
            // ctrlSeeRequestMessage1
            // 
            this.ctrlSeeRequestMessage1.BackColor = System.Drawing.Color.White;
            this.ctrlSeeRequestMessage1.Location = new System.Drawing.Point(21, 25);
            this.ctrlSeeRequestMessage1.Name = "ctrlSeeRequestMessage1";
            this.ctrlSeeRequestMessage1.Size = new System.Drawing.Size(722, 611);
            this.ctrlSeeRequestMessage1.TabIndex = 0;
            this.ctrlSeeRequestMessage1.Load += new System.EventHandler(this.ctrlSeeRequestMessage1_Load);
            // 
            // frmRecieveRequestFromUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 667);
            this.Controls.Add(this.ctrlSeeRequestMessage1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecieveRequestFromUsers";
            this.Text = "frmRecieveRequestFromUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSeeRequestMessage ctrlSeeRequestMessage1;
    }
}