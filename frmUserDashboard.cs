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
    public partial class frmUserDashboard : Form
    {
        frmLogin Log;
        public frmUserDashboard(frmLogin log)
        {
            InitializeComponent();
            Log = log;
        }

        private async Task ReservationsChecking()
        {
            reservationsToolStripMenuItem.Enabled = false;
            myReservationHistoryToolStripMenuItem.Enabled = false;

            try
            {
                await ClsBackgroundActionForUsers.CheckingTheExpiryDateOfReservations();
            }
            catch (Exception ex)
            {
                // Handle error
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reservationsToolStripMenuItem.Enabled = true;
                myReservationHistoryToolStripMenuItem.Enabled = true;
            }
        }


        private async void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lbWelcom.Text = $"Welcome {clsCurrentUser.CurrentUserInfo.Username}";
            lbWallet.Text = clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount.ToString() + "$";
           await ReservationsChecking();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooksListing frm = new frmBooksListing();
            frm.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook();
            frm.OnFineAmountRetrieved += OnFineAmountRetrievedAfterBorrowing;
            frm.Show();
        }

        private void myCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCard frm = new frmUserCard();
            frm.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseBook frm = new frmPurchaseBook();
            frm.DataHandler+= OnPurchasePerformed;
            frm.Show();
        }

        private void reserveABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserve frm = new frmReserve();
            frm.Show();
        }

        private void showMyHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowMyBorrowingHistory frm = new frmShowMyBorrowingHistory();
            frm.Show();
        }

        private void myReservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmReservationHistory frm = new frmReservationHistory();
            frm.Show();
        }

        private void categoriesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorizedBookListcs frm = new frmCategorizedBookListcs();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchAuthors frm = new frmSearchAuthors();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            if (Log.Visible==false)
            {
             Log.Show();   
            }
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeMyPassword frm = new frmChangeMyPassword();
            frm.ShowDialog();
        }

        private void editMyInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveUserInfo frm = new frmSaveUserInfo(clsCurrentUser.CurrentUserInfo.ID);
            frm.ShowDialog();
        }

        private void showMyPenaltiesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPenaltiesList frm = new frmPenaltiesList();
            frm.Show();
        }

        private void UpdateMyWalletAfterBorrowing(double FineAmount)
        {
            clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount -= Convert.ToDecimal(FineAmount);
            if (clsCurrentUser.CurrentUserInfo.Wallet.UpdateWallet())
            {
                lbWallet.Text = clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount.ToString();
            }
        }

        private void OnFineAmountRetrievedAfterBorrowing(object sender, double FineAmount)
        {
            UpdateMyWalletAfterBorrowing(FineAmount);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showMyWalletCurrentInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsMyWalletInfo frm = new clsMyWalletInfo();
            frm.ShowDialog();
        }
        
        private void depositMoneyToMyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmMyPassword frm = new frmConfirmMyPassword();
            frm.ShowDialog();
        }

        private void penalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMyWalletAfterPurchase(double Price)
        {
            clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount = clsTransactionalCalculations.CalculatePurchase(clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount ,  Convert.ToDecimal( Price));
            if (clsCurrentUser.CurrentUserInfo.Wallet.UpdateWallet())
            {
                lbWallet.Text = clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount.ToString();
            }
        }
        private void OnPurchasePerformed(object sender, double Price)
        {
            UpdateMyWalletAfterPurchase(Price);
        }

        private void listOfAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminsList frm = new frmAdminsList();
            frm.ShowDialog();
        }

        private void finesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfFinesForUsers frm = new frmListOfFinesForUsers(clsCurrentUser.CurrentUserInfo.ID);
            frm.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewPaymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPaymentMethods frm = new frmAddNewPaymentMethods();
            frm.ShowDialog();
        }
    }
}
