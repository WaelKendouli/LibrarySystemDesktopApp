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
    public partial class ctrlFillUserInfo : UserControl
    {
        public ctrlFillUserInfo()
        {
            InitializeComponent();
        }

        enum enMembership { FreeTrial = 1 , Monthly = 2 , Weekly = 3 , Yearly = 4 }

        int MembershipID = 1;

        public event EventHandler<UserAddedEventsArgs> OnUserInfosAdded;

        protected virtual void OnInfosSaved( UserAddedEventsArgs e)
        {
            OnUserInfosAdded?.Invoke(this, e);
        }

        public void OnInfosSaved(string firstName, string secondName, string thirdName, string lastName,
            string username, string email, string password, string pIN,
            string phone, int membershipID, int statusID)
        {
            OnInfosSaved(new UserAddedEventsArgs(firstName, secondName, thirdName, lastName, username, email, password, pIN, phone, membershipID, statusID));
        }

        private delegate bool delVaildationFunction(string txt);


        private void ctrlFillUserInfo_Load(object sender, EventArgs e)
        {
            rbFreeTrial.Checked = true;
        }

        private bool _ValidateByErrorProvider(TextBox tx , CancelEventArgs e ,
            delVaildationFunction ValidationFunction , string ErrorMessage = "")
        {

            if (ValidationFunction(tx.Text.Trim()))
            {
                // Cancel the event and set the error
                e.Cancel = true;
                epErrorCheck.SetError(tx, ErrorMessage);

                // Optional: Select the textbox with error
                tx.Select(0, tx.Text.Length);
                return false;

            }
            else
            {
                // Clear the error
                epErrorCheck.SetError(tx, "");
                e.Cancel = false;
                return true;
            }

        }

        public void FillUsersInfo(clsUser User)
        {
            if (User!=null)
            {
                txtFirstname.Text = User.FirstName;
                txtLastName.Text = User.LastName;
                txtEmail.Text = User.Email;
                txtPassword.Text = User.Password;
                txtPhone.Text = User.Phone;
                txtPIN.Text = User.PIN;
                txtUsername.Text = User.Username;
                txtThirdname.Text = User.ThirdName;
                txtSecondname.Text = User.SecondName;
                txtThirdname.Text = User.ThirdName;
            }
        }


        private void txtFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (_ValidateByErrorProvider(txtFirstname, e, string.IsNullOrEmpty, "First name is must not be empty") == false)
                return;
            _ValidateByErrorProvider(txtFirstname, e, clsInputValidator.IsNameNotValid, "First name is not valid");
        }

        private void txtSecondname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondname.Text))
            {
                return;
            }
            _ValidateByErrorProvider(txtSecondname, e, clsInputValidator.IsNameNotValid, "Second name is not valid");
        }

        private void txtThirdname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThirdname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdname.Text))
            {
                return;
            }
            _ValidateByErrorProvider(txtThirdname, e, clsInputValidator.IsNameNotValid, "Second name is not valid");
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (_ValidateByErrorProvider(txtLastName, e, string.IsNullOrEmpty, "Last name is must not be empty") == false)
                return;
            _ValidateByErrorProvider(txtLastName, e, clsInputValidator.IsNameNotValid, "Last name is not valid");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (_ValidateByErrorProvider(txtUsername, e, string.IsNullOrEmpty, "user name is must not be empty") == false)
                return;
            _ValidateByErrorProvider(txtUsername, e, clsInputValidator.IsUsernameNotCorrect, "user name is not valid must began with @");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
           
            if (_ValidateByErrorProvider(txtEmail, e, string.IsNullOrEmpty, "Email is must not be empty") == false)
                return;
            _ValidateByErrorProvider(txtEmail, e, clsInputValidator.IsEmailNotValid, "Email is not valid ");
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            _ValidateByErrorProvider(txtPhone, e, clsInputValidator.IsPhoneInputNotCorrect, "Phone must br 10 digits and began with 0[5-7]");
        }

        private void txtPIN_Validating(object sender, CancelEventArgs e)
        {
            if (_ValidateByErrorProvider(txtPIN, e, string.IsNullOrEmpty, "PIN must not be empty") == false)
                return;
            _ValidateByErrorProvider(txtPIN, e, clsInputValidator.IsPinNotCorrect, "PIN is not valid must be 3 digits");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                OnInfosSaved(txtFirstname.Text, txtSecondname.Text, txtThirdname.Text, txtLastName.Text,
                    txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPIN.Text,
                    txtPhone.Text, MembershipID, 1);
                //clsDisplayMessage.ShowMessage("Saved successfully", "Success", MessageBoxIcon.Information);
            }
            else
            {
                clsDisplayMessage.ShowMessage("Inputs not valid", "Error", MessageBoxIcon.Error);
            }
        }

        private void rbFreeTrial_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbYearly_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbFreeTrial_Click(object sender, EventArgs e)
        {
            MembershipID = (int)enMembership.FreeTrial;
        }

        private void rbWeekly_Click(object sender, EventArgs e)
        {
            MembershipID = (int)enMembership.Weekly;
        }

        private void rbMonthly_Click(object sender, EventArgs e)
        {
            MembershipID = (int)enMembership.Monthly;
        }

        private void rbYearly_Click(object sender, EventArgs e)
        {
            MembershipID = (int)enMembership.Yearly;
        }
    }
}
