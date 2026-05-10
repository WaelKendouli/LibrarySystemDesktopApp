using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsPenalty
    {
        public static DataTable GetListOfPenaltiesTypes()
        {
            return clsPenaltiesDataAccess.GetListOfPenaltiesTypes();
        }
        public static DataTable GetListOfPenaltiesForOneUser(int UserID)
        {
            return clsPenaltiesDataAccess.GetListOfPenaltiesForOneUser(UserID);
        }

        public static decimal GetTotalActivePenaltiesForThisUser(int UserID)
        {
            return clsPenaltiesDataAccess.GetTotalPenaltyAmountForUser(UserID);
        }

    }
}
