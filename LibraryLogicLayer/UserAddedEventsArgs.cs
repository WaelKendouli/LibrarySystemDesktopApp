using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class UserAddedEventsArgs : EventArgs
    {
       
        public string FirstName { get;  }
        public string SecondName { get;  }
        public string ThirdName { get; }
        public string LastName { get;  }
        public string Username { get;  }
        public string Email { get;  }
        public string Password { get;  }
        public string PIN { get;  }
        public string Phone { get;  }
        public int MembershipID { get;  } = -1;
        public int StatusID { get; } = -1;

        public UserAddedEventsArgs( string firstName, string secondName, string thirdName, string lastName, string username, string email, string password, string pIN, string phone, int membershipID, int statusID)
        {
            
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Username = username;
            Email = email;
            Password = password;
            PIN = pIN;
            Phone = phone;
            MembershipID = membershipID;
            StatusID = statusID;
        }
    }
}
