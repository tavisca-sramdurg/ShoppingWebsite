using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingWebsite;

namespace PaymentMethodTest
{
    [TestClass]
    public class PayTmPaymentTest
    {
        [TestMethod]
        public void IfPayTmPaymentMethodSucceeds()
        {
            UserDetails PayTmUserDetails = new UserDetails("Shravan", "9763328133", "", "");

            PaymentHandler paymentHandler = new PaymentHandler(new PayTm(), PayTmUserDetails);

            string notificationMessage = paymentHandler.GetPaymentConfirmation();
            string message = "Payment done using Paytm";
            string m2 = message.ToLowerInvariant();

            Assert.AreEqual(message, notificationMessage);
        }
    }
}
