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
    public partial class frmUserCard : Form
    {
        public frmUserCard()
        {
            InitializeComponent();
        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void clsUserCard_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadCardInformations();
        }
    }
}
