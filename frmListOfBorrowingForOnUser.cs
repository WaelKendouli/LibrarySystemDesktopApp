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
    public partial class frmListOfBorrowingForOnUser : Form
    {
        int _UserID = -1;
        public frmListOfBorrowingForOnUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmListOfBorrowingForOnUser_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsAdmin.GetHistoryOfBorrowingsOfSepcificUser(_UserID));
        }

        private void returnThisBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBookAdm frm = new frmReturnBookAdm(ctrlBookListing1.GetTheFirstValueOfRow(),ctrlBookListing1.GetCustomValueOfRow(5)); // index of UserID is 5
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsAdmin.GetHistoryOfBorrowingsOfSepcificUser(_UserID));

        }
    }
}
