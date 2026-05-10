using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsRequestDTO
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int RequestTypeID { get; set; }
        public int UserID { get; set; }
        public int AdminID { get; set; }

        public clsUserDTO UserDTO { get; set; } = null;
        public clsRequestTypeDTO RequestTypeDTO { get; set; } = null;

        // Parameterized Constructor (without ID - for new requests)
        public clsRequestDTO(int ID,string content, int requestTypeID, int userID, int adminID)
        {
            this.ID = ID;
            Content = content;
            RequestTypeID = requestTypeID;
            RequestTypeDTO = clsRequestsDataAccess.GetRequestTypeDTO_ByID(requestTypeID);
            UserID = userID;
            UserDTO = clsUsersDataAccess.GetUserDTO_ByID(userID);
            AdminID = adminID;
        }
    }
}
