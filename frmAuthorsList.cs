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
    public partial class frmAuthorsList : Form
    {
        public frmAuthorsList()
        {
            InitializeComponent();
        }

        private void frmAuthorsList_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsAuthor.GetListOfAuthors(),null,180);
        }

        private void addWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssociateWorkWithAuthor frm = new frmAssociateWorkWithAuthor(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }

        private void updateAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveAuthorInfos frm = new frmSaveAuthorInfos(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }
    }
}
