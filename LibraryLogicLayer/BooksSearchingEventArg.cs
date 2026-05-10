using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class BooksSearchingEventArg : EventArgs
    {
        public int CopyBookID { get; } = -1;
        public int BookID { get; } = -1;
        public BookDTO BookDTO { get; } = null;
        public BooksSearchingEventArg(int CopyBookID, int BookID)
        {
            this.CopyBookID = CopyBookID;
            this.BookID = BookID;
            this.BookDTO = clsBook.FindBookByID(BookID);
        }
        public BooksSearchingEventArg(int BookID)
        {
            this.BookID = BookID;
            this.BookDTO = clsBook.FindBookByID(BookID);
        }
    }
}
