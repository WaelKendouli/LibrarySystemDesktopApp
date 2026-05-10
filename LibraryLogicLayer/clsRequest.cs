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
    public class clsRequest
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public int RequestTypeID { get; set; }
        public int UserID { get; set; }
        public int AdminID { get; set; }
        public static clsRequestDTO DTO { get; set; }
        // Default Constructor
        public clsRequest()
        {
            
        }

        // Parameterized Constructor (without ID - for new requests)
        public clsRequest(string content, int requestTypeID, int userID, int adminID)
        {
            Content = content;
            RequestTypeID = requestTypeID;
            UserID = userID;
            AdminID = adminID;
        }

        private clsRequest(int ID,string content, int requestTypeID, int userID, int adminID)
        {
            this.ID = ID; 
            Content = content;
            RequestTypeID = requestTypeID;
            UserID = userID;
            AdminID = adminID;
        }

        public static DataTable AdminsListToSendRequest()
        {
            return clsRequestsDataAccess.AdminsListToSendRequest();
        }
        public static Dictionary<string, int> GetRequestsTypes()
        {
            return clsRequestsDataAccess.GetRequestsTypes();
        }
        public  bool AddNewRequest()
        {
            this.ID = clsRequestsDataAccess.AddNewRequest(this.Content, this.RequestTypeID, this.UserID, this.AdminID);
            return this.ID > 0;
        }
        public static DataTable GetAdminRepliesForUser(int userID, int adminID)
        {
            return clsRequestsDataAccess.GetAdminRepliesForUser(userID, adminID);
        }
        public static clsRequestDTO GetRequestDTO_ByID(int RequestID)
        {
            DTO = clsRequestsDataAccess.GetRequestDTO_ByID(RequestID);
            return DTO;
        }
        public static DataTable GetListOfRequestsForAdmins(int AdminID)
        {
            return clsRequestsDataAccess.GetListOfRequestsForAdmins(AdminID);
        }

    }
}
