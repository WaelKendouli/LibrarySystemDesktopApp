using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer.Interfaces
{
    public interface IF_Convertible
    {
        bool Convert(DataTable db, string FileName, string TableName);

        
    }
}
