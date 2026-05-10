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
    public partial class frmListOfPenaltiesForOneUser : Form
    {
        int _UserID = -1;
        public frmListOfPenaltiesForOneUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmListOfPenaltiesForOneUser_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsPenalty.GetListOfPenaltiesForOneUser(_UserID));
        }
    }
}
