using LibraryLogicLayer;
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
    public partial class frmViewAuthorWork : Form
    {
        DataTable AuthorsWorkTable;
        int _AuthorID = -1;
        public frmViewAuthorWork(int AuthorID , string AuthorName)
        {
            InitializeComponent();
            //AuthorsWorkTable = clsAuthor.(AuthorID);
            lbAuthor.Text = AuthorName + " Works";
            _AuthorID = AuthorID;
        }

        private void frmViewAuthorWork_Load(object sender, EventArgs e)
        {
            AuthorsWorkTable = clsAuthor.GetAuthorWorkByID(_AuthorID);
            ctrlBookListing1.LoadData(AuthorsWorkTable ,new List<string> { "Price" }); // for numeric values search
        }

        private void ctrlBookListing1_Load(object sender, EventArgs e)
        {

        }
    }
}
