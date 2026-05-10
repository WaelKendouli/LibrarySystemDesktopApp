using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsCurrentUser
    {
        public static clsUser CurrentUserInfo { get; set; } = new clsUser();
        public static clsAdminDTO CurrentAdminInfo { get; set;}

    }
}
