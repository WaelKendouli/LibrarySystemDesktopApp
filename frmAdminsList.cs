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
    public partial class frmAdminsList : Form
    {
        public frmAdminsList()
        {
            InitializeComponent();
        }

        private void frmAdminsList_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsRequest.AdminsListToSendRequest() , null , 250);
        }

        private void contactThisAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendRequestToAdmin frm = new frmSendRequestToAdmin(ctrlBookListing1.GetTheFirstValueOfRow(), clsCurrentUser.CurrentUserInfo.ID);
            frm.ShowDialog();
        }

        private void checkRepliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminsReplies frm = new frmAdminsReplies(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }
    }
}
