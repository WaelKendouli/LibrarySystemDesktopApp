using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicLayer
{
    public class clsPaymentMethodEventsArgs : EventArgs
    {
        
        public string GatewayCustomerId { get;  }
        public string PaymentMethodToken { get; }
        public string CardType { get; }
        public string HolderName { get;  }
        public string BillingPostalCode { get; }
        public DateTime CreatedAt { get;  }

        
        public clsPaymentMethodEventsArgs( string gatewayCustomerId, string paymentMethodToken,
            string cardType, string holderName, string billingPostalCode, DateTime createdAt)
        {
            
            GatewayCustomerId = gatewayCustomerId;
            PaymentMethodToken = paymentMethodToken;
            CardType = cardType;
            HolderName = holderName;
            BillingPostalCode = billingPostalCode;
            CreatedAt = createdAt;
        }
    }
}
