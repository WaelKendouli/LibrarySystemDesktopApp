using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class SelectionChangedEventsArgs : EventArgs
    {
        public int ID_OfSelectedRow { get; } = -1;

        public SelectionChangedEventsArgs(int iDOfSelectedRow)
        {
            ID_OfSelectedRow = iDOfSelectedRow;
        }
    }
}
