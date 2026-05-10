namespace LibrarySystemApp
{
    partial class ctrlCopyBookInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlBookInfos1 = new LibrarySystemApp.ctrlBookInfos();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCopyID = new System.Windows.Forms.Label();
            this.lbFormat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlBookInfos1
            // 
            this.ctrlBookInfos1.BackColor = System.Drawing.Color.White;
            this.ctrlBookInfos1.Location = new System.Drawing.Point(18, 26);
            this.ctrlBookInfos1.Name = "ctrlBookInfos1";
            this.ctrlBookInfos1.Size = new System.Drawing.Size(1010, 576);
            this.ctrlBookInfos1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "CopyID :";
            // 
            // lbCopyID
            // 
            this.lbCopyID.AutoSize = true;
            this.lbCopyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyID.Location = new System.Drawing.Point(196, 639);
            this.lbCopyID.Name = "lbCopyID";
            this.lbCopyID.Size = new System.Drawing.Size(100, 32);
            this.lbCopyID.TabIndex = 2;
            this.lbCopyID.Text = "[????]";
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormat.Location = new System.Drawing.Point(545, 639);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(100, 32);
            this.lbFormat.TabIndex = 4;
            this.lbFormat.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Format :";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(895, 639);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(100, 32);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "[????]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(762, 639);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status :";
            // 
            // ctrlCopyBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCopyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookInfos1);
            this.Name = "ctrlCopyBookInfo";
            this.Size = new System.Drawing.Size(1085, 725);
            this.Load += new System.EventHandler(this.ctrlCopyBookInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookInfos ctrlBookInfos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCopyID;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
    }
}
