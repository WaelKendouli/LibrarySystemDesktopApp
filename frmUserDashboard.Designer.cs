namespace LibrarySystemApp
{
    partial class frmUserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMyInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myReservationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMyHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMyPenaltiesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfAdminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositMoneyToMyAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMyWalletCurrentInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWallet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWelcom = new System.Windows.Forms.Label();
            this.addNewPaymentMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.borrowToolStripMenuItem,
            this.borrowingHistoryToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.finesToolStripMenuItem,
            this.penalitiesToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.myWalletToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 650);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myCardToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.editMyInfosToolStripMenuItem});
            this.myAccountToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.myAccountToolStripMenuItem.Text = "My Account";
            // 
            // myCardToolStripMenuItem
            // 
            this.myCardToolStripMenuItem.Name = "myCardToolStripMenuItem";
            this.myCardToolStripMenuItem.Size = new System.Drawing.Size(336, 42);
            this.myCardToolStripMenuItem.Text = "My Card";
            this.myCardToolStripMenuItem.Click += new System.EventHandler(this.myCardToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(336, 42);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(336, 42);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // editMyInfosToolStripMenuItem
            // 
            this.editMyInfosToolStripMenuItem.Name = "editMyInfosToolStripMenuItem";
            this.editMyInfosToolStripMenuItem.Size = new System.Drawing.Size(336, 42);
            this.editMyInfosToolStripMenuItem.Text = "Edit My Infos";
            this.editMyInfosToolStripMenuItem.Click += new System.EventHandler(this.editMyInfosToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveABookToolStripMenuItem,
            this.myReservationHistoryToolStripMenuItem});
            this.reservationsToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // reserveABookToolStripMenuItem
            // 
            this.reserveABookToolStripMenuItem.Name = "reserveABookToolStripMenuItem";
            this.reserveABookToolStripMenuItem.Size = new System.Drawing.Size(412, 42);
            this.reserveABookToolStripMenuItem.Text = "Reserve a book";
            this.reserveABookToolStripMenuItem.Click += new System.EventHandler(this.reserveABookToolStripMenuItem_Click);
            // 
            // myReservationHistoryToolStripMenuItem
            // 
            this.myReservationHistoryToolStripMenuItem.Name = "myReservationHistoryToolStripMenuItem";
            this.myReservationHistoryToolStripMenuItem.Size = new System.Drawing.Size(412, 42);
            this.myReservationHistoryToolStripMenuItem.Text = "My Reservation history";
            this.myReservationHistoryToolStripMenuItem.Click += new System.EventHandler(this.myReservationHistoryToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // borrowingHistoryToolStripMenuItem
            // 
            this.borrowingHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMyHistoryToolStripMenuItem});
            this.borrowingHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.borrowingHistoryToolStripMenuItem.Name = "borrowingHistoryToolStripMenuItem";
            this.borrowingHistoryToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.borrowingHistoryToolStripMenuItem.Text = "Borrowing History";
            // 
            // showMyHistoryToolStripMenuItem
            // 
            this.showMyHistoryToolStripMenuItem.Name = "showMyHistoryToolStripMenuItem";
            this.showMyHistoryToolStripMenuItem.Size = new System.Drawing.Size(329, 42);
            this.showMyHistoryToolStripMenuItem.Text = "Show my history";
            this.showMyHistoryToolStripMenuItem.Click += new System.EventHandler(this.showMyHistoryToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAuthorsToolStripMenuItem,
            this.authorsListToolStripMenuItem});
            this.authorsToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // searchAuthorsToolStripMenuItem
            // 
            this.searchAuthorsToolStripMenuItem.Name = "searchAuthorsToolStripMenuItem";
            this.searchAuthorsToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.searchAuthorsToolStripMenuItem.Text = "Search Authors";
            this.searchAuthorsToolStripMenuItem.Click += new System.EventHandler(this.searchAuthorsToolStripMenuItem_Click);
            // 
            // authorsListToolStripMenuItem
            // 
            this.authorsListToolStripMenuItem.Name = "authorsListToolStripMenuItem";
            this.authorsListToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.authorsListToolStripMenuItem.Text = "Authors List";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesListToolStripMenuItem});
            this.categoriesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // categoriesListToolStripMenuItem
            // 
            this.categoriesListToolStripMenuItem.Name = "categoriesListToolStripMenuItem";
            this.categoriesListToolStripMenuItem.Size = new System.Drawing.Size(299, 42);
            this.categoriesListToolStripMenuItem.Text = "Categories List";
            this.categoriesListToolStripMenuItem.Click += new System.EventHandler(this.categoriesListToolStripMenuItem_Click);
            // 
            // finesToolStripMenuItem
            // 
            this.finesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            this.finesToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.finesToolStripMenuItem.Text = "Fines";
            this.finesToolStripMenuItem.Click += new System.EventHandler(this.finesToolStripMenuItem_Click);
            // 
            // penalitiesToolStripMenuItem
            // 
            this.penalitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMyPenaltiesListToolStripMenuItem});
            this.penalitiesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.penalitiesToolStripMenuItem.Name = "penalitiesToolStripMenuItem";
            this.penalitiesToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.penalitiesToolStripMenuItem.Text = "Penalities";
            this.penalitiesToolStripMenuItem.Click += new System.EventHandler(this.penalitiesToolStripMenuItem_Click);
            // 
            // showMyPenaltiesListToolStripMenuItem
            // 
            this.showMyPenaltiesListToolStripMenuItem.Name = "showMyPenaltiesListToolStripMenuItem";
            this.showMyPenaltiesListToolStripMenuItem.Size = new System.Drawing.Size(408, 42);
            this.showMyPenaltiesListToolStripMenuItem.Text = "Show My Penalties List";
            this.showMyPenaltiesListToolStripMenuItem.Click += new System.EventHandler(this.showMyPenaltiesListToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfAdminsToolStripMenuItem});
            this.contactToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // listOfAdminsToolStripMenuItem
            // 
            this.listOfAdminsToolStripMenuItem.Name = "listOfAdminsToolStripMenuItem";
            this.listOfAdminsToolStripMenuItem.Size = new System.Drawing.Size(292, 42);
            this.listOfAdminsToolStripMenuItem.Text = "List of admins";
            this.listOfAdminsToolStripMenuItem.Click += new System.EventHandler(this.listOfAdminsToolStripMenuItem_Click);
            // 
            // myWalletToolStripMenuItem
            // 
            this.myWalletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositMoneyToMyAccountToolStripMenuItem,
            this.showMyWalletCurrentInfosToolStripMenuItem,
            this.addNewPaymentMethodToolStripMenuItem});
            this.myWalletToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.myWalletToolStripMenuItem.Name = "myWalletToolStripMenuItem";
            this.myWalletToolStripMenuItem.Size = new System.Drawing.Size(266, 42);
            this.myWalletToolStripMenuItem.Text = "My wallet";
            this.myWalletToolStripMenuItem.Click += new System.EventHandler(this.myWalletToolStripMenuItem_Click);
            // 
            // depositMoneyToMyAccountToolStripMenuItem
            // 
            this.depositMoneyToMyAccountToolStripMenuItem.Name = "depositMoneyToMyAccountToolStripMenuItem";
            this.depositMoneyToMyAccountToolStripMenuItem.Size = new System.Drawing.Size(511, 42);
            this.depositMoneyToMyAccountToolStripMenuItem.Text = "Deposit money to my account ";
            this.depositMoneyToMyAccountToolStripMenuItem.Click += new System.EventHandler(this.depositMoneyToMyAccountToolStripMenuItem_Click);
            // 
            // showMyWalletCurrentInfosToolStripMenuItem
            // 
            this.showMyWalletCurrentInfosToolStripMenuItem.Name = "showMyWalletCurrentInfosToolStripMenuItem";
            this.showMyWalletCurrentInfosToolStripMenuItem.Size = new System.Drawing.Size(511, 42);
            this.showMyWalletCurrentInfosToolStripMenuItem.Text = "Show my wallet current infos";
            this.showMyWalletCurrentInfosToolStripMenuItem.Click += new System.EventHandler(this.showMyWalletCurrentInfosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lbWallet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbWelcom);
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 95);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbWallet
            // 
            this.lbWallet.AutoSize = true;
            this.lbWallet.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWallet.ForeColor = System.Drawing.Color.White;
            this.lbWallet.Location = new System.Drawing.Point(712, 24);
            this.lbWallet.Name = "lbWallet";
            this.lbWallet.Size = new System.Drawing.Size(114, 50);
            this.lbWallet.TabIndex = 2;
            this.lbWallet.Text = "[????] $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your current wallet :";
            // 
            // lbWelcom
            // 
            this.lbWelcom.AutoSize = true;
            this.lbWelcom.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcom.ForeColor = System.Drawing.Color.White;
            this.lbWelcom.Location = new System.Drawing.Point(26, 24);
            this.lbWelcom.Name = "lbWelcom";
            this.lbWelcom.Size = new System.Drawing.Size(129, 50);
            this.lbWelcom.TabIndex = 0;
            this.lbWelcom.Text = "Welcom";
            // 
            // addNewPaymentMethodToolStripMenuItem
            // 
            this.addNewPaymentMethodToolStripMenuItem.Name = "addNewPaymentMethodToolStripMenuItem";
            this.addNewPaymentMethodToolStripMenuItem.Size = new System.Drawing.Size(511, 42);
            this.addNewPaymentMethodToolStripMenuItem.Text = "Add new payment method";
            this.addNewPaymentMethodToolStripMenuItem.Click += new System.EventHandler(this.addNewPaymentMethodToolStripMenuItem_Click);
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserDashboard";
            this.Text = "Main Dashboard";
            this.Load += new System.EventHandler(this.frmUserDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMyHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myReservationHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMyInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMyPenaltiesListToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWelcom;
        private System.Windows.Forms.Label lbWallet;
        private System.Windows.Forms.ToolStripMenuItem listOfAdminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myWalletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositMoneyToMyAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMyWalletCurrentInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPaymentMethodToolStripMenuItem;
    }
}