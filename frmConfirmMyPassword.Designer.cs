namespace LibrarySystemApp
{
    partial class frmConfirmMyPassword
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
            this.ctrlConfirmPassword1 = new LibrarySystemApp.ctrlConfirmPassword();
            this.SuspendLayout();
            // 
            // ctrlConfirmPassword1
            // 
            this.ctrlConfirmPassword1.BackColor = System.Drawing.Color.White;
            this.ctrlConfirmPassword1.Location = new System.Drawing.Point(12, 64);
            this.ctrlConfirmPassword1.Name = "ctrlConfirmPassword1";
            this.ctrlConfirmPassword1.Size = new System.Drawing.Size(765, 388);
            this.ctrlConfirmPassword1.TabIndex = 0;
            this.ctrlConfirmPassword1.OnPasswordConfirmed += new System.EventHandler<LibraryLogicLayer.clsPasswordConfirmedEventArgs>(this.ctrlConfirmPassword1_OnPasswordConfirmed);
            // 
            // frmConfirmMyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 503);
            this.Controls.Add(this.ctrlConfirmPassword1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmMyPassword";
            this.Text = "frmConfirmMyPassword";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlConfirmPassword ctrlConfirmPassword1;
    }
}