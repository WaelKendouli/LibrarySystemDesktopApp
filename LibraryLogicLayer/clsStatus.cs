using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsStatus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public clsStatus(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public static StatusDTO FindStatusByID(int ID)
        {
           return clsStatusDataAccess.FindStatusByID(ID);
        }
    }
}
