namespace LibrarySystemApp
{
    partial class frmAddCopies
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
            this.btnAddCopies = new System.Windows.Forms.Button();
            this.ctrlSearchForBook1 = new LibrarySystemApp.ctrlSearchForBook();
            this.SuspendLayout();
            // 
            // btnAddCopies
            // 
            this.btnAddCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCopies.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCopies.ForeColor = System.Drawing.Color.White;
            this.btnAddCopies.Location = new System.Drawing.Point(781, 799);
            this.btnAddCopies.Name = "btnAddCopies";
            this.btnAddCopies.Size = new System.Drawing.Size(297, 53);
            this.btnAddCopies.TabIndex = 1;
            this.btnAddCopies.Text = "Add new copies";
            this.btnAddCopies.UseVisualStyleBackColor = false;
            this.btnAddCopies.Click += new System.EventHandler(this.btnAddCopies_Click);
            // 
            // ctrlSearchForBook1
            // 
            this.ctrlSearchForBook1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchForBook1.Location = new System.Drawing.Point(12, 21);
            this.ctrlSearchForBook1.Name = "ctrlSearchForBook1";
            this.ctrlSearchForBook1.Size = new System.Drawing.Size(1066, 772);
            this.ctrlSearchForBook1.TabIndex = 2;
            this.ctrlSearchForBook1.OnBookSearched += new System.EventHandler<LibraryLogicLayer.BooksSearchingEventArg>(this.ctrlSearchForBook1_OnBookSearched);
            // 
            // frmAddCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 864);
            this.Controls.Add(this.ctrlSearchForBook1);
            this.Controls.Add(this.btnAddCopies);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCopies";
            this.Text = "Add Copies";
            this.Load += new System.EventHandler(this.frmAddCopies_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddCopies;
        private ctrlSearchForBook ctrlSearchForBook1;
    }
}