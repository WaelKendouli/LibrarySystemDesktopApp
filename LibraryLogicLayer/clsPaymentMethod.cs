using LibraryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsPaymentMethod : IFPaymentMethod
    {
        public int PaymentID { get; set; }
        public string GatewayCustomerId { get; set; }
        public string PaymentMethodToken { get; set; }
        public string CardType { get; set; }
        public string HolderName { get; set; }
        public string BillingPostalCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public clsPaymentMethod()
        {
        }

        public clsPaymentMethod( string gatewayCustomerId, string paymentMethodToken,
            string cardType, string holderName, string billingPostalCode, DateTime createdAt)
        {
            GatewayCustomerId = gatewayCustomerId;
            PaymentMethodToken = paymentMethodToken;
            CardType = cardType;
            HolderName = holderName;
            BillingPostalCode = billingPostalCode;
            CreatedAt = createdAt;
        }
        public bool DepositAmount(double Amount,int UserID)
        {
            return clsWalletDataAccess.DepositAmount(UserID , Amount);
        }
        public bool WithdrawAmount(double Amount, int UserID)
        {
            return false;
        }

        private  bool AddNewPaymentMethod()
        {
            return clsPaymentMethodsDataAccess.AddNewPaymentMethod(this.GatewayCustomerId, this.PaymentMethodToken, this.CardType,
                this.HolderName, this.BillingPostalCode, this.CreatedAt) > 0;
        }

        public bool Save()
        {
            return AddNewPaymentMethod();
        }

        public static bool CheckGateway_Customer_Id(int UserID , string Gateway_Customer_Id)
        {
            return clsPaymentMethodsDataAccess.IsPaymentMethodAttributeExist(UserID, Gateway_Customer_Id,
                "@gateway_customer_id", "SP_PM_CheckCustomerGatewayID");
        }

        public static bool CheckCardType(int UserID, string card_type)
        {
            return clsPaymentMethodsDataAccess.IsPaymentMethodAttributeExist(UserID, card_type,
                "@card_type", "SP_PM_CheckCardType");
        }

        public static bool CheckHolderName(int UserID, string holder_name)
        {
            return clsPaymentMethodsDataAccess.IsPaymentMethodAttributeExist(UserID, holder_name,
                "@holder_name", "SP_PM_CheckHolderName");
        }

        public static bool CheckMethodToken(int UserID, string Method_Token)
        {
            return clsPaymentMethodsDataAccess.IsPaymentMethodAttributeExist(UserID, Method_Token,
                "@payment_method_token", "SP_PM_CheckMethodToken");
        }

        public static bool CheckPostalCode(int UserID, string PostalCode)
        {
            return clsPaymentMethodsDataAccess.IsPaymentMethodAttributeExist(UserID, PostalCode,
                "@billing_postal_code", "SP_PM_PostalCode");
        }

    }
}
