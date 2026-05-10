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
    public partial class frmListOfReservationAdmin : Form
    {
        public frmListOfReservationAdmin()
        {
            InitializeComponent();
        }

        private void frmListOfReservationAdmin_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsAdmin.GetHistoryOfReservationsForAdmins());
        }
    }
}
