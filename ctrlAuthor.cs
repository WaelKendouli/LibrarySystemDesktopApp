using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemApp
{
    public partial class ctrlAuthor : UserControl
    {
        public ctrlAuthor()
        {
            InitializeComponent();
        }

        clsAuthor CurrentAuthor = null;
        private void _LoadImage(string PhotoURL)
        {
            if (string.IsNullOrEmpty(PhotoURL))
            {
                MessageBox.Show($"Photo doesn't exist", "loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbAuthorPic.Image = null;
                return;
            }
            if (!File.Exists(PhotoURL))
            {
                MessageBox.Show($"Couldn't load photo \n {PhotoURL} Couldn't be found", "loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbAuthorPic.Image = null;
                return;
            }

            try
            {
                pbAuthorPic.Image = Image.FromFile(PhotoURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't load photo \n {ex.Message}", "Loading photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void LoadAuthorsInfo(int AuthorID)
        {
            CurrentAuthor = clsAuthor.GetAuthorByID(AuthorID);
            if (CurrentAuthor!=null)
            {
                btnViewLitetature.Visible = true;
                lbAuthor.Text = CurrentAuthor.Name;
                lbFirstName.Text = CurrentAuthor.FirstName;
                lbSecName.Text = CurrentAuthor.SecondName;
                lbThirdName.Text = CurrentAuthor.ThirdName;
                lbLastName.Text = CurrentAuthor.LastName;
                lbAuthorID.Text = CurrentAuthor.AuthorID.ToString();
                txtBio.Text = CurrentAuthor.Bio;
                _LoadImage(CurrentAuthor.PhotoLocation);
            }
        }
        public void RestControl()
        {
            txtSearchInput.Clear();
            pbAuthorPic.Image = null;
            lbAuthor.Text = "[????]";
            lbAuthorID.Text = "[????]";
            lbFirstName.Text = "[????]";
            lbLastName.Text = "[????]";
            lbSecName.Text = "[????]";
            lbThirdName.Text = "[????]";
            txtBio.Text = "";
            btnViewLitetature.Visible = false;
        
        }
        private void InitialazeComboBox()
        {
            if (cbSearch.Items.Count>0)
            {
                cbSearch.SelectedIndex = 0;
            }      
        }
        private void ctrlAuthor_Load(object sender, EventArgs e)
        {
            InitialazeComboBox();
            btnViewLitetature.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RestControl();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchInput.Text.ToString() ,out int result)==false)
            {
                MessageBox.Show("Invalid Input");
                return;
            }
            LoadAuthorsInfo(Convert.ToInt32(txtSearchInput.Text));
        }

        private void btnViewLitetature_Click(object sender, EventArgs e)
        {
            if (CurrentAuthor!=null)
            {
                frmViewAuthorWork frm = new frmViewAuthorWork(CurrentAuthor.AuthorID, CurrentAuthor.Name);
                frm.ShowDialog();
            }
        }


    }
}
