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
    public partial class frmPenaltiesList : Form
    {
        public frmPenaltiesList()
        {
            InitializeComponent();
        }

        private void frmPenaltiesList_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsPenalty.GetListOfPenaltiesForOneUser(clsCurrentUser.CurrentUserInfo.ID));
        }

        private void ctrlBookListing1_Load(object sender, EventArgs e)
        {

        }
    }
}
