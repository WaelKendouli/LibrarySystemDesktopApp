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
    public partial class frmListOfAllCopiesForOneBook : Form
    {
        int _BookID = -1;
        public frmListOfAllCopiesForOneBook(int bookID)
        {
            InitializeComponent();
            _BookID = bookID;
        }
       


        private void frmListOfAllCopiesForOneBook_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsBook.GetAllCopiesForOneBook(_BookID));
        }

        private void borrowThisCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowBook frm = new frmBorrowBook(_BookID);
            frm.ShowDialog();
        }

        private void buyThisCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseBook frm = new frmPurchaseBook(_BookID);
            frm.ShowDialog();
        }
    }
}
