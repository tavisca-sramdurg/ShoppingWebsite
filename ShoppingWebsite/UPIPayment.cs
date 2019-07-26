using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class UPIPayment : IPaymentMethod
    {
        public string MakePayment()
        {
            NotificationFactory notificationFactory = new NotificationFactory();
            
            INotification makePaymentConfirmation = notificationFactory.GetNotificationType("MakePaymentConfirmation");
            string recievedMakePaymentConfirmationMessage = makePaymentConfirmation.getNotification();

            INotification paymentCompletedNotification;

            bool ifPaymentConfirmed;
            if (recievedMakePaymentConfirmationMessage.Equals("Please confirm your payment", StringComparison.OrdinalIgnoreCase))
            {
                paymentCompletedNotification = notificationFactory.GetNotificationType("PaymentCompletedNotification");
                string paymentReceipt = paymentCompletedNotification.getNotification();
                ifPaymentConfirmed = true;
            }
            else
            {
                ifPaymentConfirmed = false;
            }

            //Initiate Payment
            if (ifPaymentConfirmed is true)
                return "Payment done using UPI";
            else
                return "Payment using UPI failed!";

            
        }
    }
}
