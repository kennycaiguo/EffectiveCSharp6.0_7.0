using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementsNonGenericIComparable
{
    class Program
    {
        static void TestNonGenericSort()
        {
            Console.WriteLine("\nTestNonGenericSort():\n");

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

        static void TestNonGenericCompareTo()
        {
            Console.WriteLine("\nTestNonGenericCompareto():\n");

            int result;
            IComparable name_null = null;
            IComparable name_n_n_n = new Name();
            IComparable name_a_n_n = new Name { Last = "a" };
            IComparable name_a_n_n_dash = new Name { Last = "a" };
            IComparable name_b_n_n = new Name { Last = "b" };
            IComparable derived_a_n_n__nick = new DerivedName { Last = "a", NickName = "nick" };
            IComparable derived_b_n_n__nick = new DerivedName { Last = "b", NickName = "nick" };
            IComparable string_a = "a";

            try
            {
                result = name_a_n_n.CompareTo(name_null);
                Console.WriteLine($"name_a_n_n.CompareTo(name_null): {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            result = name_a_n_n.CompareTo(name_a_n_n);
            Console.WriteLine($"name_a_n_n.CompareTo(name_a_n_n): {result}");

            result = name_a_n_n.CompareTo(name_b_n_n);
            Console.WriteLine($"name_a_n_n.CompareTo(name_b_n_n): {result}");

            result = name_b_n_n.CompareTo(name_a_n_n);
            Console.WriteLine($"name_b_n_n.CompareTo(name_a_n_n): {result}");

            result = name_a_n_n.CompareTo(name_a_n_n_dash);
            Console.WriteLine($"name_a_n_n.CompareTo(name_a_n_n_dash): {result}");

            try
            {
                result = name_a_n_n.CompareTo(derived_a_n_n__nick);
                Console.WriteLine($"name_a_n_n.CompareTo(derived_a_n_n__nick): {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            result = name_a_n_n.CompareTo(derived_b_n_n__nick);
            Console.WriteLine($"name_a_n_n.CompareTo(derived_b_n_n__nick): {result}");

            result = name_b_n_n.CompareTo(derived_a_n_n__nick);
            Console.WriteLine($"name_b_n_n.CompareTo(derived_a_n_n__nick): {result}");

            try
            {
                result = name_a_n_n.CompareTo(string_a);
                Console.WriteLine($"name_a_n_n.CompareTo(string_a): {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            TestNonGenericSort();
            TestNonGenericCompareTo();
        }
    }
}
