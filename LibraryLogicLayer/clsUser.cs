using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccess;
namespace LibraryLogicLayer
{
    public class clsUser
    {
        public int ID { get; set; } = -1;
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PIN { get; set; }
        public string Phone { get; set; }
        public int MembershipID { get; set; } = -1;
        public int StatusID { get; set; } = -1;

        public StatusDTO Status { get; set; }
        public MembershipDTO _MembershipDTO { get; set; }
        public clsWallet Wallet { get; set; }
        public clsUserDTO CurrentDTO { get; set; } = new clsUserDTO();
        public clsUser(int iD, string firstName, string secondName, string thirdName, string lastName, string username, string email, string password, string pIN, string phone, int membershipID, int statusID)
        {
            ID = iD;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Username = username;
            Email = email;
            Password = password;
            PIN = pIN;
            Phone = phone;
            MembershipID = membershipID;
            _MembershipDTO = clsMembership.FindMembershipByID(membershipID);
            StatusID = statusID;
            Status = clsStatus.FindStatusByID(statusID);
            Wallet = clsWallet.FindWalletByID(iD);
        }

        public clsUser()
        {
            ID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Username = "";
            Email = "";
            Password = "";
            PIN = "";
            Phone = "";
            MembershipID = -1;
           
            StatusID = -1;
           
        }
        public static clsUserDTO IsUserAuthenticated(string username, string password)
        {
            return clsUsersDataAccess.CheckUserAuthentication(username, password);
        }

        public static bool AddNewUser(string firstName, string secondName, string thirdName, string lastName, string username, string email, string password, string pIN, string phone, int membershipID = 1, int statusID = 1)
        {
            if (clsUsersDataAccess.CheckIfUserExist(username))
            {
                return false;
            }

            int ID = clsUsersDataAccess.AddNewUser(firstName, secondName, thirdName, lastName, username, email, password, pIN, phone, membershipID = 1, statusID = 1);
            return ID != -1;
        }

        public static bool CheckIfUserExist(string username)
        {
            return clsUsersDataAccess.CheckIfUserExist(username);
        }

        public  bool UpdateUserInfo()
        {
            return clsUsersDataAccess.UpdateUser(this.ID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Username, this.Email, this.Password, this.PIN, this.Phone, this.MembershipID, this.StatusID);
        }

        public static DataTable GetUsersListForAdmins()
        {
            return clsUsersDataAccess.GetAllUsers();
        }

        public static bool ChangeUserStatus(int UserID, int StatusID)
        {
            return clsUsersDataAccess.ChangeUserStatus(UserID, StatusID);
        }

        public static DataTable GetBorrowingHistory(int UserID)
        {
            return clsUsersDataAccess.GetUserBorrowingHistory(UserID);
        }

        public static bool ChangePassword(int ID, string NewPassword)
        {
            return clsUsersDataAccess.ChangePassword(ID, NewPassword);
        }
        public static bool IsOldPasswordCorrect(int UserID, string OldPassword)
        {
            return clsUsersDataAccess.IsOldPasswordCorrect( UserID,OldPassword);
        }
        public static clsUser FindUserByID(int ID)
        {
            clsUserDTO dto = clsUsersDataAccess.GetUserDTO_ByID(ID);
            return new clsUser(dto.ID, dto.FirstName, dto.SecondName,
                dto.ThirdName, dto.LastName, dto.Username, dto.Email,
                dto.Password, dto.PIN, dto.Phone, dto.MembershipID, dto.StatusID);
        }

    }
}
