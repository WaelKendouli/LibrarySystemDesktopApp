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
    public partial class frmListOfRetumingForAdmins : Form
    {
        public frmListOfRetumingForAdmins()
        {
            InitializeComponent();
        }

        private void ctrlBookListing1_Load(object sender, EventArgs e)
        {

        }

        private void frmListOfRetumingForAdmins_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsReturn.GetReturnedAllCopies(), null, 200);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
