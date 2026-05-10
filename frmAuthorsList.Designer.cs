namespace LibrarySystemApp
{
    partial class frmAuthorsList
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
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(550, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors List";
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkToolStripMenuItem,
            this.updateAuthorToolStripMenuItem,
            this.deleteAuthorToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(211, 104);
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addWorkToolStripMenuItem.Text = "Add work";
            this.addWorkToolStripMenuItem.Click += new System.EventHandler(this.addWorkToolStripMenuItem_Click);
            // 
            // updateAuthorToolStripMenuItem
            // 
            this.updateAuthorToolStripMenuItem.Name = "updateAuthorToolStripMenuItem";
            this.updateAuthorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateAuthorToolStripMenuItem.Text = "Update Author";
            this.updateAuthorToolStripMenuItem.Click += new System.EventHandler(this.updateAuthorToolStripMenuItem_Click);
            // 
            // deleteAuthorToolStripMenuItem
            // 
            this.deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            this.deleteAuthorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteAuthorToolStripMenuItem.Text = "Delete Author";
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(12, 76);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // frmAuthorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAuthorsList";
            this.Text = "Authors List";
            this.Load += new System.EventHandler(this.frmAuthorsList_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem addWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAuthorToolStripMenuItem;
    }
}