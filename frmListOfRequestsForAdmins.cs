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
    public partial class frmListOfRequestsForAdmins : Form
    {
        public frmListOfRequestsForAdmins()
        {
            InitializeComponent();
        }

        private void frmListOfRequestsForAdmins_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsRequest.GetListOfRequestsForAdmins(clsCurrentUser.CurrentAdminInfo.ID) ,null,350);
        }

        private void relpyToThisUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecieveRequestFromUsers frm = new frmRecieveRequestFromUsers(ctrlBookListing1.GetTheFirstValueOfRow());
            frm.ShowDialog();
        }
    }
}
