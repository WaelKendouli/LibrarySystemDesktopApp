namespace LibrarySystemApp
{
    partial class frmSendRequestToAdmin
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
            this.ctrlSendRequest1 = new LibrarySystemApp.ctrlSendRequest();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send a request";
            // 
            // ctrlSendRequest1
            // 
            this.ctrlSendRequest1.BackColor = System.Drawing.Color.White;
            this.ctrlSendRequest1.Location = new System.Drawing.Point(12, 108);
            this.ctrlSendRequest1.Name = "ctrlSendRequest1";
            this.ctrlSendRequest1.Size = new System.Drawing.Size(542, 476);
            this.ctrlSendRequest1.TabIndex = 0;
            this.ctrlSendRequest1.OnSubmitRequest += new System.EventHandler<LibraryLogicLayer.clsRequestEventArgs>(this.ctrlSendRequest1_OnSubmitRequest);
            // 
            // frmSendRequestToAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSendRequest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendRequestToAdmin";
            this.Text = "Send Request To Admin";
            this.Load += new System.EventHandler(this.frmSendRequestToAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSendRequest ctrlSendRequest1;
        private System.Windows.Forms.Label label1;
    }
}