using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionForIEnumerableCustomer
{
    public static class Extensions
    {
        public static void SendEmailCoupons(this IEnumerable<Customer> customers, 
            Coupon spectialOffer)
        {
            foreach (var c in customers)
            {
                Utils.SendEmail(c.Name, c.Email, spectialOffer.Message);
            }
        }

        public static IEnumerable<Customer> LostProspects(this IEnumerable<Customer> targetList)
        {
            IEnumerable<Customer> answer =
                from c in targetList
                where DateTime.Now - c.LastOrderDate > TimeSpan.FromDays(30)
                select c;
            return answer;
        }
    }
}
