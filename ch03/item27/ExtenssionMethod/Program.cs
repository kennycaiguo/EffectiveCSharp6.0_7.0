using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenssionMethod
{
    class Program
    {
        static void TestLessThan()
        {
            Console.WriteLine("\nTestLessThan():\n");

            Name name_null = null;
            Name name_n_n = new Name { };
            Name name_a_n = new Name { Last = "a" };
            Name name_a_a = new Name { Last = "a", First = "a" };
            Name name_a_b = new Name { Last = "a", First = "b" };
            Name name_a_b_dash = new Name { Last = "a", First = "b" };
            Name name_b_n = new Name { Last = "b" };
            bool result;

            result = name_n_n.LessThan(name_null);
            Console.WriteLine($"name_n_n.LessThan(name_null): {result}");

            result = name_n_n.LessThan(name_n_n);
            Console.WriteLine($"name_n_n.LessThan(name_n_n): {result}");

            result = name_a_n.LessThan(name_b_n);
            Console.WriteLine($"name_a_n.LessThan(name_b_n): {result}");

            result = name_b_n.LessThan(name_a_n);
            Console.WriteLine($"name_b_n.LessThan(name_a_n): {result}");

            result = name_a_a.LessThan(name_a_b);
            Console.WriteLine($"name_a_a.LessThan(name_a_b): {result}");

            result = name_a_b.LessThan(name_a_a);
            Console.WriteLine($"name_a_b.LessThan(name_a_a): {result}");

            result = name_a_b.LessThan(name_a_b_dash);
            Console.WriteLine($"name_a_b.LessThan(name_a_b_dash): {result}");
        }

        static void Main(string[] args)
        {
            TestLessThan();
        }
    }
}
