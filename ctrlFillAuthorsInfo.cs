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
    public partial class ctrlFillAuthorsInfo : UserControl
    {
        public ctrlFillAuthorsInfo()
        {
            InitializeComponent();
        }
        string PhotoLoaction = "";
        public event EventHandler<clsAuthorsEventArgs> OnAuthorInfosSaved;

        protected virtual void OnAuthorSaved(clsAuthorsEventArgs e)
        {
            OnAuthorInfosSaved?.Invoke(this, e);
        }

        public void FillInfos(clsAuthor author)
        {
            if (author==null)
            {
                throw new Exception("Author cannot be null");
            }
            txtFirstname.Text = author.FirstName;
            txtLastname.Text = author.LastName;
            txtSecondName.Text = author.SecondName;
            txtThirdName.Text = author.ThirdName;
            txtBio.Text = author.Bio;

            if (File.Exists(author.PhotoLocation))
            {
                pbAuthorsPhoto.Image = Image.FromFile(author.PhotoLocation);
            }
            else
            {
                MessageBox.Show($"{author.PhotoLocation} doesn't exist");
            }
        }
        private void txtFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epValidate,txtFirstname,e,
                string.IsNullOrEmpty,"First name shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epValidate, txtFirstname, e,
                clsInputValidator.IsNameNotValid, "First name is not valid");
        }

        

        private void txtBio_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epValidate, txtBio, e,
               string.IsNullOrEmpty, "this field shouldn't be empty"))
            {
                return;
            }
         
        }

        private void txtLastname_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epValidate, txtLastname, e,
            string.IsNullOrEmpty, "Last name shouldn't be empty"))
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epValidate, txtFirstname, e,
                clsInputValidator.IsNameNotValid, "Last name is not valid");
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ctrlFillAuthorsInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            OnAuthorSaved(new clsAuthorsEventArgs(txtFirstname.Text.Trim(), txtSecondName.Text.Trim(), txtThirdName.Text.Trim(),
                txtLastname.Text.Trim(), PhotoLoaction, txtBio.Text.Trim()));
        }

        private void btnSetPhoto_Click(object sender, EventArgs e)
        {
            PhotoLoaction = clsPhotosHandeling._SelectPhotoCover(pbAuthorsPhoto);
        }
    }
}
