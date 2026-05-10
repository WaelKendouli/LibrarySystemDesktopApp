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
    public partial class frmSendRequestToAdmin : Form
    {
        public frmSendRequestToAdmin(int AdminID , int UserID)
        {
            InitializeComponent();
            ctrlSendRequest1.GetAdminAndUsersIDs(AdminID, UserID);
        }
        clsRequest request = new clsRequest();
        private void frmSendRequestToAdmin_Load(object sender, EventArgs e)
        {

        }

        private void SendRequest(clsRequestEventArgs e)
        {
            request = new clsRequest(e.Content, e.RequestTypeID, e.UserID, e.AdminID);
            if (request.AddNewRequest())
            {
                MessageBox.Show("your request was sent successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("your request wasn't sent", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ctrlSendRequest1_OnSubmitRequest(object sender, clsRequestEventArgs e)
        {
            SendRequest(e);
        }
    }
}
