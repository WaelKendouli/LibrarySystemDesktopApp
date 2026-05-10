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
    public partial class frmConfirmMyPassword : Form
    {
        public frmConfirmMyPassword()
        {
            InitializeComponent();
        }

        private void ctrlConfirmPassword1_OnPasswordConfirmed(object sender, LibraryLogicLayer.clsPasswordConfirmedEventArgs e)
        {

            frmSaveWalletInfos frm = new frmSaveWalletInfos();
            frm.ShowDialog();
            this.Close();
        }
    }
}
