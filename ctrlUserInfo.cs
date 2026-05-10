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
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }


        public void LoadData(clsUser User)
        {
            if (User != null)
            {
                ctrlUserCard1.LoadCardInformations(User);
                lbFullName.Text = User.FirstName + " " + User.LastName;
                lbMembership.Text = User._MembershipDTO.Type;
                lbMyBalance.Text = User.Wallet.MoneyAmount.ToString();
                lbPhone.Text = User.Phone;
                lbPIN.Text = User.PIN;
                lbWalletID.Text = User.Wallet.WalletID.ToString();
            }
        }
        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
