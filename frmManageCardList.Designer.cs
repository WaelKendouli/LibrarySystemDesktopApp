namespace LibrarySystemApp
{
    partial class frmManageCardList
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
            this.updateThisCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(513, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Cards";
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateThisCardToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(211, 56);
            // 
            // updateThisCardToolStripMenuItem
            // 
            this.updateThisCardToolStripMenuItem.Name = "updateThisCardToolStripMenuItem";
            this.updateThisCardToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateThisCardToolStripMenuItem.Text = "Update this card";
            this.updateThisCardToolStripMenuItem.Click += new System.EventHandler(this.updateThisCardToolStripMenuItem_Click);
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(16, 95);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // frmManageCardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 739);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageCardList";
            this.Text = "frmManageCardList";
            this.Load += new System.EventHandler(this.frmManageCardList_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem updateThisCardToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}