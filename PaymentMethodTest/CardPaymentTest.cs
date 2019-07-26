using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingWebsite;

namespace PaymentMethodTest
{
    [TestClass]
    public class CardPaymentTest
    {
        [TestMethod]
        public void IfCardPaymenttMethodSucceeds()
        {
            UserDetails cardUserDetails = new UserDetails("Shravan", "", "", "1234 4567 5678 9876");
            PaymentHandler paymentHandler = new PaymentHandler(new CardPayment(), cardUserDetails);

            string notificationMessage = paymentHandler.GetPaymentConfirmation();
            string message = "Payment done using Card";
            string m2 = message.ToLowerInvariant();

            Assert.AreEqual(message, notificationMessage);

            //Assert.AreEqual("Payment done using Card", notificationMessage);
        }
    }
}
