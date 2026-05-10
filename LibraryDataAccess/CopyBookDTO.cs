using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class CopyBookDTO : BookDTO
    {
        public int CopyID { get; set; }
        public string FormatName { get; set; }
        public string StatusName { get; set; }

        public CopyBookDTO()
        {
            CopyID = -1;
            FormatName = "";
            StatusName = "";
        }



        public CopyBookDTO(int BookID, string title, string iSBN, DateTime publicationDate,
            string language, int numberOfPages, double price, int edition, string Bio,
            string PhotoURL, int CopyID, string FormatName, string StatusName)
        {
            this.BookID = BookID;
            this.Title = title;
            this.ISBN = iSBN;
            this.publicationDate = publicationDate;
            this.Language = language;
            this.NumberOfPages = numberOfPages;
            this.Price = price;
            this.Edition = edition;
            this.PhotoURL = string.IsNullOrEmpty(PhotoURL) ? "" : PhotoURL;
            this.Bio = Bio;
            this.CopyID = CopyID;
            this.FormatName = FormatName;
            this.StatusName = StatusName;
        }
        public CopyBookDTO(BookDTO DTO, int CopyID, string FormatName, string StatusName)
        {
            BookID = DTO.BookID;
            Title = DTO.Title;
            ISBN = DTO.ISBN;
            publicationDate = DTO.publicationDate;
            Language = DTO.Language;
            NumberOfPages = DTO.NumberOfPages;
            Price = DTO.Price;
            Edition = DTO.Edition;
            this.Bio = DTO.Bio;
            this.PhotoURL = DTO.PhotoURL;
            this.CopyID = CopyID;
            this.FormatName = FormatName;
            this.StatusName = StatusName;
        }
    }
}
