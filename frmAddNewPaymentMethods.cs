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
    public partial class frmAddNewPaymentMethods : Form
    {
        public frmAddNewPaymentMethods()
        {
            InitializeComponent();
        }

        private void frmAddNewPaymentMethods_Load(object sender, EventArgs e)
        {
            ctrlFillCreditCardData1.SwitchToAddNewCreditMethodMode();
        }

        private void ctrlFillCreditCardData1_OnInfosConfirmed(object sender, clsPaymentMethodEventsArgs e)
        {
            clsPaymentMethod NewPaymentMethod = new clsPaymentMethod(e.GatewayCustomerId, e.PaymentMethodToken, e.CardType, e.HolderName, e.BillingPostalCode, e.CreatedAt);
            if (NewPaymentMethod.Save())
            {
                ctrlFillCreditCardData1.ClearAllTextBoxes();
                ctrlFillCreditCardData1.DisableAddingButton();
                MessageBox.Show("Payment method added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Payment method adding failed , maybe your inputs are duplicated", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlFillCreditCardData1_Load(object sender, EventArgs e)
        {

        }
    }
}
