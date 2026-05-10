namespace LibrarySystemApp
{
    partial class frmUsersListForAdmins
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseThisUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendThisUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPremiumSubscribtionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disactivateThisUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBookListing1 = new LibrarySystemApp.ctrlBookListing();
            this.showPenaltiesForThisUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(525, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users List";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Navy;
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(1051, 75);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(251, 63);
            this.btnAddNewUser.TabIndex = 2;
            this.btnAddNewUser.Text = "Add new user";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // cmsOptions
            // 
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserInfoToolStripMenuItem,
            this.banUserToolStripMenuItem,
            this.releaseThisUserToolStripMenuItem,
            this.suspendThisUserToolStripMenuItem,
            this.addToPremiumSubscribtionsToolStripMenuItem,
            this.disactivateThisUserToolStripMenuItem,
            this.manageRToolStripMenuItem,
            this.showPenaltiesForThisUserToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(322, 224);
            // 
            // updateUserInfoToolStripMenuItem
            // 
            this.updateUserInfoToolStripMenuItem.Name = "updateUserInfoToolStripMenuItem";
            this.updateUserInfoToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.updateUserInfoToolStripMenuItem.Text = "Update user info";
            this.updateUserInfoToolStripMenuItem.Click += new System.EventHandler(this.updateUserInfoToolStripMenuItem_Click);
            // 
            // banUserToolStripMenuItem
            // 
            this.banUserToolStripMenuItem.Name = "banUserToolStripMenuItem";
            this.banUserToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.banUserToolStripMenuItem.Text = "Ban user";
            this.banUserToolStripMenuItem.Click += new System.EventHandler(this.banUserToolStripMenuItem_Click);
            // 
            // releaseThisUserToolStripMenuItem
            // 
            this.releaseThisUserToolStripMenuItem.Name = "releaseThisUserToolStripMenuItem";
            this.releaseThisUserToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.releaseThisUserToolStripMenuItem.Text = "Release this user";
            this.releaseThisUserToolStripMenuItem.Click += new System.EventHandler(this.releaseThisUserToolStripMenuItem_Click);
            // 
            // suspendThisUserToolStripMenuItem
            // 
            this.suspendThisUserToolStripMenuItem.Name = "suspendThisUserToolStripMenuItem";
            this.suspendThisUserToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.suspendThisUserToolStripMenuItem.Text = "Suspend this user";
            this.suspendThisUserToolStripMenuItem.Click += new System.EventHandler(this.suspendThisUserToolStripMenuItem_Click);
            // 
            // addToPremiumSubscribtionsToolStripMenuItem
            // 
            this.addToPremiumSubscribtionsToolStripMenuItem.Name = "addToPremiumSubscribtionsToolStripMenuItem";
            this.addToPremiumSubscribtionsToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.addToPremiumSubscribtionsToolStripMenuItem.Text = "Add to Premium subscribtions";
            this.addToPremiumSubscribtionsToolStripMenuItem.Click += new System.EventHandler(this.addToPremiumSubscribtionsToolStripMenuItem_Click);
            // 
            // disactivateThisUserToolStripMenuItem
            // 
            this.disactivateThisUserToolStripMenuItem.Name = "disactivateThisUserToolStripMenuItem";
            this.disactivateThisUserToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.disactivateThisUserToolStripMenuItem.Text = "Disactivate this user";
            this.disactivateThisUserToolStripMenuItem.Click += new System.EventHandler(this.disactivateThisUserToolStripMenuItem_Click);
            // 
            // manageRToolStripMenuItem
            // 
            this.manageRToolStripMenuItem.Name = "manageRToolStripMenuItem";
            this.manageRToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.manageRToolStripMenuItem.Text = "Manage Retruned books for this user";
            this.manageRToolStripMenuItem.Click += new System.EventHandler(this.manageRToolStripMenuItem_Click);
            // 
            // ctrlBookListing1
            // 
            this.ctrlBookListing1.BackColor = System.Drawing.Color.White;
            this.ctrlBookListing1.ContextMenuStrip = this.cmsOptions;
            this.ctrlBookListing1.Location = new System.Drawing.Point(12, 144);
            this.ctrlBookListing1.Name = "ctrlBookListing1";
            this.ctrlBookListing1.Size = new System.Drawing.Size(1315, 632);
            this.ctrlBookListing1.TabIndex = 0;
            // 
            // showPenaltiesForThisUserToolStripMenuItem
            // 
            this.showPenaltiesForThisUserToolStripMenuItem.Name = "showPenaltiesForThisUserToolStripMenuItem";
            this.showPenaltiesForThisUserToolStripMenuItem.Size = new System.Drawing.Size(321, 24);
            this.showPenaltiesForThisUserToolStripMenuItem.Text = "Show penalties for this user";
            this.showPenaltiesForThisUserToolStripMenuItem.Click += new System.EventHandler(this.showPenaltiesForThisUserToolStripMenuItem_Click);
            // 
            // frmUsersListForAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 788);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookListing1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsersListForAdmins";
            this.Text = "Users List For Admins";
            this.Load += new System.EventHandler(this.frmUsersListForAdmins_Load);
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlBookListing ctrlBookListing1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem updateUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseThisUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspendThisUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToPremiumSubscribtionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disactivateThisUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPenaltiesForThisUserToolStripMenuItem;
    }
}