using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDataAccess;
namespace LibraryLogicLayer
{
    public class clsMembership
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Days { get; set; }

        public clsMembership(int iD, string type, int days)
        {
            ID = iD;
            Type = type;
            Days = days;
        }

        public static MembershipDTO FindMembershipByID(int ID)
        {
            return clsMembershipDataAccess.FindMembershipByID(ID);
        }

    }
}
