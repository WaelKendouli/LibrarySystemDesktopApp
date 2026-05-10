using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class ClsBackgroundActionForUsers
    {
        public static async Task CheckingTheExpiryDateOfReservations()
        {
            await Task.Run(() => clsReservation.HandleExpiredReservations());
        }

       


    }
}
