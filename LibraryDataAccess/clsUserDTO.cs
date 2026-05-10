using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryDataAccess
{
    public class clsUserDTO
    {
        
            public int ID { get; set; } = -1;
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string PIN { get; set; }
            public string Phone { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
            public int MembershipID { get; set; } = -1;
            public int StatusID { get; set; } = -1;

        public clsUserDTO()
        {
            ID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Username = "";
            Email = "";
            Password = "";
            PIN = "";
            Phone = "";
            MembershipID = -1;
            StatusID = -1;
        }
            public clsUserDTO(int iD, string firstName, string secondName, string thirdName, string lastName, string username, string email, string password, string pIN, string phone, int membershipID, int statusID)
            {
                ID = iD;
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
