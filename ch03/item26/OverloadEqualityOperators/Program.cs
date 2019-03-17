using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadEqualityOperators
{
    class Program
    {
        static void TestEqualityOperators()
        {
            Console.WriteLine("\nTestEqualityOperators():\n");

            bool result;
            Name name_null = null;
            Name name_n_n_n = new Name();
            Name name_a_n_n = new Name { Last = "a" };
            Name name_b_n_n = new Name { Last = "b" };
            Name name_n_a_n = new Name { First = "a" };
            Name name_n_b_n = new Name { First = "b" };
            Name name_n_n_a = new Name { Middle = "a" };
            Name name_n_n_b = new Name { Middle = "b" };
            Name name_a_a_a = new Name { Last = "a", First = "a", Middle = "a" };
            Name name_a_a_a_dash = new Name { Last = "a", First = "a", Middle = "a" };

            result = name_n_n_n == name_n_n_n;
            Console.WriteLine($"name_n_n_n == name_n_n_n: {result}");

            result = name_n_n_n != name_n_n_n;
            Console.WriteLine($"name_n_n_n != name_n_n_n: {result}");

            result = name_n_n_n == name_null;
            Console.WriteLine($"name_n_n_n == name_null: {result}");

            result = name_n_n_n != name_null;
            Console.WriteLine($"name_n_n_n != name_null: {result}");

            result = name_a_n_n == name_b_n_n;
            Console.WriteLine($"name_a_n_n == name_b_n_n: {result}");

            result = name_a_n_n != name_b_n_n;
            Console.WriteLine($"name_a_n_n != name_b_n_n: {result}");

            result = name_n_a_n == name_n_b_n;
            Console.WriteLine($"name_n_a_n == name_n_b_n: {result}");

            result = name_n_a_n != name_n_b_n;
            Console.WriteLine($"name_n_a_n != name_n_b_n: {result}");

            result = name_n_n_a == name_n_n_b;
            Console.WriteLine($"name_n_n_a == name_n_n_b: {result}");

            result = name_n_n_a != name_n_n_b;
            Console.WriteLine($"name_n_n_a != name_n_n_b: {result}");

            result = name_a_a_a == name_a_a_a_dash;
            Console.WriteLine($"name_a_a_a == name_a_a_a_dash: {result}");

            result = name_a_a_a != name_a_a_a_dash;
            Console.WriteLine($"name_a_a_a != name_a_a_a_dash: {result}");
        }

        static void Main(string[] args)
        {
            TestEqualityOperators();
        }
    }
}
