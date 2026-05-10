using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsReservation
    {
        private enum  enMode
        {
        eAdd = 1 , eUpdate = 2            
        }

        enMode _Mode;
        public int ID { get; set; } = -1;
        public int UserID { get; set; }
        public clsUser User { get; set; }
        public int CopyID { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime EndDate { get; set; }



        public clsReservation(int userID, int copyID, DateTime reservationDate, DateTime endDate)
        {
            this._Mode = enMode.eAdd;
            UserID = userID;
            CopyID = copyID;
            ReservationDate = reservationDate;
            EndDate = endDate;
        }

        private clsReservation(int iD, int userID, int copyID, DateTime reservationDate, DateTime endDate)
        {
            ID = iD;
            UserID = userID;
            CopyID = copyID;
            ReservationDate = reservationDate;
            EndDate = endDate;
        }

        private bool _AddReservation( int userID, int copyID, DateTime reservationDate, DateTime endDate)
        {
            this.ID = clsReservationsDataAccess.ReserveBook(reservationDate, copyID, UserID, endDate);
            return this.ID != -1;
        }

        public static DataTable ShowMyReservations(int UserID)
        {
            return clsReservationsDataAccess.GetUserListOfReservations(UserID);
        }

        public static bool CancelReservation(int ReservationID)
        {
            return clsReservationsDataAccess.CancelReservation(ReservationID);
        }

        public  bool UpdateReservation(int CopyID, DateTime reservationEndDate)
        {
            return clsReservationsDataAccess.UpdateReservation(DateTime.Now, CopyID, this.UserID, reservationEndDate);
        }
        public bool CancelThisReservation()
        {
            if (this.ID == -1)
            {
                return false;
            }
            return CancelReservation(this.ID);
        }
        public bool Add()
        {
            return _AddReservation(this.UserID, this.CopyID, this.ReservationDate, this.EndDate);
        }

        public static bool HandleExpiredReservations()
        {
            return clsReservationsDataAccess.HandleExpiredReservations();
        }
    }
}
