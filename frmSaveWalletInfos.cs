using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryLogicLayer;
namespace LibrarySystemApp
{
    public partial class frmSaveWalletInfos : Form
    {
        public frmSaveWalletInfos()
        {
            InitializeComponent();
        }
        clsPaymentMethod _PaymentMethod = null;

        private void Deposit()
        {
            if (_PaymentMethod == null || double.TryParse(txtAmount.Text,out double result)==false)
            {
                return;
            }
            if (clsInputValidator.IsAmountValid(txtAmount.Text)==false)
            {
                MessageBox.Show("Amount is not valid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (_PaymentMethod.DepositAmount(Convert.ToDouble(txtAmount.Text), clsCurrentUser.CurrentUserInfo.ID))
                {
                    MessageBox.Show($"{txtAmount.Text} was added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{txtAmount.Text} adding failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ctrlFillCreditCardData1_OnInfosConfirmed(object sender, clsPaymentMethodEventsArgs e)
        {
            gbTransaction.Enabled = true;
            _PaymentMethod = new clsPaymentMethod(e.GatewayCustomerId, e.PaymentMethodToken, e.CardType, e.HolderName, e.BillingPostalCode, DateTime.Now);
            
        }

        private void frmSaveWalletInfos_Load(object sender, EventArgs e)
        {
            gbTransaction.Enabled = false;
        }

        private void gbTransaction_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit();
        }
    }
}
