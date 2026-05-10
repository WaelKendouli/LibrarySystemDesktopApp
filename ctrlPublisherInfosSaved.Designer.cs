namespace LibrarySystemApp
{
    partial class ctrlPublisherInfosSaved
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
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSetPhoto = new System.Windows.Forms.Button();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.rbIsActive = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(721, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 70);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(17, 63);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(194, 254);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // btnSetPhoto
            // 
            this.btnSetPhoto.BackColor = System.Drawing.Color.Navy;
            this.btnSetPhoto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPhoto.ForeColor = System.Drawing.Color.White;
            this.btnSetPhoto.Location = new System.Drawing.Point(17, 368);
            this.btnSetPhoto.Name = "btnSetPhoto";
            this.btnSetPhoto.Size = new System.Drawing.Size(190, 81);
            this.btnSetPhoto.TabIndex = 2;
            this.btnSetPhoto.Text = "Set Photo";
            this.btnSetPhoto.UseVisualStyleBackColor = false;
            this.btnSetPhoto.Click += new System.EventHandler(this.btnSetPhoto_Click);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(410, 44);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(464, 38);
            this.txtPublisher.TabIndex = 3;
            this.txtPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txtPublisher_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(217, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Publisher :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(238, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(238, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Publisher page :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(238, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(222, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country :";
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Items.AddRange(new object[] {
            "Argentina",
            "Australia",
            "Austria",
            "Algeria",
            "Belgium",
            "Brazil",
            "Canada",
            "Chile",
            "China",
            "Colombia",
            "Croatia",
            "Cuba",
            "Czech Republic",
            "Denmark",
            "Egypt",
            "Finland",
            "France",
            "Germany",
            "Greece",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Italy",
            "Japan",
            "Jordan",
            "Kenya",
            "Lebanon",
            "Malaysia",
            "Mexico",
            "Morocco",
            "Netherlands",
            "New Zealand",
            "Nigeria",
            "Norway",
            "Pakistan",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Saudi Arabia",
            "Serbia",
            "Singapore",
            "South Africa",
            "South Korea",
            "Spain",
            "Sweden",
            "Switzerland",
            "Thailand",
            "Tunisia",
            "Turkey",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Vatican City",
            "Venezuela",
            "Vietnam"});
            this.cbCountries.Location = new System.Drawing.Point(410, 384);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(265, 39);
            this.cbCountries.TabIndex = 12;
            // 
            // rbIsActive
            // 
            this.rbIsActive.AutoSize = true;
            this.rbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIsActive.ForeColor = System.Drawing.Color.Navy;
            this.rbIsActive.Location = new System.Drawing.Point(735, 314);
            this.rbIsActive.Name = "rbIsActive";
            this.rbIsActive.Size = new System.Drawing.Size(158, 36);
            this.rbIsActive.TabIndex = 13;
            this.rbIsActive.TabStop = true;
            this.rbIsActive.Text = "Is Active ";
            this.rbIsActive.UseVisualStyleBackColor = true;
            this.rbIsActive.Click += new System.EventHandler(this.rbIsActive_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(411, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(464, 38);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(491, 176);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(384, 38);
            this.txtURL.TabIndex = 15;
            this.txtURL.Validating += new System.ComponentModel.CancelEventHandler(this.txtURL_Validating);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(346, 243);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(516, 38);
            this.txtCity.TabIndex = 16;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(355, 314);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(368, 38);
            this.txtPhone.TabIndex = 18;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(224, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone :";
            // 
            // ctrlPublisherInfosSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbIsActive);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.btnSetPhoto);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btnSave);
            this.Name = "ctrlPublisherInfosSaved";
            this.Size = new System.Drawing.Size(915, 458);
            this.Load += new System.EventHandler(this.ctrlPublisherInfosSaved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Button btnSetPhoto;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbIsActive;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
    }
}
