using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsCardEventsArgs : EventArgs
    {
        public DateTime MembershipDate { get; }
        public DateTime ExperiationDate { get;  }
        public int UserID { get; }
        public string PhotoLocation { get;  }
        public bool isActive { get;  }

        public clsCardEventsArgs(DateTime membershipDate, DateTime experiationDate, int userID, string photoLocation, bool isActive)
        {
            MembershipDate = membershipDate;
            ExperiationDate = experiationDate;
            UserID = userID;
            PhotoLocation = photoLocation;
            this.isActive = isActive;
        }
    }
}
