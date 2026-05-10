using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsBook
    {
        enum enMode { eAddNew = 1, eUpdate = 2 }
        private enMode _Mode;
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

        public clsBook()
        {
            _Mode = enMode.eAddNew;
            BookID = -1;
            Title = "";
            ISBN = "";
            publicationDate = DateTime.Now;
            Language = "";
            NumberOfPages = 0;
            Price = 0;
            Edition = 0;
        }

        public clsBook(string title, string iSBN, DateTime publicationDate, string language, int numberOfPages,
            double price, int edition, string photoURL, string bio)
        {
            _Mode = enMode.eAddNew;
            BookID = -1;
            Title = title;
            ISBN = iSBN;
            this.publicationDate = publicationDate;
            Language = language;
            NumberOfPages = numberOfPages;
            Price = price;
            Edition = edition;
            PhotoURL = photoURL;
            Bio = bio;
        }

        public clsBook(int iD, string title, string iSBN, DateTime publicationDate, string language, int numberOfPages, double price, int edition, string photoURL, string bio)
        {
            _Mode = enMode.eUpdate;
            BookID = iD;
            Title = title;
            ISBN = iSBN;
            this.publicationDate = publicationDate;
            Language = language;
            NumberOfPages = numberOfPages;
            Price = price;
            Edition = edition;
            PhotoURL = photoURL;
            Bio = bio;
        }
        

        public BookDTO DTO
        {
            get
            {
                return new BookDTO(this.BookID, Title, ISBN, publicationDate,
            Language, NumberOfPages, Price, Edition, Bio, PhotoURL);
            }
        }

        public static bool DeleteBook(int bookId)
        {
            return clsBooksDataAccess.DeleteBook(bookId);
        }

        public static DataTable GetAllBooks()
        {
            return clsBooksDataAccess.GetListOfBooks();
        }

        public static DataTable GetAllAvailableCopies()
        {
            return clsBooksDataAccess.GetListOfAvailableCopies();
        }

        public static DataTable GetAllCopies()
        {
            return clsBooksDataAccess.GetListOfAllCopies();
        }
        public static BookDTO FindBookByID(int ID)
        {
            BookDTO BDTO = clsBooksDataAccess.FindBookInfoByID(ID);
            return BDTO;
        }

        public static bool AddBookToCategory(int BookID, int CategoryID)

        {
            if (BookID == -1)
            {
                return false;
            }

            return clsBooksDataAccess.AddBookToCategory(BookID, CategoryID);
        }
        private bool _AddNewBook()
        {
            this.BookID = clsBooksDataAccess.AddNewBook(this.Title, ISBN, publicationDate, Language, NumberOfPages, Price, Edition, Bio, PhotoURL);
            return this.BookID != -1;
        }

        private bool _UpdateBookInfo()
        {
            return clsBooksDataAccess.UpdateBook(this.BookID, Title, ISBN, publicationDate,
                Language, NumberOfPages, Price, Edition, PhotoURL, Bio);
        }
        public static BookDTO FindBookInfoByTitle(string Title)
        {
            return clsBooksDataAccess.FindBookInfoByTitle(Title);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.eAddNew:
                    if (_AddNewBook())
                    {
                        _Mode = enMode.eUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.eUpdate:
                    return _UpdateBookInfo();
            }
            return false;
        }
        public void FillNewData(string title, string iSBN, DateTime publicationDate, string language, int numberOfPages,
            double price, int edition, string photoURL, string bio)
        {
            if (this.BookID != -1)
            {
                return;
            }
            Title = title;
            ISBN = iSBN;
            this.publicationDate = publicationDate;
            Language = language;
            NumberOfPages = numberOfPages;
            Price = price;
            Edition = edition;
            PhotoURL = photoURL;
            Bio = bio;
        }


        public bool AddCopy(int NumberOfCopies, int FormatID)
        {
            return clsBooksDataAccess.AddCopies(NumberOfCopies, this.BookID, FormatID);
        }

        public static bool IsThisBookLinkedAlreadyToThisCategory(int BookID, int CategoryID)
        {
            return clsBooksDataAccess.IsThisBookLinkedAlreadyToThisCategory(BookID, CategoryID);
        }


        public static Dictionary<string, int> GetCategories()
        {
            return clsBooksDataAccess.GetAllCategories();
        }

        public static DataTable GetAllCategorizedBook()
        {
            return clsBooksDataAccess.GetCategorizedBooksList();
        }
        public static bool IsThisBookCategorized(int BookID)
        {
            return clsBooksDataAccess.IsThisBookCategorized(BookID);
        }

        public static DataTable GetAllCopiesForOneBook(int BookID)
        {
            return clsBooksDataAccess.GetAllCopiesForOneBook(BookID);
        }

        public static List<BookDTO> GetBooksListForAPI()
        {
            return clsBooksDataAccess.GetBooksListForAPI();
        }


      


        public static List<CopyBookDTO> GetAllCopiesAsDTO()
        {
            return clsBooksDataAccess.GetAllCopiesAsDTO();
        }

        public static List<CopyBookDTO> GetAllCopiesForOneBookAsDTO(int BookID)
        {
            return clsBooksDataAccess.GetAllCopiesForOneBookAsDTO(BookID);
        }

    }
}
