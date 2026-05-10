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
    public partial class ctrlPublisherInfosSaved : UserControl
    {
        public ctrlPublisherInfosSaved()
        {
            InitializeComponent();
        }
        public event EventHandler<clsOnPublisherSavedEventsArgs> OnPublisherSaved;

        string _PhotoPath = "";
        protected virtual void OnPublisherInfosSaved(clsOnPublisherSavedEventsArgs e)
        {
            OnPublisherSaved?.Invoke(this, e);
        }

        public void FillPublisherInfos(int PublisherID)
        {
            clsPublisher publisher = clsPublisher.FindPublisherByID(PublisherID);
            if (publisher!=null)
            {
                txtPublisher.Text = publisher.Name;
                txtEmail.Text = publisher.Email;
                txtPhone.Text = publisher.PhoneNumber;
                txtCity.Text = publisher.City;
                txtURL.Text = publisher.WebsiteURL;
                if (File.Exists(publisher.PhotoPath))
                {
                    pbPicture.Image = Image.FromFile(publisher.PhotoPath);
                }
            }
        }
        private void ctrlPublisherInfosSaved_Load(object sender, EventArgs e)
        {
            cbCountries.SelectedIndex = 0;
            cbCountries.DropDownHeight = 300;
        }

        private void txtPublisher_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck,txtPublisher,e,string.IsNullOrEmpty,"Publisher must not be empty")== false)
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPublisher, e, clsInputValidator.IsNameNotValid, "field is not valid");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtEmail, e, string.IsNullOrEmpty, "Email must not be empty") == false)
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtEmail, e, clsInputValidator.IsEmailNotValid, "field is not valid");
        }

        private void txtURL_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtURL, e, string.IsNullOrEmpty, "this field must not be empty") == false)
            {
                return;
            }
            // Add URL validation
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtCity, e, string.IsNullOrEmpty, "this field must not be empty") == false)
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtCity, e, clsInputValidator.IsNameNotValid, "field is not valid");
        }

        private void rbIsActive_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            OnPublisherInfosSaved(new clsOnPublisherSavedEventsArgs(txtPublisher.Text.Trim(), txtURL.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), txtCity.Text.Trim(), cbCountries.SelectedItem.ToString(), true, _PhotoPath));
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPhone, e, string.IsNullOrEmpty, "this field must not be empty") == false)
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPhone, e, clsInputValidator.IsPhoneInputNotCorrect, "field is not valid");
        }

        private void btnSetPhoto_Click(object sender, EventArgs e)
        {
            _PhotoPath = clsPhotosHandeling._SelectPhotoCover(pbPicture);
        }
    }
}
