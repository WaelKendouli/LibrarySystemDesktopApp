namespace LibrarySystemApp
{
    partial class frmSaveAuthorInfos
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
            this.ctrlFillAuthorsInfo1 = new LibrarySystemApp.ctrlFillAuthorsInfo();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(375, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(325, 46);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add New Author";
            // 
            // ctrlFillAuthorsInfo1
            // 
            this.ctrlFillAuthorsInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlFillAuthorsInfo1.Location = new System.Drawing.Point(35, 86);
            this.ctrlFillAuthorsInfo1.Name = "ctrlFillAuthorsInfo1";
            this.ctrlFillAuthorsInfo1.Size = new System.Drawing.Size(1045, 520);
            this.ctrlFillAuthorsInfo1.TabIndex = 0;
            this.ctrlFillAuthorsInfo1.OnAuthorInfosSaved += new System.EventHandler<LibraryLogicLayer.clsAuthorsEventArgs>(this.ctrlFillAuthorsInfo1_OnAuthorInfosSaved);
            // 
            // frmSaveAuthorInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1096, 631);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ctrlFillAuthorsInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveAuthorInfos";
            this.Text = "Save Author Infos";
            this.Load += new System.EventHandler(this.frmSaveAuthorInfos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFillAuthorsInfo ctrlFillAuthorsInfo1;
        private System.Windows.Forms.Label lbTitle;
    }
}