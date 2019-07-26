using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class PaymentCompletedNotification : INotification
    {
        public string getNotification()
        {
            return "Your payment is completed and received";
        }
    }
}
