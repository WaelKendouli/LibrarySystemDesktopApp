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
using static System.Net.Mime.MediaTypeNames;

namespace LibrarySystemApp
{
    public partial class frmChangeMyPassword : Form
    {
        public frmChangeMyPassword()
        {
            InitializeComponent();
        }
        private bool AreNewAndOldPasswordsTheSame(string tx)
        {
            return (txtOld.Text == tx);
        }

        private bool AreNewAndConfirmPasswordsTheSame(string tx)
        {
            return !(txtNew.Text == tx);
        }

        private void txtOld_Validating(object sender, CancelEventArgs e)
        {
            if ( clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtOld, e, string.IsNullOrEmpty, "This field should't be empty") == false 
                )
            {
                return;
            }
            clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtOld, e, clsUser.IsOldPasswordCorrect, clsCurrentUser.CurrentUserInfo.ID, "your input doesn't match the original password");
        }

        private void txtNew_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtNew, e, string.IsNullOrEmpty, "This field should't be empty") == false 
                )
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtNew, e, AreNewAndOldPasswordsTheSame, "Old and New shouldn't be the same");
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtConfirm, e, string.IsNullOrEmpty, "This field should't be empty") == false )
            {
                return;
            }
            clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtConfirm, e, AreNewAndConfirmPasswordsTheSame, "New and Confirm text are not the same");
        }

        private void _ChangePassword()
        {
            if (clsUser.ChangePassword(clsCurrentUser.CurrentUserInfo.ID , txtNew.Text.Trim()))
            {
                MessageBox.Show("Password Changed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password changing failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            if (clsInputValidator.IsWeakPassword(txtNew.Text.Trim()))
            {
                MessageBox.Show("Your password is weak you should make it more powerful", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _ChangePassword();
        }

        private void frmChangeMyPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
