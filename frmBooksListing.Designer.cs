namespace LibrarySystemApp
{
    partial class frmBooksListing
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAvailableCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forThisBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seePiblisherDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageThisBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateThisBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeDetailsToolStripMenuItem,
            this.showAvailableCopiesToolStripMenuItem,
            this.linkToCategoryToolStripMenuItem,
            this.addCopiesToolStripMenuItem,
            this.seePiblisherDetailsToolStripMenuItem,
            this.manageThisBookToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 200);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // seeDetailsToolStripMenuItem
            // 
            this.seeDetailsToolStripMenuItem.Name = "seeDetailsToolStripMenuItem";
            this.seeDetailsToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.seeDetailsToolStripMenuItem.Text = "See Details";
            this.seeDetailsToolStripMenuItem.Click += new System.EventHandler(this.seeDetailsToolStripMenuItem_Click);
            // 
            // showAvailableCopiesToolStripMenuItem
            // 
            this.showAvailableCopiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forThisBookToolStripMenuItem,
            this.allCopiesToolStripMenuItem});
            this.showAvailableCopiesToolStripMenuItem.Name = "showAvailableCopiesToolStripMenuItem";
            this.showAvailableCopiesToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.showAvailableCopiesToolStripMenuItem.Text = "Show Available Copies";
            // 
            // forThisBookToolStripMenuItem
            // 
            this.forThisBookToolStripMenuItem.Name = "forThisBookToolStripMenuItem";
            this.forThisBookToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.forThisBookToolStripMenuItem.Text = "For this book";
            this.forThisBookToolStripMenuItem.Click += new System.EventHandler(this.forThisBookToolStripMenuItem_Click);
            // 
            // allCopiesToolStripMenuItem
            // 
            this.allCopiesToolStripMenuItem.Name = "allCopiesToolStripMenuItem";
            this.allCopiesToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.allCopiesToolStripMenuItem.Text = "All copies";
            this.allCopiesToolStripMenuItem.Click += new System.EventHandler(this.allCopiesToolStripMenuItem_Click);
            // 
            // linkToCategoryToolStripMenuItem
            // 
            this.linkToCategoryToolStripMenuItem.Name = "linkToCategoryToolStripMenuItem";
            this.linkToCategoryToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.linkToCategoryToolStripMenuItem.Text = "Link to category";
            this.linkToCategoryToolStripMenuItem.Click += new System.EventHandler(this.linkToCategoryToolStripMenuItem_Click);
            // 
            // addCopiesToolStripMenuItem
            // 
            this.addCopiesToolStripMenuItem.Name = "addCopiesToolStripMenuItem";
            this.addCopiesToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.addCopiesToolStripMenuItem.Text = "Add Copies";
            this.addCopiesToolStripMenuItem.Click += new System.EventHandler(this.addCopiesToolStripMenuItem_Click);
            // 
            // seePiblisherDetailsToolStripMenuItem
            // 
            this.seePiblisherDetailsToolStripMenuItem.Name = "seePiblisherDetailsToolStripMenuItem";
            this.seePiblisherDetailsToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.seePiblisherDetailsToolStripMenuItem.Text = "See piblisher details";
            // 
            // manageThisBookToolStripMenuItem
            // 
            this.manageThisBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.updateThisBookToolStripMenuItem,
            this.deleteThisBookToolStripMenuItem});
            this.manageThisBookToolStripMenuItem.Name = "manageThisBookToolStripMenuItem";
            this.manageThisBookToolStripMenuItem.Size = new System.Drawing.Size(271, 28);
            this.manageThisBookToolStripMenuItem.Text = "Manage this Book";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // updateThisBookToolStripMenuItem
            // 
            this.updateThisBookToolStripMenuItem.Name = "updateThisBookToolStripMenuItem";
            this.updateThisBookToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.updateThisBookToolStripMenuItem.Text = "Update this book";
            this.updateThisBookToolStripMenuItem.Click += new System.EventHandler(this.updateThisBookToolStripMenuItem_Click);
            // 
            // deleteThisBookToolStripMenuItem
            // 
            this.deleteThisBookToolStripMenuItem.Name = "deleteThisBookToolStripMenuItem";
            this.deleteThisBookToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.deleteThisBookToolStripMenuItem.Text = "Delete this book";
            this.deleteThisBookToolStripMenuItem.Click += new System.EventHandler(this.deleteThisBookToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Books";
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.contextMenuStrip1;
            this.ctrlBookListing1.Location = new System.Drawing.Point(2, 74);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 2;
            this.ctrlBookListing1.OnRowSelected += new System.EventHandler<LibraryLogicLayer.SelectionChangedEventsArgs>(this.ctrlBookListing1_OnRowSelected);
            this.ctrlBookListing1.Load += new System.EventHandler(this.ctrlBookListing1_Load);
            // 
            // frmBooksListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 723);
            this.Controls.Add(this.ctrlBookListing1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBooksListing";
            this.Text = "Books Listing";
            this.Load += new System.EventHandler(this.frmBooksListing_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seeDetailsToolStripMenuItem;
        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.ToolStripMenuItem showAvailableCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forThisBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seePiblisherDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageThisBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateThisBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisBookToolStripMenuItem;
    }
}