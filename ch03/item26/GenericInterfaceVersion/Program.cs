using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceVersion
{
    class Program
    {
        static void TestCompareTo()
        {
            Console.WriteLine("TestCompareTo():");

            string s_a = "a";
            string s_b = "b";
            string s_null = null;
            int result;
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

            result = name_n_n_n.CompareTo(name_n_n_n);
            Console.WriteLine($"name_n_n_n.CompareTo(name_n_n_n): {result}");

            result = name_n_n_n.CompareTo(name_null);
            Console.WriteLine($"name_n_n_n.CompareTo(name_null): {result}");

            result = name_a_n_n.CompareTo(name_b_n_n);
            Console.WriteLine($"name_a_n_n.CompareTo(name_b_n_n): {result}");

            result = name_b_n_n.CompareTo(name_a_n_n);
            Console.WriteLine($"name_b_n_n.CompareTo(name_a_n_n): {result}");

            result = name_n_a_n.CompareTo(name_n_b_n);
            Console.WriteLine($"name_n_a_n.CompareTo(name_n_b_n): {result}");

            result = name_n_b_n.CompareTo(name_n_a_n);
            Console.WriteLine($"name_n_b_n.CompareTo(name_n_a_n): {result}");

            result = name_n_n_a.CompareTo(name_n_n_b);
            Console.WriteLine($"name_n_n_a.CompareTo(name_n_n_b): {result}");

            result = name_n_n_b.CompareTo(name_n_n_a);
            Console.WriteLine($"name_n_n_b.CompareTo(name_n_n_a): {result}");

            result = name_a_a_a.CompareTo(name_a_a_a_dash);
            Console.WriteLine($"name_a_a_a.CompareTo(name_a_a_a_dash): {result}");
        }
        
        static void TestGenericSort()
        {
            Console.WriteLine("TestGenericSort():");

            var list = new List<Name>
            {
                new Name { Last = "a" }, new Name { Last = "b" },
                new Name { First = "a" }, new Name { First = "b" },
                new Name { Middle = "a" }, new Name { Middle = "b" }
            };
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        static void TestNonGenericSort()
        {
            Console.WriteLine("TestNonGenericSort():");

            var list = new ArrayList
            {
                new Name { Last = "a" }, new Name { Last = "b" },
                new Name { First = "a" }, new Name { First = "b" },
                new Name { Middle = "a" }, new Name { Middle = "b" }
            };

            try
            {
                list.Sort();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            TestCompareTo();
            TestGenericSort();
            TestNonGenericSort();
        }
    }
}
