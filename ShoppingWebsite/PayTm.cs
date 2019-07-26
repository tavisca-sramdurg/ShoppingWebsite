using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class PayTm : IPaymentMethod
    {
        public string MakePayment()
        {
            NotificationFactory notificationFactory = new NotificationFactory();
            //MakePaymentConfirmation makePaymentConfirmation = new MakePaymentConfirmation();
            //PaymentCompletedNotification paymentCompletedNotification = new PaymentCompletedNotification();
             

            INotification makePaymentConfirmation = notificationFactory.GetNotificationType("MakePaymentConfirmation");
            string recievedMakePaymentConfirmationMessage =  makePaymentConfirmation.getNotification();

            INotification paymentCompletedNotification;

            bool ifPaymentConfirmed = true;
            if (recievedMakePaymentConfirmationMessage.Equals("Please confirm your payment"/*, StringComparison.OrdinalIgnoreCase*/))
            {
                paymentCompletedNotification = notificationFactory.GetNotificationType("PaymentCompletedNotification");
                string paymentReceipt = paymentCompletedNotification.getNotification();

                ifPaymentConfirmed = true;
            }
            //else
            //{
            //    ifPaymentConfirmed = false;
            //}
                

            //Initiate Payment
            if (ifPaymentConfirmed is true)
                return "Payment done using Paytm";
            else
                return "Payment using PayTm failed!";
        }
    }
}
