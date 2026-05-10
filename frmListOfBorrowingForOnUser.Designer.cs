namespace LibrarySystemApp
{
    partial class frmListOfBorrowingForOnUser
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
            this.components = new System.ComponentModel.Container();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnThisBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(12, 112);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnThisBookToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(211, 56);
            // 
            // returnThisBookToolStripMenuItem
            // 
            this.returnThisBookToolStripMenuItem.Name = "returnThisBookToolStripMenuItem";
            this.returnThisBookToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.returnThisBookToolStripMenuItem.Text = "Return this book";
            this.returnThisBookToolStripMenuItem.Click += new System.EventHandler(this.returnThisBookToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(371, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Borrowings for one user";
            // 
            // frmListOfBorrowingForOnUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfBorrowingForOnUser";
            this.Text = "List Of Borrowing For One User";
            this.Load += new System.EventHandler(this.frmListOfBorrowingForOnUser_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem returnThisBookToolStripMenuItem;
    }
}