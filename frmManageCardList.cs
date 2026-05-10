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
    public partial class frmManageCardList : Form
    {
        public frmManageCardList()
        {
            InitializeComponent();
        }

        private void frmManageCardList_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsCard.GetCardsList() , null , 120); 
        }

        private void updateThisCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaveCardInfo frm = new frmSaveCardInfo(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsCard.GetCardsList(), null, 120);
        }
    }
}
