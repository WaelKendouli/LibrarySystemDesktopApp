using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccess;
namespace LibraryLogicLayer
{
    public class clsWallet
    {
        public int WalletID { get; set; }

        public decimal MoneyAmount { get; set; }

        public int UserID { get; set; }
        private  static clsWalletDTO DTO { get; set; }
        private clsWallet(int walletID, decimal moneyAmount , int userID)
        {
            WalletID = walletID;
            MoneyAmount = moneyAmount;
            UserID = userID;
        }

        public static clsWallet FindWalletByID(int UserID)
        {
            DTO = clsWalletDataAccess.FindWalletByID(UserID);
            if (DTO==null)
            {
                return null;
            }
            return new clsWallet(DTO.WalletID , DTO.MoneyAmount , DTO.UserID);
        }
        public bool UpdateWallet()
        {
            return clsWalletDataAccess.UpdateWallet(this.UserID, this.MoneyAmount);
        }


    }
}
