namespace LibrarySystemApp
{
    partial class frmLinkBookToCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddBookToCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose category";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(305, 65);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(323, 44);
            this.cbCategory.TabIndex = 1;
            // 
            // btnAddBookToCategory
            // 
            this.btnAddBookToCategory.BackColor = System.Drawing.Color.Navy;
            this.btnAddBookToCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookToCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddBookToCategory.Location = new System.Drawing.Point(41, 155);
            this.btnAddBookToCategory.Name = "btnAddBookToCategory";
            this.btnAddBookToCategory.Size = new System.Drawing.Size(447, 78);
            this.btnAddBookToCategory.TabIndex = 2;
            this.btnAddBookToCategory.Text = "choose this category";
            this.btnAddBookToCategory.UseVisualStyleBackColor = false;
            this.btnAddBookToCategory.Click += new System.EventHandler(this.btnAddBookToCategory_Click);
            // 
            // frmLinkBookToCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 245);
            this.Controls.Add(this.btnAddBookToCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinkBookToCategory";
            this.Text = "Link Book To Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLinkBookToCategory_FormClosing);
            this.Load += new System.EventHandler(this.frmLinkBookToCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAddBookToCategory;
    }
}