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
    public partial class ctrlConfirmPassword : UserControl
    {
        public ctrlConfirmPassword()
        {
            InitializeComponent();
        }

        public event EventHandler<clsPasswordConfirmedEventArgs> OnPasswordConfirmed;

        protected virtual void OnMyPasswordConfirm(clsPasswordConfirmedEventArgs e)
        {
            OnPasswordConfirmed?.Invoke(this, e);
        }



        private void ctrlConfirmPassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, textBox1, e, string.IsNullOrEmpty,"this field is empty")==false)
            {
                return;
            }
            clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, textBox1, e, clsUser.IsOldPasswordCorrect, clsCurrentUser.CurrentUserInfo.ID, "Password not correct");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            OnMyPasswordConfirm(new clsPasswordConfirmedEventArgs(true));
        }
    }
}
