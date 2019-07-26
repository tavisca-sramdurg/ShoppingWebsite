using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public interface IPaymentMethod
    {
        //UserDetails GetUserDetails(UserDetails userDetails);
        //bool GetConfirmation();
        string MakePayment();
    }
}
