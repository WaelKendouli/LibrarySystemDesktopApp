namespace LibrarySystemApp
{
    partial class ctrlFillCreditCardData
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGatewayCustomerID = new System.Windows.Forms.TextBox();
            this.txtPaymentMethodToken = new System.Windows.Forms.TextBox();
            this.txtCardType = new System.Windows.Forms.TextBox();
            this.txtHoldName = new System.Windows.Forms.TextBox();
            this.txtBillingPostalCode = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gateway customer ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment method token :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Billing postal code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Card type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Holder name :";
            // 
            // txtGatewayCustomerID
            // 
            this.txtGatewayCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGatewayCustomerID.Location = new System.Drawing.Point(340, 36);
            this.txtGatewayCustomerID.Name = "txtGatewayCustomerID";
            this.txtGatewayCustomerID.Size = new System.Drawing.Size(539, 38);
            this.txtGatewayCustomerID.TabIndex = 5;
            this.txtGatewayCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.txtGatewayCustomerID_Validating);
            // 
            // txtPaymentMethodToken
            // 
            this.txtPaymentMethodToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentMethodToken.Location = new System.Drawing.Point(340, 116);
            this.txtPaymentMethodToken.Name = "txtPaymentMethodToken";
            this.txtPaymentMethodToken.Size = new System.Drawing.Size(539, 38);
            this.txtPaymentMethodToken.TabIndex = 6;
            this.txtPaymentMethodToken.Validating += new System.ComponentModel.CancelEventHandler(this.txtPaymentMethodToken_Validating);
            // 
            // txtCardType
            // 
            this.txtCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardType.Location = new System.Drawing.Point(204, 180);
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.Size = new System.Drawing.Size(420, 38);
            this.txtCardType.TabIndex = 7;
            this.txtCardType.Validating += new System.ComponentModel.CancelEventHandler(this.txtCardType_Validating);
            // 
            // txtHoldName
            // 
            this.txtHoldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoldName.Location = new System.Drawing.Point(250, 243);
            this.txtHoldName.Name = "txtHoldName";
            this.txtHoldName.Size = new System.Drawing.Size(474, 38);
            this.txtHoldName.TabIndex = 8;
            this.txtHoldName.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoldName_Validating);
            // 
            // txtBillingPostalCode
            // 
            this.txtBillingPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillingPostalCode.Location = new System.Drawing.Point(297, 315);
            this.txtBillingPostalCode.Name = "txtBillingPostalCode";
            this.txtBillingPostalCode.Size = new System.Drawing.Size(327, 38);
            this.txtBillingPostalCode.TabIndex = 9;
            this.txtBillingPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtBillingPostalCode_Validating);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Navy;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(723, 315);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(207, 82);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // ctrlFillCreditCardData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBillingPostalCode);
            this.Controls.Add(this.txtHoldName);
            this.Controls.Add(this.txtCardType);
            this.Controls.Add(this.txtPaymentMethodToken);
            this.Controls.Add(this.txtGatewayCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ctrlFillCreditCardData";
            this.Size = new System.Drawing.Size(945, 413);
            this.Load += new System.EventHandler(this.ctrlFillCreditCardData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGatewayCustomerID;
        private System.Windows.Forms.TextBox txtPaymentMethodToken;
        private System.Windows.Forms.TextBox txtCardType;
        private System.Windows.Forms.TextBox txtHoldName;
        private System.Windows.Forms.TextBox txtBillingPostalCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}
