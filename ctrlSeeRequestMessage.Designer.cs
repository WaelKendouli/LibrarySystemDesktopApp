namespace LibrarySystemApp
{
    partial class ctrlSeeRequestMessage
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
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbRequestType = new System.Windows.Forms.Label();
            this.btnReplyToThisRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(32, 243);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(661, 332);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Request Type : ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(211, 136);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 40);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "[????]";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.Location = new System.Drawing.Point(211, 73);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(97, 40);
            this.lbFullName.TabIndex = 6;
            this.lbFullName.Text = "[????]";
            // 
            // lbRequestType
            // 
            this.lbRequestType.AutoSize = true;
            this.lbRequestType.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequestType.Location = new System.Drawing.Point(278, 20);
            this.lbRequestType.Name = "lbRequestType";
            this.lbRequestType.Size = new System.Drawing.Size(97, 40);
            this.lbRequestType.TabIndex = 7;
            this.lbRequestType.Text = "[????]";
            // 
            // btnReplyToThisRequest
            // 
            this.btnReplyToThisRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReplyToThisRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyToThisRequest.ForeColor = System.Drawing.Color.White;
            this.btnReplyToThisRequest.Location = new System.Drawing.Point(439, 170);
            this.btnReplyToThisRequest.Name = "btnReplyToThisRequest";
            this.btnReplyToThisRequest.Size = new System.Drawing.Size(254, 67);
            this.btnReplyToThisRequest.TabIndex = 8;
            this.btnReplyToThisRequest.Text = "Reply to this request";
            this.btnReplyToThisRequest.UseVisualStyleBackColor = false;
            this.btnReplyToThisRequest.Click += new System.EventHandler(this.btnReplyToThisRequest_Click);
            // 
            // ctrlSeeRequestMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReplyToThisRequest);
            this.Controls.Add(this.lbRequestType);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Name = "ctrlSeeRequestMessage";
            this.Size = new System.Drawing.Size(722, 611);
            this.Load += new System.EventHandler(this.ctrlSeeRequestMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbRequestType;
        private System.Windows.Forms.Button btnReplyToThisRequest;
    }
}
