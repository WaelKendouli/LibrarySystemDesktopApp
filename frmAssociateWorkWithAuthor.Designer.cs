namespace LibrarySystemApp
{
    partial class frmAssociateWorkWithAuthor
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ctrlAuthorInfo1 = new LibrarySystemApp.ctrlAuthorInfo();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.associateWithAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.ContextMenuStrip = this.cmsOptions;
            this.dgvBooks.Location = new System.Drawing.Point(979, 101);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(655, 493);
            this.dgvBooks.TabIndex = 1;
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(987, 54);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(218, 37);
            this.cbSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1223, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 34);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ctrlAuthorInfo1
            // 
            this.ctrlAuthorInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlAuthorInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAuthorInfo1.Name = "ctrlAuthorInfo1";
            this.ctrlAuthorInfo1.Size = new System.Drawing.Size(949, 662);
            this.ctrlAuthorInfo1.TabIndex = 0;
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associateWithAuthorToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(221, 56);
            // 
            // associateWithAuthorToolStripMenuItem
            // 
            this.associateWithAuthorToolStripMenuItem.Name = "associateWithAuthorToolStripMenuItem";
            this.associateWithAuthorToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.associateWithAuthorToolStripMenuItem.Text = "Associate with author";
            this.associateWithAuthorToolStripMenuItem.Click += new System.EventHandler(this.associateWithAuthorToolStripMenuItem_Click);
            // 
            // frmAssociateWorkWithAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1674, 715);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.ctrlAuthorInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssociateWorkWithAuthor";
            this.Text = "Associate work ";
            this.Load += new System.EventHandler(this.frmAssociateWorkWithAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAuthorInfo ctrlAuthorInfo1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem associateWithAuthorToolStripMenuItem;
    }
}