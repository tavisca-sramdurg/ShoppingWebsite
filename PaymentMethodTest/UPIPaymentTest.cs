using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingWebsite;

namespace PaymentMethodTest
{
    [TestClass]
    public class UPIPaymentTest
    {
        [TestMethod]
        public void IfUPIPaymenttMethodSucceeds()
        {
            UserDetails UPIUserDetails = new UserDetails("Shravan", "", "1234", "");
            PaymentHandler paymentHandler = new PaymentHandler(new UPIPayment(), UPIUserDetails);

            string notificationMessage = paymentHandler.GetPaymentConfirmation();

            Assert.AreEqual("Payment done using UPI", notificationMessage);
        }
    }
}
