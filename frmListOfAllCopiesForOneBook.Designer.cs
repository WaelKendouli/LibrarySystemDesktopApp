namespace LibrarySystemApp
{
    partial class frmListOfAllCopiesForOneBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrowThisCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveThisCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyThisCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(10, 66);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(426, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Available Copies";
            // 
            // cmsOptions
            // 
            this.cmsOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowThisCopyToolStripMenuItem,
            this.reserveThisCopyToolStripMenuItem,
            this.buyThisCopyToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(252, 128);
            // 
            // borrowThisCopyToolStripMenuItem
            // 
            this.borrowThisCopyToolStripMenuItem.Name = "borrowThisCopyToolStripMenuItem";
            this.borrowThisCopyToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.borrowThisCopyToolStripMenuItem.Text = "Borrow this copy";
            this.borrowThisCopyToolStripMenuItem.Click += new System.EventHandler(this.borrowThisCopyToolStripMenuItem_Click);
            // 
            // reserveThisCopyToolStripMenuItem
            // 
            this.reserveThisCopyToolStripMenuItem.Name = "reserveThisCopyToolStripMenuItem";
            this.reserveThisCopyToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.reserveThisCopyToolStripMenuItem.Text = "Reserve this copy";
            // 
            // buyThisCopyToolStripMenuItem
            // 
            this.buyThisCopyToolStripMenuItem.Name = "buyThisCopyToolStripMenuItem";
            this.buyThisCopyToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.buyThisCopyToolStripMenuItem.Text = "Buy This copy";
            this.buyThisCopyToolStripMenuItem.Click += new System.EventHandler(this.buyThisCopyToolStripMenuItem_Click);
            // 
            // frmListOfAllCopiesForOneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfAllCopiesForOneBook";
            this.Text = "frmListOfAllCopiesForOneBook";
            this.Load += new System.EventHandler(this.frmListOfAllCopiesForOneBook_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem borrowThisCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveThisCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyThisCopyToolStripMenuItem;
    }
}