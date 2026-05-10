namespace LibrarySystemApp
{
    partial class frmLinkPublisher
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
            this.ctrlPublisherInfo1 = new LibrarySystemApp.ctrlPublisherInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.associateWithThisPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tx = new System.Windows.Forms.TextBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPublisherInfo1
            // 
            this.ctrlPublisherInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlPublisherInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPublisherInfo1.Name = "ctrlPublisherInfo1";
            this.ctrlPublisherInfo1.Size = new System.Drawing.Size(680, 527);
            this.ctrlPublisherInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(740, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Associate this publisher";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.ContextMenuStrip = this.cmsOptions;
            this.dgvList.Location = new System.Drawing.Point(746, 131);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(623, 535);
            this.dgvList.TabIndex = 2;
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associateWithThisPublisherToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(266, 28);
            this.cmsOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOptions_Opening);
            // 
            // associateWithThisPublisherToolStripMenuItem
            // 
            this.associateWithThisPublisherToolStripMenuItem.Name = "associateWithThisPublisherToolStripMenuItem";
            this.associateWithThisPublisherToolStripMenuItem.Size = new System.Drawing.Size(265, 24);
            this.associateWithThisPublisherToolStripMenuItem.Text = "Associate with this publisher";
            this.associateWithThisPublisherToolStripMenuItem.Click += new System.EventHandler(this.associateWithThisPublisherToolStripMenuItem_Click);
            // 
            // tx
            // 
            this.tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx.Location = new System.Drawing.Point(746, 83);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(239, 30);
            this.tx.TabIndex = 3;
            this.tx.TextChanged += new System.EventHandler(this.tx_TextChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(1009, 80);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(271, 33);
            this.cbSearch.TabIndex = 4;
            // 
            // frmLinkPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 693);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPublisherInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinkPublisher";
            this.Text = "frmLinkPublisherWithAuthor";
            this.Load += new System.EventHandler(this.frmLinkPublisherWithAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPublisherInfo ctrlPublisherInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem associateWithThisPublisherToolStripMenuItem;
    }
}