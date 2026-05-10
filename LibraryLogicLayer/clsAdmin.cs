using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsAdmin
    {
        int ID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string SecondName { get; set; }
        string ThirdName { get; set; }
        string LastName { get; set; }

        clsAdminDTO DTO { get { return new clsAdminDTO(this.ID, this.Username, this.Password, FirstName, SecondName, ThirdName, LastName); } }

        public clsAdmin(int iD, string username, string password, string firstName, string secondName, string thirdName, string lastName)
        {
            ID = iD;
            Username = username;
            Password = password;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
        }

        public static clsAdminDTO CheckAuthentication(string UserName, string Password)
        {
            return clsAdminDataAccess.CheckAdminAuthentication(UserName, Password);
        }

        public static DataTable GetHistoryOfBorrowingsForAdmins()
        {
            return clsAdminDataAccess.GetHistoryOfBorrowingsForAdmins();
        }

        public static DataTable GetHistoryOfReservationsForAdmins()
        {
            return clsAdminDataAccess.GetHistoryOfReservationsForAdmins();
        }

        public static DataTable GetHistoryOfBorrowingsOfSepcificUser(int UserID)
        {
            return clsAdminDataAccess.GetHistoryOfBorrowingsOfSepcificUser(UserID);
        }

        public static DataTable GetHistoryOfPurchasesForAdmins()
        {
            return clsAdminDataAccess.GetHistoryOfPurchasesForAdmins();
        }
    }
}
