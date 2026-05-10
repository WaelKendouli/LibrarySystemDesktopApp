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
    public partial class frmBorrowBook : Form
    {
        public frmBorrowBook()
        {
            InitializeComponent();
        }

        int _CopyBookID = -1;

        public delegate void delRetrieveBorrowingAmount(object sender, double FineAmount);

        public event delRetrieveBorrowingAmount OnFineAmountRetrieved;

        public frmBorrowBook(int BookID)
        {
            InitializeComponent();
            btnBorrow.Enabled = false;
            ctrlSearchBook1.CustomSearch(BookID);
        }

        decimal TotalPenalties = 0;
        double _BookPrice = 0;
        private  void frmBorrowBook_Load(object sender, EventArgs e)
        {
            TotalPenalties = clsPenalty.GetTotalActivePenaltiesForThisUser(clsCurrentUser.CurrentUserInfo.ID);
            if (TotalPenalties>0)
            {
           MessageBox.Show($"please consider that this amount : {TotalPenalties}$ is going to be added to your fines as a penalty", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnBorrow.Enabled = (_CopyBookID != -1);
        }

        private void Borrow()
        {
            if (_CopyBookID == -1)
            {

                MessageBox.Show("Select an existing book first", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            double BorrowingPrice = clsTransactionalCalculations.CalculateBookPriceWithPercentage(_BookPrice);
            if (clsTransactionalCalculations.CheckAccountBalance(clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount,Convert.ToDecimal(BorrowingPrice)) == false ||
                clsTransactionalCalculations.CheckAccountBalance(clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount, TotalPenalties) == false)
            {
                MessageBox.Show("your account balance is not enough ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (clsCopyBook.BorrowCopy(clsCurrentUser.CurrentUserInfo.ID, _CopyBookID, DateTime.Now, DateTime.Now.AddDays(clsCurrentUser.CurrentUserInfo._MembershipDTO.Days)))
            {
                MessageBox.Show($"Borrowed successfully\n expected returning date {DateTime.Now.AddDays(10)}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddFine();
            }
            else
            {
                MessageBox.Show("Book wasn't borrowed successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Borrow();
        }

        private void AddFine()
        {
            double FineAmount = clsTransactionalCalculations.CalculateFineAmountForBorrowingProcess(_BookPrice, TotalPenalties);
            if (clsFine.AddFine(clsCopyBook.NewBorrowID
                   , clsCurrentUser.CurrentUserInfo.ID
                   , FineAmount))
            {
                MessageBox.Show($"Fine added successfully , {FineAmount}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnFineAmountRetrieved?.Invoke(this, FineAmount);
            }
            else
            {
                MessageBox.Show($"Adding borrowing fines failed .", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnFineAmountRetrieved?.Invoke(this, 0);
            }
        }

        private void ctrlSearchBook1_OnBookFound(object sender, BooksSearchingEventArg e)
        {
            btnBorrow.Enabled = false;
            btnBorrow.Enabled = (e.CopyBookID != -1);
            _CopyBookID = e.CopyBookID;
            _BookPrice = e.BookDTO.Price;
            
        }



    }
}
