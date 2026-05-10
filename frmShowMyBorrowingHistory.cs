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
    public partial class frmShowMyBorrowingHistory : Form
    {
        public frmShowMyBorrowingHistory()
        {
            InitializeComponent();
        }

        private void frmShowMyBorrowingHistory_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsUser.GetBorrowingHistory(clsCurrentUser.CurrentUserInfo.ID));
        }

        

        private void ctrlBookListing1_OnRowSelected_1(object sender, SelectionChangedEventsArgs e)
        {
            MessageBox.Show(e.ID_OfSelectedRow.ToString());

        }
    }
}
