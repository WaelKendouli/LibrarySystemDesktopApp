namespace LibrarySystemApp
{
    partial class frmViewAuthorWork
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
            this.lbAuthor = new System.Windows.Forms.Label();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.SuspendLayout();
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbAuthor.Location = new System.Drawing.Point(38, 9);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(212, 69);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Author";
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.Location = new System.Drawing.Point(2, 81);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            this.ctrlBookListing1.Load += new System.EventHandler(this.ctrlBookListing1_Load);
            // 
            // frmViewAuthorWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 711);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewAuthorWork";
            this.Text = "View Author Work";
            this.Load += new System.EventHandler(this.frmViewAuthorWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label lbAuthor;
    }
}