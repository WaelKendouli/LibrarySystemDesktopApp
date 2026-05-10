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
    public partial class frmBooksListing : Form
    {
        public frmBooksListing()
        {
            InitializeComponent();
        }

        int CurrentBookID = -1;

        private void _CheckCredentials()
        {
            linkToCategoryToolStripMenuItem.Enabled = (clsCurrentUser.CurrentAdminInfo != null);
            addCopiesToolStripMenuItem.Enabled = (clsCurrentUser.CurrentAdminInfo != null);
            manageThisBookToolStripMenuItem.Enabled = (clsCurrentUser.CurrentAdminInfo != null);
        }
        private void frmBooksListing_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsBook.GetAllBooks() ,new List<string> { "Price" , "Edition" , "NumberOfPages" });
            _CheckCredentials();
        }

        private void dgvListOfBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookInfos frm = new frmBookInfos(CurrentBookID);
            frm.ShowDialog();
        }

        private void ctrlBookListing1_OnRowSelected(object sender, SelectionChangedEventsArgs e)
        {
            CurrentBookID = e.ID_OfSelectedRow;
        }

        private void forThisBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfAllCopiesForOneBook frm = new frmListOfAllCopiesForOneBook(CurrentBookID);
            frm.ShowDialog();
        }

        private void ctrlBookListing1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void linkToCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkBookToCategory frm = new frmLinkBookToCategory(ctrlBookListing1.GetTheFirstValueOfRow(),true);
            frm.ShowDialog();
        }

        private void allCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvailableCopiesListForUsers frm = new frmAvailableCopiesListForUsers();
            frm.ShowDialog();
        }

        private void addCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCopiesForBookAfterSearch frm = new frmAddCopiesForBookAfterSearch(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveBookInfo frm = new frmSaveBookInfo();
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsBook.GetAllBooks(), new List<string> { "Price", "Edition", "NumberOfPages" });
        }

        private void updateThisBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveBookInfo frm = new frmSaveBookInfo(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsBook.GetAllBooks(), new List<string> { "Price", "Edition", "NumberOfPages" });
        }

        private void deleteThisBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this card ?","warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                if (clsBook.DeleteBook(ctrlBookListing1.GetTheFirstValueOfRow()))
                {
                    MessageBox.Show("Deleted successfully", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("something went wrong", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
