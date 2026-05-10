using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccess;
namespace LibraryLogicLayer
{
    public class clsCard
    {
        public int CardID { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime ExperiationDate { get; set; }
        public int UserID { get; set; }
        public string PhotoLocation { get; set; }
        public bool isActive { get; set; }

        public clsCardDTO CardDTO
        {
            get
            {
                return new clsCardDTO(CardID, MembershipDate, ExperiationDate,
            UserID, PhotoLocation, isActive);
            }
        }

        public clsCard(int cardID, DateTime membershipDate, DateTime experiationDate, int userID, string photoLocation, bool isActive)
        {
            CardID = cardID;
            MembershipDate = membershipDate;
            ExperiationDate = experiationDate;
            UserID = userID;
            PhotoLocation = photoLocation;
            this.isActive = isActive;
        }

        public static DataTable GetCardsList()
        {
            return clsCardDataAccess.GetCardsList();
        }

        public static bool UpdateCardInfos(int UserID, DateTime ExprDate, DateTime MembershipDate, string PhotoURI, bool IsActive)
        {
            return clsCardDataAccess.UpdateCardInfos(UserID, ExprDate, MembershipDate, PhotoURI, IsActive);
        }

        public static clsCardDTO FindCardByUserID(int UserID)
        {
            return clsCardDataAccess.FindCardByUserID(UserID);
        }


    }
}
