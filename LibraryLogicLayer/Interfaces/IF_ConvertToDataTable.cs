using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer.Interfaces
{
    public  interface IF_ConvertToDataTable
    {
        DataTable ConvertToDataTable(string FilePath);
    }
}
