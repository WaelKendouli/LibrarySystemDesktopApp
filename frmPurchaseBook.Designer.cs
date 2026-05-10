namespace LibrarySystemApp
{
    partial class frmPurchaseBook
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
            this.btnPuchase = new System.Windows.Forms.Button();
            this.btnPurchaseHistory = new System.Windows.Forms.Button();
            this.ctrlSearchBook1 = new LibrarySystemApp.ctrlSearchBookCopy();
            this.SuspendLayout();
            // 
            // btnPuchase
            // 
            this.btnPuchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPuchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuchase.ForeColor = System.Drawing.Color.White;
            this.btnPuchase.Location = new System.Drawing.Point(795, 735);
            this.btnPuchase.Name = "btnPuchase";
            this.btnPuchase.Size = new System.Drawing.Size(231, 72);
            this.btnPuchase.TabIndex = 1;
            this.btnPuchase.Text = "Purchase";
            this.btnPuchase.UseVisualStyleBackColor = false;
            this.btnPuchase.Click += new System.EventHandler(this.btnPuchase_Click);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.BackColor = System.Drawing.Color.White;
            this.btnPurchaseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseHistory.ForeColor = System.Drawing.Color.Black;
            this.btnPurchaseHistory.Location = new System.Drawing.Point(32, 735);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(322, 72);
            this.btnPurchaseHistory.TabIndex = 2;
            this.btnPurchaseHistory.Text = "Purchase History";
            this.btnPurchaseHistory.UseVisualStyleBackColor = false;
            this.btnPurchaseHistory.Click += new System.EventHandler(this.btnPurchaseHistory_Click);
            // 
            // ctrlSearchBook1
            // 
            this.ctrlSearchBook1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchBook1.Location = new System.Drawing.Point(-7, 12);
            this.ctrlSearchBook1.Name = "ctrlSearchBook1";
            this.ctrlSearchBook1.Size = new System.Drawing.Size(1033, 708);
            this.ctrlSearchBook1.TabIndex = 0;
            this.ctrlSearchBook1.OnBookFound += new System.EventHandler<LibraryLogicLayer.BooksSearchingEventArg>(this.ctrlSearchBook1_OnBookFound);
            // 
            // frmPurchaseBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 810);
            this.Controls.Add(this.btnPurchaseHistory);
            this.Controls.Add(this.btnPuchase);
            this.Controls.Add(this.ctrlSearchBook1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurchaseBook";
            this.Text = "Purchase Book";
            this.Load += new System.EventHandler(this.frmPurchaseBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchBookCopy ctrlSearchBook1;
        private System.Windows.Forms.Button btnPuchase;
        private System.Windows.Forms.Button btnPurchaseHistory;
    }
}