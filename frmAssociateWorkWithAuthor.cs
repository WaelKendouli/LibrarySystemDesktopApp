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
    public partial class frmAssociateWorkWithAuthor : Form
    {
        int _AuthorID = -1;
        public frmAssociateWorkWithAuthor(int AuthorID)
        {
            InitializeComponent();
            ctrlAuthorInfo1.LoadAuthorsInfo(AuthorID);
            dtBooks = clsBook.GetAllBooks();
            _AuthorID = AuthorID;
        }
        DataTable dtBooks = new DataTable();
        private void frmAssociateWorkWithAuthor_Load(object sender, EventArgs e)
        {
            clsCustomDataGridViewUserControl.LoadData(dtBooks, dgvBooks, cbSearch, new List<string> { "Price", "NumberOfPages", "Edition" }, 70);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            clsCustomDataGridViewUserControl.HandleTextBoxChangingEvent(txtSearch, cbSearch, dtBooks);
        }

        private void _AssociateBookWithAuthor()
        {
            if (MessageBox.Show($"Are you sure to add {dgvBooks.CurrentRow.Cells[1].Value.ToString()} to this author ?","")==DialogResult.OK)
            {
                if (clsAuthor.AddWorkToAuthor(_AuthorID, Convert.ToInt32( dgvBooks.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adding failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void associateWithAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AssociateBookWithAuthor();
        }
    }
}
