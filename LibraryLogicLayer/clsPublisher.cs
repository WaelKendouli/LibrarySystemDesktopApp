using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsPublisher
    {
        enum enMode { Add = 1 , Update = 2}
        enMode _Mode = enMode.Add;
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
        private clsPublisher( string name, string websiteURL, string email,
                           string phoneNumber, string city, string country, bool isActive, string photoPath)
        {
            _Mode = enMode.Update;
            Name = name;
            WebsiteURL = websiteURL;
            Email = email;
            PhoneNumber = phoneNumber;
            City = city;
            Country = country;
            IsActive = isActive;
            PhotoPath = photoPath;
        }
        public clsPublisher()
        {
            _Mode = enMode.Add;
            PublisherID = -1;
            Name = string.Empty;
            WebsiteURL = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            City = string.Empty;
            Country = string.Empty;
            IsActive = true;
            PhotoPath = string.Empty;
        }

        private clsPublisher(int PublisherID,string name, string websiteURL, string email,
                          string phoneNumber, string city, string country, bool isActive, string photoPath)
        {
            _Mode = enMode.Update;
            this.PublisherID = PublisherID;
            Name = name;
            WebsiteURL = websiteURL;
            Email = email;
            PhoneNumber = phoneNumber;
            City = city;
            Country = country;
            IsActive = isActive;
            PhotoPath = photoPath;
        }

        public static DataTable GetPublishersList()
        {
            return clsPublishersDataAccess.GetPublishersList();
        }
         bool _UpdatePublisher()
        {
            return clsPublishersDataAccess.UpdatePublisher(this.PublisherID, this.Name, this.WebsiteURL, this.Email, this.PhoneNumber, this.City, this.Country, this.PhotoPath);
        }

        bool _AddNewPublisher()
        {
            this.PublisherID =  clsPublishersDataAccess.AddNewPublisher( this.Name, this.WebsiteURL, this.Email, this.PhoneNumber, this.City, this.Country, this.PhotoPath);
            return this.PublisherID > 0;
        }

        public static clsPublisher FindPublisherByID(int PublisherID)
        {
            clsPublisherDTO DTO = clsPublishersDataAccess.FindPublisherByID(PublisherID);
            return new clsPublisher(DTO.PublisherID, DTO.Name, DTO.WebsiteURL, DTO.Email, DTO.PhoneNumber, DTO.City, DTO.Country, DTO.IsActive, DTO.PhotoPath);
        }

        public static bool AssociatePublisherWithAuthor(int PublisherID, int AuthorID)
        {
            return clsPublishersDataAccess.AssociatePublisherWithAuthor(PublisherID, AuthorID) > 0;
        }

        public static bool AssociatePublisherWithBook(int PublisherID,int BookID)
        {
            return clsPublishersDataAccess.AssociatePublisherWithBook(PublisherID,BookID) > 0;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewPublisher())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdatePublisher();
            }
            return false;
        }

    }
}
