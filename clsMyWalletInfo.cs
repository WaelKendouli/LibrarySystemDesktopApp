using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer;
namespace LibrarySystemApp
{
    public partial class clsMyWalletInfo : Form
    {
        public clsMyWalletInfo()
        {
            InitializeComponent();
        }

        private void clsMyWalletInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadData(clsCurrentUser.CurrentUserInfo);
        }
    }
}
