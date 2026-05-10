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
    public partial class ctrlSendRequest : UserControl
    {
        public ctrlSendRequest()
        {
            InitializeComponent();
        }
        Dictionary<string, int> dicRequestTypes = new Dictionary<string, int>();

        int _AdminID = -1;
        int _UserID = -1;
        public void GetAdminAndUsersIDs(int AdminID, int UserID)
        {
            _AdminID = AdminID;
            _UserID = UserID;
        }
        [Category("Custom Events")]
        [Description("Occurs when a request is submitted")]
        public event EventHandler<clsRequestEventArgs> OnSubmitRequest;

        protected virtual void OnRequestSubmitted(clsRequestEventArgs e)
        {
            OnSubmitRequest?.Invoke(this, e);
        }
        private void _LoadRequestTypes()
        {
            dicRequestTypes = clsRequest.GetRequestsTypes();
            if (dicRequestTypes.Count ==0)
            {
                return;
            }
            foreach (var item in dicRequestTypes)
            {
                cbTypes.Items.Add(item.Key);
            }
            cbTypes.SelectedIndex = 0;
        }
        private void ctrlSendRequest_Load(object sender, EventArgs e)
        {
            _LoadRequestTypes();
        }

        private void SendRequest()
        {
            if (_AdminID < 0 || _UserID < 0)
            {
                throw new Exception("Use GetAdminAndUsersIDs function to get the ID out side the user control");
            }

            OnRequestSubmitted(new clsRequestEventArgs(txtContent.Text, dicRequestTypes[cbTypes.SelectedItem.ToString()], _UserID, _AdminID));
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            SendRequest();
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }
    }
}
