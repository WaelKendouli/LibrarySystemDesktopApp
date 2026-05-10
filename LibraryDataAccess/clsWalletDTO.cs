using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsWalletDTO
    {
            public int WalletID { get; set; }

            public decimal MoneyAmount { get; set; }

            public int UserID { get; set; }

            public clsWalletDTO(int walletID, decimal moneyAmount , int UserID)
            {
                WalletID = walletID;
                MoneyAmount = moneyAmount;
                this.UserID = UserID;
            }
        
    }
}
