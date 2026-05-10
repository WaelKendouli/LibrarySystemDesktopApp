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
    public partial class frmAdminsReplies : Form
    {
        int _AdminID = 0;
        public frmAdminsReplies(int AdminID)
        {
            InitializeComponent();
            _AdminID = AdminID;
        }

        private void frmAdminsReplies_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsRequest.GetAdminRepliesForUser(clsCurrentUser.CurrentUserInfo.ID, _AdminID));
        }
    }
}
