using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsAuthorsEventArgs : EventArgs
    {
        public string FirstName { get;  }

        public string SecondName { get;  }
        public string Name { get { return FirstName + " " + LastName; } }
        public string ThirdName { get;  }
        public string LastName { get; }
        public string PhotoLocation { get;  }
        public string Bio { get;  }

        public clsAuthorsEventArgs( string firstName, string secondName, string thirdName, string lastName, string photoLocation, string bio)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            PhotoLocation = photoLocation;
            Bio = bio;
        }
    }
}
