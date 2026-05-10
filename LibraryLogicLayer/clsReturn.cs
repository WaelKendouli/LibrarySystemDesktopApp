using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsReturn
    {
        public int ReturnID { get; set; } = -1;
       public int CopyBookID { get; set; }
        public int UserID { get; set; }
        public DateTime UserReturningDate { get; set; }

        public bool IsDamaged { get; set; }
        public bool IsLate { get; set; }
        public int AdminID { get; set; }

        public clsReturn(int CopyBookID, int userID, bool isDamaged, bool isLate, int adminID, DateTime userReturningDate)
        {
            this.CopyBookID = CopyBookID;
            UserID = userID;
            UserReturningDate = userReturningDate;
            IsDamaged = isDamaged;
            IsLate = isLate;
            AdminID = adminID;
        }

        public  bool AddBookReturning()
        {
            this.ReturnID = clsReturnBookDataAccess.AddBookReturning(this.CopyBookID, this.UserID, this.IsDamaged, this.IsLate, this.AdminID, this.UserReturningDate);
            return this.ReturnID > 0;
        }
        public static DataTable GetReturnedAllCopies()
        {
            return clsReturnBookDataAccess.GetReturnedAllCopies();
        }
    }
}
