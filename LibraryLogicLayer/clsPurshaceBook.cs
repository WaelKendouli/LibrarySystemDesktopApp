
using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsPurshaceBook
    {

        public static bool PurchaseBook(int BookCopyID , int UserID)
        {
            int ID  =  clsPurchaseBooksDataAccess.PurchaseBook(BookCopyID, UserID);
            return ID > 0;
        }
        public static DataTable GetHistoryOfPurchaseOfSepcificUser(int UserID)
        {
            return clsPurchaseBooksDataAccess.GetHistoryOfPurchaseOfSepcificUser(UserID);
        }
    }
}
