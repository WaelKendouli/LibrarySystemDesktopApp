namespace LibrarySystemApp
{
    partial class frmSaveCardInfo
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
            this.ctrlSaveCardInfo1 = new LibrarySystemApp.ctrlSaveCardInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlSaveCardInfo1
            // 
            this.ctrlSaveCardInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlSaveCardInfo1.Location = new System.Drawing.Point(29, 96);
            this.ctrlSaveCardInfo1.Name = "ctrlSaveCardInfo1";
            this.ctrlSaveCardInfo1.Size = new System.Drawing.Size(875, 341);
            this.ctrlSaveCardInfo1.TabIndex = 0;
            this.ctrlSaveCardInfo1.OnCardInfosSaved += new System.EventHandler<LibraryLogicLayer.clsCardEventsArgs>(this.ctrlSaveCardInfo1_OnCardInfosSaved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(281, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Card Infos";
            // 
            // frmSaveCardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSaveCardInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveCardInfo";
            this.Text = "frmSaveCardInfo";
            this.Load += new System.EventHandler(this.frmSaveCardInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSaveCardInfo ctrlSaveCardInfo1;
        private System.Windows.Forms.Label label1;
    }
}