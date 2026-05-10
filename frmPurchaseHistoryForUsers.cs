using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer;
namespace LibrarySystemApp
{
    public partial class frmPurchaseHistoryForUsers : Form
    {
        int _UserID = -1;
        public frmPurchaseHistoryForUsers(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmPurchaseHistoryForUsers_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsPurshaceBook.GetHistoryOfPurchaseOfSepcificUser(_UserID));
        }
    }
}
