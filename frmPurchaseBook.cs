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
    public partial class frmPurchaseBook : Form
    {
        public frmPurchaseBook()
        {
            InitializeComponent();
            btnPuchase.Enabled = false;
        }

        public delegate void PurchaseDataHandler(object sender, double Price);

        public event PurchaseDataHandler DataHandler;

        double _Price = 0;
        public frmPurchaseBook(int BookID)
        {
            InitializeComponent();
            btnPuchase.Enabled = false;
            ctrlSearchBook1.CustomSearch(BookID);
        }
        int _CopyID = -1;
        private void ctrlSearchBook1_OnBookFound(object sender, LibraryLogicLayer.BooksSearchingEventArg e)
        {
            btnPuchase.Enabled = false;
            btnPuchase.Enabled = (e.CopyBookID != -1);
            _CopyID = e.CopyBookID;
            _Price = e.BookDTO.Price;
        }

        private bool CheckAccount()
        {
            return clsTransactionalCalculations.CheckAccountBalance(clsCurrentUser.CurrentUserInfo.Wallet.MoneyAmount, Convert.ToDecimal(_Price));
        }
        private void Purchase()
        {
            if (CheckAccount()==false)
            {
                clsDisplayMessage.ShowMessage("your balance is not valid", "", MessageBoxIcon.Error);
                return;
            }

            if (clsPurshaceBook.PurchaseBook(_CopyID, clsCurrentUser.CurrentUserInfo.CurrentDTO.ID))
            {
                clsDisplayMessage.ShowMessage("Purchasing process success ", "", MessageBoxIcon.Information);
                DataHandler?.Invoke(this, _Price);
            }
            else
            {
                clsDisplayMessage.ShowMessage("Purchasing process failed", "", MessageBoxIcon.Error);
            }
        }
        private void btnPuchase_Click(object sender, EventArgs e)
        {
            Purchase();
        }

        private void frmPurchaseBook_Load(object sender, EventArgs e)
        {
            btnPuchase.Enabled = (_CopyID != -1);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            frmPurchaseHistoryForUsers frm = new frmPurchaseHistoryForUsers(clsCurrentUser.CurrentUserInfo.ID);
            frm.ShowDialog();
        }
    }
}
