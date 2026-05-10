using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsFine
    {
        public int ID { get; set; }
        public int BorrowingID { get; set; }

        public int UserID { get; set; }

        public double FineAmount { get; set; }

        public clsFine(int iD, int borrowingID, int userID, double fineAmount)
        {
            ID = iD;
            BorrowingID = borrowingID;
            UserID = userID;
            FineAmount = fineAmount;
        }
        public static bool AddFine(int borrowingID, int userID, double fineAmount)
        {
            return clsFinesDataAccess.AddFine(borrowingID, userID, fineAmount)>0;
        }
        public static DataTable GetFineListForUser(int userId)
        {
            return clsFinesDataAccess.GetFineListForUser(userId);
        }
    }
}
