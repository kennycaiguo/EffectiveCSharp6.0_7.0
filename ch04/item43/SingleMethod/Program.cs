using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleMethod
{
    class Program
    {
        static void TestNotSingleElement()
        {
            Console.WriteLine("TestNotSingleElement():");

            var somePeople = new List<Person>
            {
                new Person { FirstName = "Bill", LastName = "Gates" },
                new Person { FirstName = "Bill", LastName = "Wagner" },
                new Person { FirstName = "Bill", LastName = "Johnson" }
            };

            // シーケンス内に複数の該当データが存在するため
            //　例外がスローされる
            try
            {
                var answer = (from p in somePeople
                              where p.FirstName == "Bill"
                              select p).Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void TestZeroElement()
        {
            Console.WriteLine("TestZeroElement():");

            var somePeople = new List<Person>
            {
                new Person { FirstName = "Bill", LastName = "Gates" },
                new Person { FirstName = "Bill", LastName = "Wagner" },
                new Person { FirstName = "Bill", LastName = "Johnson" }
            };

            // シーケンス内に複数の該当データが存在するため
            //　例外がスローされる
            try
            {
                var answer = (from p in somePeople
                              where p.FirstName == "Larry"
                              select p).Single();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            TestNotSingleElement();
            TestZeroElement();
        }
    }
}
