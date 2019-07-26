using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingWebsite
{
    public class UserDetails
    {
        public string userName;
        public string registeredMobileNumber;  //needed for paytm
        public string upiId;                   //needed for UPI
        public string cardNumber;              //needed for card payment

        public UserDetails(string userName, string registeredMobileNumber, string upiId, string cardNumber)
        {
            this.userName = userName;
            this.registeredMobileNumber = registeredMobileNumber;  
            this.upiId = upiId;                   
            this.cardNumber = cardNumber;
        }

        //public UserDetails GetUserDetails()
        //{
        //    return new UserDetails();
        //}
    }
}