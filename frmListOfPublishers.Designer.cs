namespace LibrarySystemApp
{
    partial class frmListOfPublishers
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.associateThisPublisherWithAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociateThisPublisherWithBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(472, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of publishers";
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(12, 103);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associateThisPublisherWithAuthorsToolStripMenuItem,
            this.asociateThisPublisherWithBooksToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(319, 76);
            // 
            // associateThisPublisherWithAuthorsToolStripMenuItem
            // 
            this.associateThisPublisherWithAuthorsToolStripMenuItem.Name = "associateThisPublisherWithAuthorsToolStripMenuItem";
            this.associateThisPublisherWithAuthorsToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.associateThisPublisherWithAuthorsToolStripMenuItem.Text = "Associate this publisher with authors";
            this.associateThisPublisherWithAuthorsToolStripMenuItem.Click += new System.EventHandler(this.associateThisPublisherWithAuthorsToolStripMenuItem_Click);
            // 
            // asociateThisPublisherWithBooksToolStripMenuItem
            // 
            this.asociateThisPublisherWithBooksToolStripMenuItem.Name = "asociateThisPublisherWithBooksToolStripMenuItem";
            this.asociateThisPublisherWithBooksToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.asociateThisPublisherWithBooksToolStripMenuItem.Text = "Asociate this publisher with books";
            this.asociateThisPublisherWithBooksToolStripMenuItem.Click += new System.EventHandler(this.asociateThisPublisherWithBooksToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // frmListOfPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfPublishers";
            this.Text = "List Of Publishers";
            this.Load += new System.EventHandler(this.frmListOfPublishers_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem associateThisPublisherWithAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociateThisPublisherWithBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}