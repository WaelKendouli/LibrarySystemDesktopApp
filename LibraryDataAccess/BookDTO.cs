using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class BookDTO
    {
        public int BookID { get; set; } = -1;
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime publicationDate { get; set; } = DateTime.Now;
        public string Language { get; set; }
        public int NumberOfPages { get; set; }
        public double Price { get; set; }
        public int Edition { get; set; }
        public string PhotoURL { get; set; }
        public string Bio { get; set; }

        public BookDTO(int iD, string title, string iSBN, DateTime publicationDate, string language, int numberOfPages, double price, int edition, string Bio, string PhotoURL = "")
        {
            BookID = iD;
            Title = title;
            ISBN = iSBN;
            this.publicationDate = publicationDate;
            Language = language;
            NumberOfPages = numberOfPages;
            Price = price;
            Edition = edition;
            this.PhotoURL = PhotoURL;
            this.Bio = Bio;
        }

        public BookDTO()
        {
            BookID = -1;
            Title = "";
            ISBN = "";
            this.publicationDate = DateTime.Now;
            Language = "";
            NumberOfPages = 0;
            Price = 0;
            Edition = 0;
            this.PhotoURL = PhotoURL;
            this.Bio = "";
        }
    }
}
