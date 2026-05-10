namespace LibrarySystemApp
{
    partial class frmReserve
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
            this.ctrlSearchBook1 = new LibrarySystemApp.ctrlSearchBookCopy();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dtpEndOfReservation = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSearchBook1
            // 
            this.ctrlSearchBook1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchBook1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSearchBook1.Name = "ctrlSearchBook1";
            this.ctrlSearchBook1.Size = new System.Drawing.Size(1030, 708);
            this.ctrlSearchBook1.TabIndex = 0;
            this.ctrlSearchBook1.OnBookFound += new System.EventHandler<LibraryLogicLayer.BooksSearchingEventArg>(this.ctrlSearchBook1_OnBookFound);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(854, 726);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(188, 72);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dtpEndOfReservation
            // 
            this.dtpEndOfReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndOfReservation.Location = new System.Drawing.Point(694, 441);
            this.dtpEndOfReservation.Name = "dtpEndOfReservation";
            this.dtpEndOfReservation.Size = new System.Drawing.Size(302, 27);
            this.dtpEndOfReservation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select End of reservation date : ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(635, 726);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 72);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 810);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndOfReservation);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.ctrlSearchBook1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReserve";
            this.Text = "frmReserve";
            this.Load += new System.EventHandler(this.frmReserve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlSearchBookCopy ctrlSearchBook1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DateTimePicker dtpEndOfReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}