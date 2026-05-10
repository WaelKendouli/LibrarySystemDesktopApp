namespace LibrarySystemApp
{
    partial class frmReturnBookAdm
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
            this.ctrlCopyBookInfo1 = new LibrarySystemApp.ctrlCopyBookInfo();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbPenalties = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReturningDate = new System.Windows.Forms.DateTimePicker();
            this.chkDameged = new System.Windows.Forms.CheckBox();
            this.chkLate = new System.Windows.Forms.CheckBox();
            this.gbPenalties.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlCopyBookInfo1
            // 
            this.ctrlCopyBookInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlCopyBookInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlCopyBookInfo1.Name = "ctrlCopyBookInfo1";
            this.ctrlCopyBookInfo1.Size = new System.Drawing.Size(1085, 691);
            this.ctrlCopyBookInfo1.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Navy;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(1109, 449);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(273, 83);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gbPenalties
            // 
            this.gbPenalties.Controls.Add(this.chkLate);
            this.gbPenalties.Controls.Add(this.chkDameged);
            this.gbPenalties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPenalties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbPenalties.Location = new System.Drawing.Point(1109, 123);
            this.gbPenalties.Name = "gbPenalties";
            this.gbPenalties.Size = new System.Drawing.Size(273, 174);
            this.gbPenalties.TabIndex = 2;
            this.gbPenalties.TabStop = false;
            this.gbPenalties.Text = "Select Penalty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1104, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Returning date";
            // 
            // dtpReturningDate
            // 
            this.dtpReturningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturningDate.Location = new System.Drawing.Point(1109, 373);
            this.dtpReturningDate.Name = "dtpReturningDate";
            this.dtpReturningDate.Size = new System.Drawing.Size(241, 30);
            this.dtpReturningDate.TabIndex = 4;
            // 
            // chkDameged
            // 
            this.chkDameged.AutoSize = true;
            this.chkDameged.Location = new System.Drawing.Point(24, 36);
            this.chkDameged.Name = "chkDameged";
            this.chkDameged.Size = new System.Drawing.Size(110, 24);
            this.chkDameged.TabIndex = 0;
            this.chkDameged.Text = "Damaged";
            this.chkDameged.UseVisualStyleBackColor = true;
            this.chkDameged.CheckedChanged += new System.EventHandler(this.chkDameged_CheckedChanged);
            this.chkDameged.Click += new System.EventHandler(this.chkDameged_Click);
            // 
            // chkLate
            // 
            this.chkLate.AutoSize = true;
            this.chkLate.Location = new System.Drawing.Point(24, 93);
            this.chkLate.Name = "chkLate";
            this.chkLate.Size = new System.Drawing.Size(154, 24);
            this.chkLate.TabIndex = 1;
            this.chkLate.Text = "Late returining";
            this.chkLate.UseVisualStyleBackColor = true;
            this.chkLate.CheckedChanged += new System.EventHandler(this.chkLate_CheckedChanged);
            this.chkLate.Click += new System.EventHandler(this.chkLate_Click);
            // 
            // frmReturnBookAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 737);
            this.Controls.Add(this.dtpReturningDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPenalties);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ctrlCopyBookInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReturnBookAdm";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturnBookAdm_Load);
            this.gbPenalties.ResumeLayout(false);
            this.gbPenalties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlCopyBookInfo ctrlCopyBookInfo1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox gbPenalties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReturningDate;
        private System.Windows.Forms.CheckBox chkLate;
        private System.Windows.Forms.CheckBox chkDameged;
    }
}