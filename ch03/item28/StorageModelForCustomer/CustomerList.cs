using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageModelForCustomer
{
    public class CustomerList : List<Customer>
    {
        // IEnumerable<Customer>からCustomerListを構築する
        public CustomerList(IEnumerable<Customer> list) : base(list)
        {
        }

        public void SendEmailCoupons(Coupon specialOffer)
        {
            foreach (var c in this)
            {
                Utils.SendEmail(c.Name, c.Email, specialOffer.Message);
            }
        }

        public IEnumerable<Customer> LostProspects()
        {
            IEnumerable<Customer> answer =
                from c in this
                where DateTime.Now - c.LastOrderDate > TimeSpan.FromDays(30)
                select c;
            return answer;
        }
    }
}
