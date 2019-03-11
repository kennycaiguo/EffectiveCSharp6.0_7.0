using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>
            { new Customer("Sophia", 100), new Customer("Seiji", 200), new Customer("Lisa", 150) };

            list.Sort(Customer.CompareByRevenue);
            foreach (var c in list)
                Console.WriteLine(c);
        }
    }
}
