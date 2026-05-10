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
    public partial class frmListOfFinesForUsers : Form
    {
        int _UserID = -1;
        public frmListOfFinesForUsers(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmListOfFinesForUsers_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsFine.GetFineListForUser(_UserID));
        }
    }
}
