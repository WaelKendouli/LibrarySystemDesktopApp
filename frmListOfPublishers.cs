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
    public partial class frmListOfPublishers : Form
    {
        public frmListOfPublishers()
        {
            InitializeComponent();
        }

        private void frmListOfPublishers_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsPublisher.GetPublishersList(),null,200);
        }

        private void associateThisPublisherWithAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkPublisher frm = new frmLinkPublisher(ctrlBookListing1.GetTheFirstValueOfRow(), clsAuthor.GetListOfAuthors(), clsPublisher.AssociatePublisherWithAuthor);
            frm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSavePublisherInfo frm = new frmSavePublisherInfo(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }

        private void asociateThisPublisherWithBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkPublisher frm = new frmLinkPublisher(ctrlBookListing1.GetTheFirstValueOfRow(), clsBook.GetAllBooks(), clsPublisher.AssociatePublisherWithBook);
            frm.ShowDialog();
        }
    }
}
