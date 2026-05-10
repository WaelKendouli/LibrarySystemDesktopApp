using LibraryDataAccess;
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
    public partial class ctrlSeeRequestMessage : UserControl
    {
        public ctrlSeeRequestMessage()
        {
            InitializeComponent();
        }
        clsRequestDTO _DTO; 
        private void ctrlSeeRequestMessage_Load(object sender, EventArgs e)
        {

        }

        public void LoadRequestInfos(clsRequestDTO DTO)
        {
            if (DTO == null)
            {
                return;
            }
            _DTO = DTO;
            lbFullName.Text = DTO.UserDTO.FullName;
            lbRequestType.Text = DTO.RequestTypeDTO.TypeName;
            lbUsername.Text = DTO.UserDTO.Username;
            txtContent.Text = DTO.Content;
        }

        private void btnReplyToThisRequest_Click(object sender, EventArgs e)
        {
            frmSendRequestToAdmin frm = new frmSendRequestToAdmin(clsCurrentUser.CurrentAdminInfo.ID, _DTO.UserDTO.ID);
            frm.ShowDialog();
        }
    }
}
