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
    public partial class frmReservationHistory : Form
    {
        public frmReservationHistory()
        {
            InitializeComponent();
        }
        int ReservationID = -1;
        private void frmReservationHistory_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsReservation.ShowMyReservations(clsCurrentUser.CurrentUserInfo.ID));
        }

        private void ctrlBookListing1_OnRowSelected(object sender, SelectionChangedEventsArgs e)
        {
            ReservationID = e.ID_OfSelectedRow;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            frmReserve frm = new frmReserve();
            frm.ShowDialog();
            ctrlBookListing1.LoadData(clsReservation.ShowMyReservations(clsCurrentUser.CurrentUserInfo.ID));

        }
    }
}
