using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class StatusDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public StatusDTO(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

    }
}
