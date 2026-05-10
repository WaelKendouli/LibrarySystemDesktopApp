using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsPasswordConfirmedEventArgs : EventArgs
    {
        public bool PasswordConfirmed { get; } = false;

        public clsPasswordConfirmedEventArgs(bool PasswordConfirmed)
        {
            this.PasswordConfirmed = PasswordConfirmed;
        }
    }
}
