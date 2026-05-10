using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsPublisherDTO
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string WebsiteURL { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public string PhotoPath { get; set; }

        // Public Constructor
        public clsPublisherDTO(int PublishID,string name, string websiteURL, string email,
                           string phoneNumber, string city, string country, bool isActive, string photoPath)
        {
            this.PublisherID = PublishID;
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
