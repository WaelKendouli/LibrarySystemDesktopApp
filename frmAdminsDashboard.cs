using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class frmAdminsDashboard : Form
    {
        frmLogin _Log;
        public frmAdminsDashboard(frmLogin Log)
        {
            InitializeComponent();
            _Log = Log;
        }

        private void embershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminsDashboard_Load(object sender, EventArgs e)
        {

        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersListForAdmins frm = new frmUsersListForAdmins();
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveUserInfo frm = new frmSaveUserInfo();
            frm.ShowDialog();
        }

        private void listOfBorrowingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfBorrowingsForAdmins frm = new frmListOfBorrowingsForAdmins();
            frm.ShowDialog();
        }

        private void listOfReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfReservationAdmin frm = new frmListOfReservationAdmin();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseHistoryForAdmin frm = new frmPurchaseHistoryForAdmin();
            frm.ShowDialog();
        }

        private void booksListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooksListing frm = new frmBooksListing();
            frm.ShowDialog();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveBookInfo frm = new frmSaveBookInfo();
            frm.ShowDialog();
        }

        private void addCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCopies frm = new frmAddCopies();
            frm.ShowDialog();
        }

        private void authorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorsList frm = new frmAuthorsList();
            frm.ShowDialog();

        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveAuthorInfos frm = new frmSaveAuthorInfos();
            frm.ShowDialog();
        }

        private void authorsWorkListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorsWorksList frm = new frmAuthorsWorksList();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsCurrentUser.CurrentAdminInfo = null;
            this.Hide();
            if (_Log.Visible == false)
            {
                _Log.Show();
            }
        }

        private void listOfReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfRetumingForAdmins frm = new frmListOfRetumingForAdmins();
            frm.ShowDialog();
        }

        private void penaltiesTypesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPenaltiesTypes frm = new frmShowPenaltiesTypes();
            frm.Show();
        }

        private void copiesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopiesList frm = new frmCopiesList();
            frm.ShowDialog();
        }

        private void addPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSavePublisherInfo frm = new frmSavePublisherInfo();
            frm.ShowDialog();
        }

        private void publisherListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfPublishers frm = new frmListOfPublishers();
            frm.ShowDialog();
        }

        private void manageCardListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCardList frm = new frmManageCardList();
            frm.ShowDialog();
        }

        private void cardsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void requestsBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfRequestsForAdmins frm = new frmListOfRequestsForAdmins();
            frm.ShowDialog();
        }
    }
}
