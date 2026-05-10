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
    public partial class frmBookInfos : Form
    {
        int BookID = -1;
        public frmBookInfos(int bookID)
        {
            InitializeComponent();
            BookID = bookID;
        }

        private void frmBookInfos_Load(object sender, EventArgs e)
        {
            ctrlBookInfos1.LoadInfosByBookID(BookID);
        }


    }
}
