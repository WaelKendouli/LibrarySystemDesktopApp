using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsCardDTO
    {
        public int CardID { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime ExperiationDate { get; set; }
        public int UserID { get; set; }
        public string PhotoLocation { get; set; }
        public bool isActive { get; set; }

        public clsCardDTO(int cardID, DateTime membershipDate, DateTime experiationDate, int userID, string photoLocation, bool isActive)
        {
            CardID = cardID;
            MembershipDate = membershipDate;
            ExperiationDate = experiationDate;
            UserID = userID;
            PhotoLocation = photoLocation;
            this.isActive = isActive;
        }

    }
}
