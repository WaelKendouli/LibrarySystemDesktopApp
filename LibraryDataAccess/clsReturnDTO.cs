using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsReturnDTO
    {
        public int ReturnID { get; set; } = -1;
        public int CopyBookID { get; set; }
        public int UserID { get; set; }
        public DateTime UserReturningDate { get; set; }

        public bool IsDamaged { get; set; }
        public bool IsLate { get; set; }
        public int AdminID { get; set; }

        public clsReturnDTO(int CopyBookID, int userID, bool isDamaged, bool isLate, int adminID, DateTime userReturningDate)
        {
            this.CopyBookID = CopyBookID;
            UserID = userID;
            UserReturningDate = userReturningDate;
            IsDamaged = isDamaged;
            IsLate = isLate;
            AdminID = adminID;
        }
    }
}
