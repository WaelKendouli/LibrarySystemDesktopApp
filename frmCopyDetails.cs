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
    public partial class frmCopyDetails : Form
    {
        int _CopyID = -1;
        public frmCopyDetails(int CopyID)
        {
            InitializeComponent();
            _CopyID = CopyID;
        }

        private void frmCopyDetails_Load(object sender, EventArgs e)
        {
            ctrlCopyBookInfo1.FillUserControl(_CopyID);
        }
    }
}
