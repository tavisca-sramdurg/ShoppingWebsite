using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingWebsite;

namespace PaymentMethodTest
{
    [TestClass]
    public class PaymentCompletedNotificationTest
    {
        [TestMethod]
        public void PaymentCompletedNotificationTestReception()
        {
            //Act
            NotificationFactory notificationFactory = new NotificationFactory();
            
            //Arrange
            INotification paymentCompletedNotification = notificationFactory.GetNotificationType("PaymentCompletedNotification");
            string recievedMakePaymentConfirmationMessage = paymentCompletedNotification.getNotification();

            //Assert
            Assert.AreEqual(recievedMakePaymentConfirmationMessage, "Your payment is completed and received");
        }
    }
}
