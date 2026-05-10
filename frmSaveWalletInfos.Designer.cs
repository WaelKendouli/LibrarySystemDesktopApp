namespace LibrarySystemApp
{
    partial class frmSaveWalletInfos
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
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlFillCreditCardData1 = new LibrarySystemApp.ctrlFillCreditCardData();
            this.gbTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.btnDeposit);
            this.gbTransaction.Controls.Add(this.label2);
            this.gbTransaction.Controls.Add(this.txtAmount);
            this.gbTransaction.Controls.Add(this.label1);
            this.gbTransaction.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransaction.Location = new System.Drawing.Point(984, 12);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(475, 356);
            this.gbTransaction.TabIndex = 1;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Enter += new System.EventHandler(this.gbTransaction_Enter);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Navy;
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(95, 236);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(323, 78);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(104, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deposit Amount ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(166, 153);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(239, 34);
            this.txtAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(43, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount :";
            // 
            // ctrlFillCreditCardData1
            // 
            this.ctrlFillCreditCardData1.BackColor = System.Drawing.Color.White;
            this.ctrlFillCreditCardData1.Location = new System.Drawing.Point(12, 12);
            this.ctrlFillCreditCardData1.Name = "ctrlFillCreditCardData1";
            this.ctrlFillCreditCardData1.Size = new System.Drawing.Size(938, 413);
            this.ctrlFillCreditCardData1.TabIndex = 0;
            this.ctrlFillCreditCardData1.OnInfosConfirmed += new System.EventHandler<LibraryLogicLayer.clsPaymentMethodEventsArgs>(this.ctrlFillCreditCardData1_OnInfosConfirmed);
            // 
            // frmSaveWalletInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1486, 466);
            this.Controls.Add(this.gbTransaction);
            this.Controls.Add(this.ctrlFillCreditCardData1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveWalletInfos";
            this.Text = "frmSaveWalletInfos";
            this.Load += new System.EventHandler(this.frmSaveWalletInfos_Load);
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlFillCreditCardData ctrlFillCreditCardData1;
        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeposit;
    }
}