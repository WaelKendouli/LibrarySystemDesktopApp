namespace LibrarySystemApp
{
    partial class frmListOfPenaltiesForOneUser
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
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(343, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Of Penalies for this user";
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.Location = new System.Drawing.Point(14, 104);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 630);
            this.ctrlBookListing1.TabIndex = 3;
            // 
            // frmListOfPenaltiesForOneUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 736);
            this.Controls.Add(this.ctrlBookListing1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfPenaltiesForOneUser";
            this.Text = "frmListOfPenaltiesForOneUser";
            this.Load += new System.EventHandler(this.frmListOfPenaltiesForOneUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlBookListing ctrlBookListing1;
    }
}