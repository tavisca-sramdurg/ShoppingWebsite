using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class NotificationFactory
    {
        public INotification GetNotificationType(String notificationType)
        {
            if (notificationType == null)
            {
                return null;
            }
            if (notificationType.Equals("MakePaymentConfirmation", StringComparison.OrdinalIgnoreCase))
            {
                return new MakePaymentConfirmation();
            }
            else if (notificationType.Equals("PaymentCompletedNotification", StringComparison.OrdinalIgnoreCase))
            {
                return new PaymentCompletedNotification();
            }
            return null;
        }
    }
}
