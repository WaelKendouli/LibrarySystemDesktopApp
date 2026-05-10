using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsRequestEventArgs : EventArgs
    {
        public string Content { get;  }
        public int RequestTypeID { get; }
        public int UserID { get; }
        public int AdminID { get; }

        public clsRequestEventArgs(string content, int requestTypeID, int userID, int adminID)
        {
            Content = content;
            RequestTypeID = requestTypeID;
            UserID = userID;
            AdminID = adminID;
        }

    }
}
