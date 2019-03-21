using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionForIEnumerableCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "sasaki",
                    Email = "somewhere@example.com",
                    LastOrderDate = DateTime.Now - TimeSpan.FromDays(50)
                },
                new Customer
                {
                    Name = "sophia",
                    Email = "sophia@example.com",
                    LastOrderDate = DateTime.Now - TimeSpan.FromDays(40)
                },
                new Customer
                {
                    Name = "xyz",
                    Email = "xyz@example.com",
                    LastOrderDate = DateTime.Now - TimeSpan.FromDays(30)
                },
                new Customer
                {
                    Name = "abc",
                    Email = "abc@example.com",
                    LastOrderDate = DateTime.Now - TimeSpan.FromDays(20)
                },
                new Customer
                {
                    Name = "someone",
                    Email = "someone@example.com",
                    LastOrderDate = DateTime.Now - TimeSpan.FromDays(10)
                }
            };

            Console.WriteLine("Test for SendEmailCoupnes(for all Cusomters):");
            customers.SendEmailCoupons(new Coupon { Message = "offer for all customers" });

            Console.WriteLine("Test for SendEmailCoupnes(for lost prospects):");
            customers.LostProspects().SendEmailCoupons(
                new Coupon { Message = "offer for lost prospects" });
        }
    }
}
