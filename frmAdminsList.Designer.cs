namespace LibrarySystemApp
{
    partial class frmAdminsList
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
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contactThisAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.checkRepliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(360, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of admins for contact";
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactThisAdminToolStripMenuItem,
            this.checkRepliesToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(211, 80);
            // 
            // contactThisAdminToolStripMenuItem
            // 
            this.contactThisAdminToolStripMenuItem.Name = "contactThisAdminToolStripMenuItem";
            this.contactThisAdminToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.contactThisAdminToolStripMenuItem.Text = "Contact this admin";
            this.contactThisAdminToolStripMenuItem.Click += new System.EventHandler(this.contactThisAdminToolStripMenuItem_Click);
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(42, 98);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // checkRepliesToolStripMenuItem
            // 
            this.checkRepliesToolStripMenuItem.Name = "checkRepliesToolStripMenuItem";
            this.checkRepliesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.checkRepliesToolStripMenuItem.Text = "Check replies";
            this.checkRepliesToolStripMenuItem.Click += new System.EventHandler(this.checkRepliesToolStripMenuItem_Click);
            // 
            // frmAdminsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminsList";
            this.Text = "frmAdminsList";
            this.Load += new System.EventHandler(this.frmAdminsList_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem contactThisAdminToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem checkRepliesToolStripMenuItem;
    }
}