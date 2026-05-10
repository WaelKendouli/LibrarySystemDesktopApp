using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsAuthorDTO
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }

        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string PhotoLocation { get; set; }
        public string Bio { get; set; }

        public clsAuthorDTO(int authorID, string firstName, string secondName, string thirdName, string lastName, string photoLocation, string bio)
        {
            AuthorID = authorID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            PhotoLocation = photoLocation;
            Bio = bio;
        }
    }
}
