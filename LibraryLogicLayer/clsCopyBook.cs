using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsCopyBook : clsBook
    {
        public int CopyID { get; set; }
        public string FormatName { get; set; }
        public string StatusName { get; set; }

        public clsCopyBook()
        {
            CopyID = -1;
            FormatName = "";
            StatusName = "";
        }

        public static int NewBorrowID { get; set; } = -1;


        public clsCopyBook(int BookID, string title, string iSBN, DateTime publicationDate,
            string language, int numberOfPages, double price, int edition, string Bio,
            string PhotoURL, int CopyID, string FormatName, string StatusName)
        {
            
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

        public static CopyBookDTO FindFirstAvailableCopyByTitle(string Title, string Format)
        {
            return clsBooksDataAccess.FindFirstAvailableCopy(Title, Format);
        }

        public static CopyBookDTO FindFirstAvailableCopyByID(int BookID, string Format)
        {
            return clsBooksDataAccess.FindFirstAvailableCopy(BookID, Format);
        }

        public static bool BorrowCopy(int UserID, int CopyID, DateTime BorrowingDate, DateTime ReturningDate)
        {
            NewBorrowID = clsBooksDataAccess.BorrowBookCopy(CopyID, UserID, BorrowingDate, ReturningDate);
            return NewBorrowID > 0;
        }

        public static CopyBookDTO FindCopyByID(int CopyID)
        {
            return clsBooksDataAccess.FindCopyByID(CopyID);
        }
        public static bool AddCopies(int NumberOfCopies, int BookID, int FormatID)
        {
            return clsBooksDataAccess.AddCopies(NumberOfCopies, BookID, FormatID);
        }
        public static bool PurchaseCopy(int CopyBookID , int UserID)
        {
            int ID = clsPurchaseBooksDataAccess.PurchaseBook(CopyBookID, UserID);
            return ID != -1;
        }
        public static DataTable GetAllCopies()
        {
            return clsBooksDataAccess.GetAllCopies();
        }
    }
}
