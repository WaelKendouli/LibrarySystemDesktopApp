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
    public partial class ctrlAuthorInfo : UserControl
    {
        public ctrlAuthorInfo()
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
            if (CurrentAuthor != null)
            {
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
        private void ctrlAuthorInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
