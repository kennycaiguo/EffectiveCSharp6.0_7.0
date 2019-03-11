using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalOrder
{
    class Program
    {
        static void CompareCustomer()
        {
            int diff = new Customer("Sophia").CompareTo(new Customer("Seiji"));

            Console.WriteLine("new Customer(\"Sophia\").CompareTo(new Customer(\"Seiji\")): " + diff);
      
        }

        static void CompareCustomerWithEmployee()
        {
            Customer c1 = new Customer("Sophia");
            Employee e1 = new Employee { Name = "Sasaki" };

            try
            {
                //if (c1.CompareTo(e1) > 0)
                if (((IComparable)c1).CompareTo(e1) > 0)
                    Console.WriteLine("1つ目のCustomerの方が大");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void SortCustomers()
        {
            List<Customer> list = new List<Customer>
            { new Customer("Sophia"), new Customer("Seiji"), new Customer("Lisa") };

            list.Sort();
            foreach (var c in list)
                Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            CompareCustomer();
            CompareCustomerWithEmployee();
            SortCustomers();
        }
    }
}
