using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class MakePaymentConfirmation : INotification
    {
        public string getNotification()
        {
            return "Please confirm your payment";
        }
    }
}
