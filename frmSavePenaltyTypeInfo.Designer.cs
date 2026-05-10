namespace LibrarySystemApp
{
    partial class frmShowPenaltiesTypes
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
            this.dgvPenalties = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.txSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenalties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPenalties
            // 
            this.dgvPenalties.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenalties.Location = new System.Drawing.Point(52, 203);
            this.dgvPenalties.Name = "dgvPenalties";
            this.dgvPenalties.RowHeadersWidth = 51;
            this.dgvPenalties.RowTemplate.Height = 24;
            this.dgvPenalties.Size = new System.Drawing.Size(824, 378);
            this.dgvPenalties.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(306, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Penalties List";
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(315, 146);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(252, 39);
            this.cb.TabIndex = 3;
            // 
            // txSearch
            // 
            this.txSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearch.Location = new System.Drawing.Point(52, 149);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(230, 38);
            this.txSearch.TabIndex = 4;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // frmShowPenaltiesTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 607);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPenalties);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowPenaltiesTypes";
            this.Text = "Penalties list";
            this.Load += new System.EventHandler(this.frmShowPenaltiesTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenalties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPenalties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox txSearch;
    }
}