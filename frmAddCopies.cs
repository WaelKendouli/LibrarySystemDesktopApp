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
    public partial class frmAddCopies : Form
    {
        public frmAddCopies()
        {
            InitializeComponent();
        }
        int _BookID = -1;


        private void btnAddCopies_Click(object sender, EventArgs e)
        {
            if (_BookID==-1)
            {
                return;
            }
            frmAddCopiesForBookAfterSearch frm = new frmAddCopiesForBookAfterSearch(_BookID);
            frm.ShowDialog();
        }

        private void frmAddCopies_Load(object sender, EventArgs e)
        {
            btnAddCopies.Visible = false;
        }

        private void ctrlSearchForBook1_OnBookSearched(object sender, BooksSearchingEventArg e)
        {
            btnAddCopies.Visible = e.BookID != -1;
            _BookID = e.BookID;
        }
    }
}
