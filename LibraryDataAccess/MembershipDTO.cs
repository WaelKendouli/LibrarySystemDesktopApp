using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class MembershipDTO
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Days { get; set; }

        public MembershipDTO(int iD, string type, int days)
        {
            ID = iD;
            Type = type;
            Days = days;
        }

    }
}
