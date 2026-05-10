using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public interface IFPaymentMethod
    {
         int PaymentID { get; set; }
         string GatewayCustomerId { get; set; }
         string PaymentMethodToken { get; set; }
         string CardType { get; set; }
         string HolderName { get; set; }
         string BillingPostalCode { get; set; }
         DateTime CreatedAt { get; set; }
        bool DepositAmount(double Amount , int UserID);
                
        bool WithdrawAmount(double Amount , int UserID);

        bool Save();
    }
}
