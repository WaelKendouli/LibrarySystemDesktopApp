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
    public partial class frmCopiesList : Form
    {
        public frmCopiesList()
        {
            InitializeComponent();
        }

        private void frmCopiesList_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsCopyBook.GetAllCopies(), null, 150);
        }

        private void ctrlBookListing1_Load(object sender, EventArgs e)
        {

        }

        private void seeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopyDetails frm = new frmCopyDetails(ctrlBookListing1.GetCustomValueOfRow(8));
            frm.ShowDialog();
        }
    }
}
