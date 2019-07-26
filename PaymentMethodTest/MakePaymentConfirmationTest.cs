using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingWebsite;

namespace PaymentMethodTest
{
    [TestClass]
    public class MakePaymentConfirmationTest
    {
        [TestMethod]
        public void MakePaymentConfirmationNotificationReception()
        {
            //Act
            NotificationFactory notificationFactory = new NotificationFactory();

            //Arrange
            INotification makePaymentConfirmation = notificationFactory.GetNotificationType("MakePaymentConfirmation");
            string recievedMakePaymentConfirmationMessage = makePaymentConfirmation.getNotification();

            //Assert
            Assert.AreEqual(recievedMakePaymentConfirmationMessage, "Please confirm your payment");
        }
    }
}
