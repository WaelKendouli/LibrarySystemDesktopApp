using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsOnPublisherSavedEventsArgs : EventArgs
    {
        public string Name { get; }
        public string WebsiteURL { get;  }
        public string Email { get;  }
        public string PhoneNumber { get;  }
        public string City { get;  }
        public string Country { get; }
        public bool IsActive { get;  }
        public string PhotoPath { get; }

        public clsOnPublisherSavedEventsArgs(string name, string websiteURL, string email,
                           string phoneNumber, string city,
                           string country, bool isActive, string photoPath)
        {
            Name = name;
            WebsiteURL = websiteURL;
            Email = email;
            PhoneNumber = phoneNumber;
            City = city;
            Country = country;
            IsActive = isActive;
            PhotoPath = photoPath;
        }

    }
}
