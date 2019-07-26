using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class PaymentHandler
    {
        private IPaymentMethod _paymentMethod;

        //public PaymentHandler() { }

        public PaymentHandler(IPaymentMethod paymentMethod, UserDetails userDetails)
        {
            this._paymentMethod = paymentMethod;
        }

        public void SetPaymentMethod(IPaymentMethod paymentmethod)
        {
            this._paymentMethod = paymentmethod;
        }

        public string GetPaymentConfirmation()
        {
            string paymentCompleteConfirmationMessage = this._paymentMethod.MakePayment();
            return paymentCompleteConfirmationMessage;
        }
    }
}
