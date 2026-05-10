using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsBookSelectedEventsArgs : EventArgs
    {
        public string Title { get;  }
        public string ISBN { get;  }
        public DateTime publicationDate { get;  } = DateTime.Now;
        public string Language { get; }
        public int NumberOfPages { get;  }
        public double Price { get;  }
        public int Edition { get;  }
        public string PhotoURL { get;  }
        public string Bio { get;  }

        public clsBookSelectedEventsArgs(string title, string iSBN, DateTime publicationDate, string language, int numberOfPages,
            double price, int edition, string photoURL, string bio)
        {
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


    }
}
