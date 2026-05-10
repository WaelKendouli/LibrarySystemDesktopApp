namespace LibrarySystemApp
{
    partial class frmSaveBookInfo
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.ctrlAddBookInfo1 = new LibrarySystemApp.ctrlAddBookInfo();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(450, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(272, 42);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add new Book";
            // 
            // ctrlAddBookInfo1
            // 
            this.ctrlAddBookInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlAddBookInfo1.Location = new System.Drawing.Point(49, 68);
            this.ctrlAddBookInfo1.Name = "ctrlAddBookInfo1";
            this.ctrlAddBookInfo1.Size = new System.Drawing.Size(1082, 603);
            this.ctrlAddBookInfo1.TabIndex = 0;
            this.ctrlAddBookInfo1.OnBookInfosSaved += new System.EventHandler<LibraryLogicLayer.clsBookSelectedEventsArgs>(this.ctrlAddBookInfo1_OnBookInfosSaved);
            // 
            // frmSaveBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 703);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ctrlAddBookInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveBookInfo";
            this.Text = "Save Book Info";
            this.Load += new System.EventHandler(this.frmSaveBookInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddBookInfo ctrlAddBookInfo1;
        private System.Windows.Forms.Label lbTitle;
    }
}