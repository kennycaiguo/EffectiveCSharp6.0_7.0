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

        static void TestGreaterThan()
        {
            Console.WriteLine("\nTestGreaterThan():\n");

            Name name_null = null;
            Name name_n_n = new Name { };
            Name name_a_n = new Name { Last = "a" };
            Name name_a_a = new Name { Last = "a", First = "a" };
            Name name_a_b = new Name { Last = "a", First = "b" };
            Name name_a_b_dash = new Name { Last = "a", First = "b" };
            Name name_b_n = new Name { Last = "b" };
            bool result;

            result = name_n_n.GreaterThan(name_null);
            Console.WriteLine($"name_n_n.GreaterThan(name_null): {result}");

            result = name_n_n.GreaterThan(name_n_n);
            Console.WriteLine($"name_n_n.GreaterThan(name_n_n): {result}");

            result = name_a_n.GreaterThan(name_b_n);
            Console.WriteLine($"name_a_n.GreaterThan(name_b_n): {result}");

            result = name_b_n.GreaterThan(name_a_n);
            Console.WriteLine($"name_b_n.GreaterThan(name_a_n): {result}");

            result = name_a_a.GreaterThan(name_a_b);
            Console.WriteLine($"name_a_a.GreaterThan(name_a_b): {result}");

            result = name_a_b.GreaterThan(name_a_a);
            Console.WriteLine($"name_a_b.GreaterThan(name_a_a): {result}");

            result = name_a_b.GreaterThan(name_a_b_dash);
            Console.WriteLine($"name_a_b.GreaterThan(name_a_b_dash): {result}");
        }

        static void TestLessThanEqual()
        {
            Console.WriteLine("\nTestLessThanEqual():\n");

            Name name_null = null;
            Name name_n_n = new Name { };
            Name name_a_n = new Name { Last = "a" };
            Name name_a_a = new Name { Last = "a", First = "a" };
            Name name_a_b = new Name { Last = "a", First = "b" };
            Name name_a_b_dash = new Name { Last = "a", First = "b" };
            Name name_b_n = new Name { Last = "b" };
            bool result;

            result = name_n_n.LessThanEqual(name_null);
            Console.WriteLine($"name_n_n.LessThanEqual(name_null): {result}");

            result = name_n_n.LessThanEqual(name_n_n);
            Console.WriteLine($"name_n_n.LessThanEqual(name_n_n): {result}");

            result = name_a_n.LessThanEqual(name_b_n);
            Console.WriteLine($"name_a_n.LessThanEqual(name_b_n): {result}");

            result = name_b_n.LessThanEqual(name_a_n);
            Console.WriteLine($"name_b_n.LessThanEqual(name_a_n): {result}");

            result = name_a_a.LessThanEqual(name_a_b);
            Console.WriteLine($"name_a_a.LessThanEqual(name_a_b): {result}");

            result = name_a_b.LessThanEqual(name_a_a);
            Console.WriteLine($"name_a_b.LessThanEqual(name_a_a): {result}");

            result = name_a_b.LessThanEqual(name_a_b_dash);
            Console.WriteLine($"name_a_b.LessThanEqual(name_a_b_dash): {result}");
        }

        static void TestGreaterThanEqual()
        {
            Console.WriteLine("\nTestGreaterThanEqual():\n");

            Name name_null = null;
            Name name_n_n = new Name { };
            Name name_a_n = new Name { Last = "a" };
            Name name_a_a = new Name { Last = "a", First = "a" };
            Name name_a_b = new Name { Last = "a", First = "b" };
            Name name_a_b_dash = new Name { Last = "a", First = "b" };
            Name name_b_n = new Name { Last = "b" };
            bool result;

            result = name_n_n.GreaterThanEqual(name_null);
            Console.WriteLine($"name_n_n.GreaterThanEqual(name_null): {result}");

            result = name_n_n.GreaterThanEqual(name_n_n);
            Console.WriteLine($"name_n_n.GreaterThanEqual(name_n_n): {result}");

            result = name_a_n.GreaterThanEqual(name_b_n);
            Console.WriteLine($"name_a_n.GreaterThanEqual(name_b_n): {result}");

            result = name_b_n.GreaterThanEqual(name_a_n);
            Console.WriteLine($"name_b_n.GreaterThanEqual(name_a_n): {result}");

            result = name_a_a.GreaterThanEqual(name_a_b);
            Console.WriteLine($"name_a_a.GreaterThanEqual(name_a_b): {result}");

            result = name_a_b.GreaterThanEqual(name_a_a);
            Console.WriteLine($"name_a_b.GreaterThanEqual(name_a_a): {result}");

            result = name_a_b.GreaterThanEqual(name_a_b_dash);
            Console.WriteLine($"name_a_b.GreaterThanEqual(name_a_b_dash): {result}");
        }

        static void Main(string[] args)
        {
            TestLessThan();
            TestGreaterThan();
            TestLessThanEqual();
            TestGreaterThanEqual();
        }
    }
}
