using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccess;
namespace LibraryLogicLayer
{
    public class clsAuthor
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }

        public string SecondName { get; set; }
        public string Name { get { return FirstName + " " + LastName; }}
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string PhotoLocation { get; set; }
        public string Bio { get; set; }

        public clsAuthor(string firstName, string secondName, string thirdName, string lastName, string photoLocation, string bio)
        {
            
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            PhotoLocation = photoLocation;
            Bio = bio;
        }

        public clsAuthor(int AuthorID,string firstName, string secondName, string thirdName, string lastName, string photoLocation, string bio)
        {
            this.AuthorID = AuthorID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            PhotoLocation = photoLocation;
            Bio = bio;
        }

        public static clsAuthor GetAuthorByID(int AuthorID)
        {
            clsAuthorDTO DTO = clsAuthorsDataAccess.GetAuthorDTO_ByID(AuthorID);
            return new clsAuthor( DTO.AuthorID ,DTO.FirstName, DTO.SecondName, DTO.ThirdName, DTO.LastName, DTO.PhotoLocation, DTO.Bio);
        }

        public static DataTable GetListOfAuthors()
        {
            return clsAuthorsDataAccess.GetAuthorsTable();
        }

        public static DataTable GetAuthorsWork()
        {
            return clsAuthorsDataAccess.GetAuthorsWork();
        }
        public bool AddNewAuthor()
        {
            return clsAuthorsDataAccess.AddAuthor(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.PhotoLocation, this.Bio) > 0;
        }
        public static DataTable GetAuthorWorkByID(int AuthorID)
        {
            return clsAuthorsDataAccess.GetAuthorWorkByID(AuthorID);
        }

        public  bool UpdateAuthor()
        {
            return clsAuthorsDataAccess.UpdateAuthor(this.AuthorID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.PhotoLocation, this.Bio);
        }
        public static bool AddWorkToAuthor(int AuthorID, int BookID)
        {
            return clsAuthorsDataAccess.AddWork(AuthorID, BookID) > 0;
        }
    }
}
