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
    public partial class frmReserve : Form
    {
        public frmReserve()
        {
            InitializeComponent();
        }
        int _CopyID = -1;
        clsReservation reservation = null;
        enum enMode { eUpdate , eAdd }
        enMode Mode = enMode.eAdd;
        private void ctrlSearchBook1_OnBookFound(object sender, LibraryLogicLayer.BooksSearchingEventArg e)
        {
            btnReserve.Enabled = (e.CopyBookID != -1);
            _CopyID = e.CopyBookID;
        }

        private void UpdateReservation()
        {
            if (reservation == null)
            {
                return;
            }
            if (reservation.UpdateReservation(_CopyID , dtpEndOfReservation.Value))
            {
                clsDisplayMessage.ShowMessage("Update success", "", MessageBoxIcon.Information);
            }
            else
            {
                clsDisplayMessage.ShowMessage("Update failed", "", MessageBoxIcon.Information);
            }
        }

        private void Reserve()
        {
             reservation = new clsReservation(clsCurrentUser.CurrentUserInfo.ID, _CopyID, DateTime.Now, dtpEndOfReservation.Value);
            btnCancel.Enabled = (reservation != null );
            
            if (Mode == enMode.eUpdate)
            {
                UpdateReservation();
                return;
            }

            if (reservation.Add())
            {
                this.Mode = enMode.eUpdate;
                btnReserve.Text = "Update";
                clsDisplayMessage.ShowMessage("Reservation achived successfully", "", MessageBoxIcon.Information);
            }
            else
            {
                clsDisplayMessage.ShowMessage("Reservation Failed", "", MessageBoxIcon.Error);

            }
        }

        private void frmReserve_Load(object sender, EventArgs e)
        {
            dtpEndOfReservation.MaxDate = DateTime.Now.AddDays(10);
            dtpEndOfReservation.MinDate = DateTime.Now.Date;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve();
        }

        private void CancelThisReservation()
        {
            if (reservation==null)
            {
                clsDisplayMessage.ShowMessage("Reservation failed", "", MessageBoxIcon.Error);
                return;
            }
            if (reservation.CancelThisReservation())
            {
                clsDisplayMessage.ShowMessage("Reservation Cancelled successfully", "", MessageBoxIcon.Information);
            }
            else
            {
                clsDisplayMessage.ShowMessage("Reservation canceling Failed", "", MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelThisReservation();
        }
    }
}
