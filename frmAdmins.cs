using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class frmAdmins : Form
    {
        frmLogin Login;
        public frmAdmins(frmLogin login)
        {
            InitializeComponent();
            Login = login;
        }

        private void frmAdmins_Load(object sender, EventArgs e)
        {

        }
    }
}
