namespace LibrarySystemApp
{
    partial class frmBorrowBook
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
            this.btnBorrow = new System.Windows.Forms.Button();
            this.ctrlSearchBook1 = new LibrarySystemApp.ctrlSearchBookCopy();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.White;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(774, 727);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(253, 69);
            this.btnBorrow.TabIndex = 1;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // ctrlSearchBook1
            // 
            this.ctrlSearchBook1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchBook1.Location = new System.Drawing.Point(12, 7);
            this.ctrlSearchBook1.Name = "ctrlSearchBook1";
            this.ctrlSearchBook1.Size = new System.Drawing.Size(1033, 708);
            this.ctrlSearchBook1.TabIndex = 0;
            this.ctrlSearchBook1.OnBookFound += new System.EventHandler<LibraryLogicLayer.BooksSearchingEventArg>(this.ctrlSearchBook1_OnBookFound);
            // 
            // frmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 808);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.ctrlSearchBook1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrowBook";
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.frmBorrowBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchBookCopy ctrlSearchBook1;
        private System.Windows.Forms.Button btnBorrow;
    }
}