namespace LibrarySystemApp
{
    partial class frmAddCopiesForBookAfterSearch
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
            this.btnSaveCopies = new System.Windows.Forms.Button();
            this.nudNumberOfCopies = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveCopies
            // 
            this.btnSaveCopies.BackColor = System.Drawing.Color.Navy;
            this.btnSaveCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCopies.ForeColor = System.Drawing.Color.White;
            this.btnSaveCopies.Location = new System.Drawing.Point(51, 293);
            this.btnSaveCopies.Name = "btnSaveCopies";
            this.btnSaveCopies.Size = new System.Drawing.Size(647, 67);
            this.btnSaveCopies.TabIndex = 9;
            this.btnSaveCopies.Text = "Add copies";
            this.btnSaveCopies.UseVisualStyleBackColor = false;
            this.btnSaveCopies.Click += new System.EventHandler(this.btnSaveCopies_Click);
            // 
            // nudNumberOfCopies
            // 
            this.nudNumberOfCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfCopies.Location = new System.Drawing.Point(51, 184);
            this.nudNumberOfCopies.Name = "nudNumberOfCopies";
            this.nudNumberOfCopies.Size = new System.Drawing.Size(406, 45);
            this.nudNumberOfCopies.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Copies :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Format :";
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(226, 39);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(366, 39);
            this.cbFormat.TabIndex = 5;
            // 
            // frmAddCopiesForBookAfterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 379);
            this.Controls.Add(this.btnSaveCopies);
            this.Controls.Add(this.nudNumberOfCopies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCopiesForBookAfterSearch";
            this.Text = "Add Copies For Book After Search";
            this.Load += new System.EventHandler(this.frmAddCopiesForBookAfterSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCopies;
        private System.Windows.Forms.NumericUpDown nudNumberOfCopies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormat;
    }
}