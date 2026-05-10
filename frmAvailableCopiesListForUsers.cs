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
    public partial class frmAvailableCopiesListForUsers : Form
    {
        public frmAvailableCopiesListForUsers()
        {
            InitializeComponent();
        }

        private void frmAvailableCopiesListForUsers_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsBook.GetAllAvailableCopies(),null,200);
        }
    }
}
