using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess
{
    public class clsRequestTypeDTO
    {
        public int RequestTypeID { get; set; }
        public string TypeName { get; set; }

        public clsRequestTypeDTO(int requestTypeID, string typeName)
        {
            this.RequestTypeID = requestTypeID;
            this.TypeName = typeName;
        }
    }
}
