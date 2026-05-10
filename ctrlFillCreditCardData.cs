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
    public partial class ctrlFillCreditCardData : UserControl
    {
        int _UserID;
        public ctrlFillCreditCardData()
        {
            InitializeComponent();
            _UserID = clsCurrentUser.CurrentUserInfo.ID;
        }

        public event EventHandler<clsPaymentMethodEventsArgs> OnInfosConfirmed;

        protected virtual void OnInforamtionsConfirmed(clsPaymentMethodEventsArgs e)
        {
            OnInfosConfirmed?.Invoke(this, e);
        }

        enum enMode { eNew = 1 , eValidate = 2}
        enMode Mode = enMode.eValidate;
        private void ctrlFillCreditCardData_Load(object sender, EventArgs e)
        {

        }
        public void ClearAllTextBoxes()
        {
            txtPaymentMethodToken.Clear();
            txtHoldName.Clear();
            txtGatewayCustomerID.Clear();
            txtBillingPostalCode.Clear();
            txtCardType.Clear();
        }

        public void SwitchToAddNewCreditMethodMode()
        {
            Mode = enMode.eNew;
            btnConfirm.Text = "Add";
        }

        public void DisableAddingButton()
        {
            btnConfirm.Enabled = false;
        }
        private void txtGatewayCustomerID_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck,txtGatewayCustomerID,e,string.IsNullOrEmpty,"this field is empty")==false)
            {
                return;
            }
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtGatewayCustomerID, e, clsInputValidator.IsValidGatewayCustomerId, "Must be 5-50 characters using letters, numbers, underscores, and hyphens only.") == false)
            {
                return;
            }
            if (Mode==enMode.eValidate)
            clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, 
                txtGatewayCustomerID, e, clsPaymentMethod.CheckGateway_Customer_Id, _UserID, "Your input doesn't match the database");
            else
            {
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck,
                txtGatewayCustomerID, e, clsPaymentMethod.CheckGateway_Customer_Id, _UserID, "this input already exist in the database",true);
            }

        }

        private void txtPaymentMethodToken_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPaymentMethodToken, e, string.IsNullOrEmpty, "this field is empty") == false)
            {
                return;
            }
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtPaymentMethodToken, e, clsInputValidator.IsValidPaymentMethodToken, "Must be 10-100 characters using letters, numbers, underscores, and hyphens only.") == false)
            {
                return;
            }
            if (Mode == enMode.eValidate)
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtPaymentMethodToken,
                e, clsPaymentMethod.CheckMethodToken, _UserID, "Your input doesn't match the database");
            else
            {
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtPaymentMethodToken,
                e, clsPaymentMethod.CheckMethodToken, _UserID, "this input already exist in the database",true);
            }

        }

        private void txtCardType_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtCardType, e, string.IsNullOrEmpty, "this field is empty") == false)
            {
                return;
            }
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtCardType,
                e, clsInputValidator.IsValidCardType, "Must be Visa, MasterCard, American Express, Pay Pal, Amex, Apple Pay, Discover, Diners Club, JCB, or UnionPay.") == false)
            {
                return;

            }
            if (Mode == enMode.eValidate)
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtCardType, e, clsPaymentMethod.CheckCardType, _UserID, "Your input doesn't match the database");
            else
            {
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtCardType, e, clsPaymentMethod.CheckCardType, _UserID, "this input already exist in the database", true);
            }
        }

        private void txtHoldName_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtHoldName,
                e, string.IsNullOrEmpty, "this field is empty") == false)
            {
                return;
            }
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtHoldName,
                e, clsInputValidator.IsValidHolderName, "Must be 2-100 characters using letters, spaces, hyphens, periods, and apostrophes only.") == false)
            {
                return;
            }
            if (Mode == enMode.eValidate)
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtHoldName,
                e, clsPaymentMethod.CheckHolderName, _UserID, "Your input doesn't match the database");
            

        }

        private void txtBillingPostalCode_Validating(object sender, CancelEventArgs e)
        {
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck, txtBillingPostalCode, e, string.IsNullOrEmpty, "this field is empty") == false)
            {
                return;
            }
            if (clsErrorProviderVerfication._ValidateByErrorProvider(epCheck,txtBillingPostalCode,e,clsInputValidator.IsValidBillingPostalCode, "\"Must be 3-10 characters using letters, numbers, spaces, and hyphens only.")==false)
            {
                return;
            }
            if (Mode == enMode.eValidate)
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtBillingPostalCode, e, clsPaymentMethod.CheckPostalCode, _UserID, "Your input doesn't match the database");
            else
            {
                clsErrorProviderVerfication._ExistenceValidationByErrorProvider(epCheck, txtBillingPostalCode, e, clsPaymentMethod.CheckPostalCode, _UserID, "this input already exist in the database", true);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()==false)
            {
                return;
            }
            OnInforamtionsConfirmed(new clsPaymentMethodEventsArgs(txtGatewayCustomerID.Text.Trim(), txtPaymentMethodToken.Text.Trim(), txtCardType.Text.Trim(), txtHoldName.Text.Trim(), txtBillingPostalCode.Text.Trim(), DateTime.Now));

        }
    }
}
