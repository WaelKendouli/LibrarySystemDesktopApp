using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsFinesDTO
    {
      public int ID { get; set; }
      public int BorrowingID { get; set; }

        public int UserID { get; set; }

        public double FineAmount { get; set; }

        public clsFinesDTO(int iD, int borrowingID, int userID, double fineAmount)
        {
            ID = iD;
            BorrowingID = borrowingID;
            UserID = userID;
            FineAmount = fineAmount;
        }
    }
}
