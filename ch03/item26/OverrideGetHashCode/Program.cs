using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideGetHashCode
{
    class Program
    {
        static void TestDictionaryKey()
        {
            Console.WriteLine("\nTestDictionaryKey():\n");

            bool result;
            string value;
            var myTable = new Dictionary<Name, string>();
            Name name_a_a_a = new Name { Last = "a", First = "a", Middle = "a" };
            Name name_a_a_a_dash = new Name { Last = "a", First = "a", Middle = "a" };

            myTable.Add(name_a_a_a, "name_a_a_a");

            result = myTable.TryGetValue(name_a_a_a, out value);
            Console.WriteLine($"result = myTable.TryGetValue(name_a_a_a, out value); result: {result}, value: {value}");

            result = myTable.TryGetValue(name_a_a_a_dash, out value);
            Console.WriteLine($"result = myTable.TryGetValue(name_a_a_a_dash, out value); result: {result}, value: {value}");
        }

        static void Main(string[] args)
        {
            TestDictionaryKey();
        }
    }
}
