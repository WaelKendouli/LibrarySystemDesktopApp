namespace LibrarySystemApp
{
    partial class frmAddNewPaymentMethods
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
            this.ctrlFillCreditCardData1 = new LibrarySystemApp.ctrlFillCreditCardData();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(268, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new Payment method";
            // 
            // ctrlFillCreditCardData1
            // 
            this.ctrlFillCreditCardData1.BackColor = System.Drawing.Color.White;
            this.ctrlFillCreditCardData1.Location = new System.Drawing.Point(28, 87);
            this.ctrlFillCreditCardData1.Name = "ctrlFillCreditCardData1";
            this.ctrlFillCreditCardData1.Size = new System.Drawing.Size(945, 413);
            this.ctrlFillCreditCardData1.TabIndex = 0;
            this.ctrlFillCreditCardData1.OnInfosConfirmed += new System.EventHandler<LibraryLogicLayer.clsPaymentMethodEventsArgs>(this.ctrlFillCreditCardData1_OnInfosConfirmed);
            this.ctrlFillCreditCardData1.Load += new System.EventHandler(this.ctrlFillCreditCardData1_Load);
            // 
            // frmAddNewPaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlFillCreditCardData1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewPaymentMethods";
            this.Text = "frmAddNewPaymentMethods";
            this.Load += new System.EventHandler(this.frmAddNewPaymentMethods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlFillCreditCardData ctrlFillCreditCardData1;
        private System.Windows.Forms.Label label1;
    }
}