using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer;
namespace LibrarySystemApp
{
    public partial class frmAuthorsWorksList : Form
    {
        public frmAuthorsWorksList()
        {
            InitializeComponent();
        }

        private void frmAuthorsWorksList_Load(object sender, EventArgs e)
        {
            ctrlBookListing1.LoadData(clsAuthor.GetAuthorsWork(), new List<string> { "Edition" });
        }
    }
}
