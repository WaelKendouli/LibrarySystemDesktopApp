namespace LibrarySystemApp
{
    partial class frmAdminsDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminsDashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBorrowingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPurchasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCardListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltiesTypesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsWorkListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.returnsToolStripMenuItem,
            this.cardsToolStripMenuItem,
            this.penaltiesToolStripMenuItem,
            this.embershipsToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.publishersToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.requestsBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(232, 638);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersListToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.listOfBorrowingsToolStripMenuItem,
            this.listOfReservationsToolStripMenuItem,
            this.listOfPurchasesToolStripMenuItem,
            this.listOfPurchasesToolStripMenuItem1});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // usersListToolStripMenuItem
            // 
            this.usersListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.usersListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersListToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            this.usersListToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.usersListToolStripMenuItem.Text = "Users List";
            this.usersListToolStripMenuItem.Click += new System.EventHandler(this.usersListToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // listOfBorrowingsToolStripMenuItem
            // 
            this.listOfBorrowingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listOfBorrowingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfBorrowingsToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.listOfBorrowingsToolStripMenuItem.Name = "listOfBorrowingsToolStripMenuItem";
            this.listOfBorrowingsToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.listOfBorrowingsToolStripMenuItem.Text = "List Of Borrowings";
            this.listOfBorrowingsToolStripMenuItem.Click += new System.EventHandler(this.listOfBorrowingsToolStripMenuItem_Click);
            // 
            // listOfReservationsToolStripMenuItem
            // 
            this.listOfReservationsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listOfReservationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfReservationsToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.listOfReservationsToolStripMenuItem.Name = "listOfReservationsToolStripMenuItem";
            this.listOfReservationsToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.listOfReservationsToolStripMenuItem.Text = "List of reservations";
            this.listOfReservationsToolStripMenuItem.Click += new System.EventHandler(this.listOfReservationsToolStripMenuItem_Click);
            // 
            // listOfPurchasesToolStripMenuItem
            // 
            this.listOfPurchasesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.listOfPurchasesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfPurchasesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.listOfPurchasesToolStripMenuItem.Name = "listOfPurchasesToolStripMenuItem";
            this.listOfPurchasesToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.listOfPurchasesToolStripMenuItem.Text = "List of purchases";
            this.listOfPurchasesToolStripMenuItem.Click += new System.EventHandler(this.listOfPurchasesToolStripMenuItem_Click);
            // 
            // listOfPurchasesToolStripMenuItem1
            // 
            this.listOfPurchasesToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.listOfPurchasesToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfPurchasesToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.listOfPurchasesToolStripMenuItem1.Name = "listOfPurchasesToolStripMenuItem1";
            this.listOfPurchasesToolStripMenuItem1.Size = new System.Drawing.Size(286, 32);
            this.listOfPurchasesToolStripMenuItem1.Text = "List of Purchases";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksListToolStripMenuItem,
            this.copiesListToolStripMenuItem,
            this.addNewBookToolStripMenuItem,
            this.addCopiesToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // booksListToolStripMenuItem
            // 
            this.booksListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.booksListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.booksListToolStripMenuItem.Name = "booksListToolStripMenuItem";
            this.booksListToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.booksListToolStripMenuItem.Text = "Books List";
            this.booksListToolStripMenuItem.Click += new System.EventHandler(this.booksListToolStripMenuItem_Click);
            // 
            // copiesListToolStripMenuItem
            // 
            this.copiesListToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.copiesListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesListToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.copiesListToolStripMenuItem.Name = "copiesListToolStripMenuItem";
            this.copiesListToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.copiesListToolStripMenuItem.Text = "Copies List";
            this.copiesListToolStripMenuItem.Click += new System.EventHandler(this.copiesListToolStripMenuItem_Click);
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addNewBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBookToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.addNewBookToolStripMenuItem.Text = "Add new Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // addCopiesToolStripMenuItem
            // 
            this.addCopiesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addCopiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCopiesToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.addCopiesToolStripMenuItem.Name = "addCopiesToolStripMenuItem";
            this.addCopiesToolStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.addCopiesToolStripMenuItem.Text = "Add Copies";
            this.addCopiesToolStripMenuItem.Click += new System.EventHandler(this.addCopiesToolStripMenuItem_Click);
            // 
            // returnsToolStripMenuItem
            // 
            this.returnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfReturnsToolStripMenuItem});
            this.returnsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.returnsToolStripMenuItem.Name = "returnsToolStripMenuItem";
            this.returnsToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.returnsToolStripMenuItem.Text = "Returns";
            // 
            // listOfReturnsToolStripMenuItem
            // 
            this.listOfReturnsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfReturnsToolStripMenuItem.Name = "listOfReturnsToolStripMenuItem";
            this.listOfReturnsToolStripMenuItem.Size = new System.Drawing.Size(260, 36);
            this.listOfReturnsToolStripMenuItem.Text = "List of returns";
            this.listOfReturnsToolStripMenuItem.Click += new System.EventHandler(this.listOfReturnsToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCardListToolStripMenuItem});
            this.cardsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.cardsToolStripMenuItem.Text = "Cards";
            this.cardsToolStripMenuItem.Click += new System.EventHandler(this.cardsToolStripMenuItem_Click);
            // 
            // manageCardListToolStripMenuItem
            // 
            this.manageCardListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCardListToolStripMenuItem.Name = "manageCardListToolStripMenuItem";
            this.manageCardListToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.manageCardListToolStripMenuItem.Text = "Manage card list";
            this.manageCardListToolStripMenuItem.Click += new System.EventHandler(this.manageCardListToolStripMenuItem_Click);
            // 
            // penaltiesToolStripMenuItem
            // 
            this.penaltiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penaltiesTypesListToolStripMenuItem});
            this.penaltiesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltiesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.penaltiesToolStripMenuItem.Name = "penaltiesToolStripMenuItem";
            this.penaltiesToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.penaltiesToolStripMenuItem.Text = "Penalties";
            // 
            // penaltiesTypesListToolStripMenuItem
            // 
            this.penaltiesTypesListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltiesTypesListToolStripMenuItem.Name = "penaltiesTypesListToolStripMenuItem";
            this.penaltiesTypesListToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.penaltiesTypesListToolStripMenuItem.Text = "Penalties types list";
            this.penaltiesTypesListToolStripMenuItem.Click += new System.EventHandler(this.penaltiesTypesListToolStripMenuItem_Click);
            // 
            // embershipsToolStripMenuItem
            // 
            this.embershipsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipsListToolStripMenuItem});
            this.embershipsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embershipsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.embershipsToolStripMenuItem.Name = "embershipsToolStripMenuItem";
            this.embershipsToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.embershipsToolStripMenuItem.Text = "Memberships";
            this.embershipsToolStripMenuItem.Click += new System.EventHandler(this.embershipsToolStripMenuItem_Click);
            // 
            // membershipsListToolStripMenuItem
            // 
            this.membershipsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipsListToolStripMenuItem.Name = "membershipsListToolStripMenuItem";
            this.membershipsListToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.membershipsListToolStripMenuItem.Text = "Memberships List";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsListToolStripMenuItem,
            this.addNewAuthorToolStripMenuItem,
            this.authorsWorkListToolStripMenuItem});
            this.authorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // authorsListToolStripMenuItem
            // 
            this.authorsListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsListToolStripMenuItem.Name = "authorsListToolStripMenuItem";
            this.authorsListToolStripMenuItem.Size = new System.Drawing.Size(261, 32);
            this.authorsListToolStripMenuItem.Text = "Authors list";
            this.authorsListToolStripMenuItem.Click += new System.EventHandler(this.authorsListToolStripMenuItem_Click);
            // 
            // addNewAuthorToolStripMenuItem
            // 
            this.addNewAuthorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewAuthorToolStripMenuItem.Name = "addNewAuthorToolStripMenuItem";
            this.addNewAuthorToolStripMenuItem.Size = new System.Drawing.Size(261, 32);
            this.addNewAuthorToolStripMenuItem.Text = "Add new Author";
            this.addNewAuthorToolStripMenuItem.Click += new System.EventHandler(this.addNewAuthorToolStripMenuItem_Click);
            // 
            // authorsWorkListToolStripMenuItem
            // 
            this.authorsWorkListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsWorkListToolStripMenuItem.Name = "authorsWorkListToolStripMenuItem";
            this.authorsWorkListToolStripMenuItem.Size = new System.Drawing.Size(261, 32);
            this.authorsWorkListToolStripMenuItem.Text = "Authors Work list";
            this.authorsWorkListToolStripMenuItem.Click += new System.EventHandler(this.authorsWorkListToolStripMenuItem_Click);
            // 
            // publishersToolStripMenuItem
            // 
            this.publishersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPublisherToolStripMenuItem,
            this.publisherListToolStripMenuItem});
            this.publishersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            this.publishersToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.publishersToolStripMenuItem.Text = "Publishers";
            this.publishersToolStripMenuItem.Click += new System.EventHandler(this.publishersToolStripMenuItem_Click);
            // 
            // addPublisherToolStripMenuItem
            // 
            this.addPublisherToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPublisherToolStripMenuItem.Name = "addPublisherToolStripMenuItem";
            this.addPublisherToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.addPublisherToolStripMenuItem.Text = "Add Publisher";
            this.addPublisherToolStripMenuItem.Click += new System.EventHandler(this.addPublisherToolStripMenuItem_Click);
            // 
            // publisherListToolStripMenuItem
            // 
            this.publisherListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherListToolStripMenuItem.Name = "publisherListToolStripMenuItem";
            this.publisherListToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.publisherListToolStripMenuItem.Text = "Publisher list";
            this.publisherListToolStripMenuItem.Click += new System.EventHandler(this.publisherListToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(217, 45);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // requestsBoxToolStripMenuItem
            // 
            this.requestsBoxToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsBoxToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.requestsBoxToolStripMenuItem.Name = "requestsBoxToolStripMenuItem";
            this.requestsBoxToolStripMenuItem.Size = new System.Drawing.Size(217, 42);
            this.requestsBoxToolStripMenuItem.Text = "Requests box";
            this.requestsBoxToolStripMenuItem.Click += new System.EventHandler(this.requestsBoxToolStripMenuItem_Click);
            // 
            // frmAdminsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1316, 638);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminsDashboard";
            this.Text = "Admins Dashboard";
            this.Load += new System.EventHandler(this.frmAdminsDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBorrowingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCopiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfReturnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCardListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltiesTypesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publisherListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfPurchasesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membershipsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsWorkListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsBoxToolStripMenuItem;
    }
}