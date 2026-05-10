namespace LibrarySystemApp
{
    partial class frmCopiesList
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.contextMenuStrip1;
            this.ctrlBookListing1.Location = new System.Drawing.Point(12, 77);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            this.ctrlBookListing1.Load += new System.EventHandler(this.ctrlBookListing1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(506, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copies List";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // seeDetailsToolStripMenuItem
            // 
            this.seeDetailsToolStripMenuItem.Name = "seeDetailsToolStripMenuItem";
            this.seeDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.seeDetailsToolStripMenuItem.Text = "See Details";
            this.seeDetailsToolStripMenuItem.Click += new System.EventHandler(this.seeDetailsToolStripMenuItem_Click);
            // 
            // frmCopiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCopiesList";
            this.Text = "Copies List";
            this.Load += new System.EventHandler(this.frmCopiesList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seeDetailsToolStripMenuItem;
    }
}