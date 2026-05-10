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
    public partial class frmAddCopiesForBookAfterSearch : Form
    {
        int _BookID = -1;
        public frmAddCopiesForBookAfterSearch(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }
        Dictionary<string, int> dicFormat = new Dictionary<string, int>();

        public void _InitializeUserControl()
        {
            dicFormat.Add("Digital", 1);
            dicFormat.Add("Physical", 2);
            dicFormat.Add("Audio", 3);
            nudNumberOfCopies.Maximum = 100;
            nudNumberOfCopies.Minimum = 0;
            foreach (var item in dicFormat)
            {
                cbFormat.Items.Add(item.Key);
            }
            if (cbFormat.Items.Count>0)
            {
                cbFormat.SelectedIndex = 0;
            }
        }
        private void frmAddCopiesForBookAfterSearch_Load(object sender, EventArgs e)
        {
            _InitializeUserControl();
        }

        private void _SaveCopies()
        {
            if (clsCopyBook.AddCopies(Convert.ToInt32(nudNumberOfCopies.Value), _BookID, dicFormat[cbFormat.SelectedItem.ToString()]))
            {
                clsDisplayMessage.ShowMessage("Copies added successfully", "", MessageBoxIcon.Information);
            }
            else
            {
                clsDisplayMessage.ShowMessage("Adding copies failed", "", MessageBoxIcon.Error);
            }
        }
        private void btnSaveCopies_Click(object sender, EventArgs e)
        {
            _SaveCopies();
        }
    }
}
