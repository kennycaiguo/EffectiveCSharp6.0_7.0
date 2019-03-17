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
            Console.WriteLine("\nTestCompareTo():\n");

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
            Console.WriteLine("\nTestGenericSort():\n");

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

        static void TestCompareToDerived()
        {
            Console.WriteLine("\nTestCompareToDerived():\n");

            int result;
            Name name_n_n_n = new Name();
            Name name_a_n_n = new Name { Last = "a" };
            Name name_b_n_n = new Name { Last = "b" };
            DerivedName derived_a_n_n__nick = new DerivedName { Last = "a", NickName = "nick" };
            DerivedName derived_b_n_n__nick = new DerivedName { Last = "b", NickName = "nick" };

            result = name_a_n_n.CompareTo(derived_a_n_n__nick);
            Console.WriteLine($"name_a_n_n.CompareTo(derived_a_n_n__nick): {result}");

            result = name_a_n_n.CompareTo(derived_b_n_n__nick);
            Console.WriteLine($"name_a_n_n.CompareTo(derived_b_n_n__nick): {result}");

            result = name_b_n_n.CompareTo(derived_a_n_n__nick);
            Console.WriteLine($"name_b_n_n.CompareTo(derived_a_n_n__nick): {result}");

            result = derived_a_n_n__nick.CompareTo(name_a_n_n);
            Console.WriteLine($"derived_a_n_n__nick.CompareTo(name_a_n_n): {result}");

            result = derived_a_n_n__nick.CompareTo(name_b_n_n);
            Console.WriteLine($"derived_a_n_n__nick.CompareTo(name_b_n_n): {result}");

            result = derived_b_n_n__nick.CompareTo(name_a_n_n);
            Console.WriteLine($"derived_b_n_n__nick.CompareTo(name_a_n_n): {result}");
        }

        static void TestEquals()
        {
            Console.WriteLine("\nTestEquals():\n");

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

            result = name_n_n_n.Equals(name_n_n_n);
            Console.WriteLine($"name_n_n_n.Equals(name_n_n_n): {result}");

            result = name_n_n_n.Equals(name_null);
            Console.WriteLine($"name_n_n_n.Equals(name_null): {result}");

            result = name_a_n_n.Equals(name_b_n_n);
            Console.WriteLine($"name_a_n_n.Equals(name_b_n_n): {result}");

            result = name_n_a_n.Equals(name_n_b_n);
            Console.WriteLine($"name_n_a_n.Equals(name_n_b_n): {result}");

            result = name_n_n_a.Equals(name_n_n_b);
            Console.WriteLine($"name_n_n_a.Equals(name_n_n_b): {result}");

            result = name_a_a_a.Equals(name_a_a_a_dash);
            Console.WriteLine($"name_a_a_a.Equals(name_a_a_a_dash): {result}");
        }

        static void Main(string[] args)
        {
            TestCompareTo();
            TestGenericSort();
            TestNonGenericSort();
            TestCompareToDerived();

            TestEquals();
        }
    }
}
