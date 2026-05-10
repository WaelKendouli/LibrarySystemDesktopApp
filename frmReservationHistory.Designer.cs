namespace LibrarySystemApp
{
    partial class frmReservationHistory
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
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.Location = new System.Drawing.Point(12, 126);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            this.ctrlBookListing1.OnRowSelected += new System.EventHandler<LibraryLogicLayer.SelectionChangedEventsArgs>(this.ctrlBookListing1_OnRowSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "User\'s Rservation history";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.Navy;
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(1008, 149);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(296, 59);
            this.btnAddReservation.TabIndex = 2;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // frmReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 770);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReservationHistory";
            this.Text = "Reservation History";
            this.Load += new System.EventHandler(this.frmReservationHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddReservation;
    }
}