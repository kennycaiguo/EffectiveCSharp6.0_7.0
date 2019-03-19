using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadRelationOperators
{
    class Program
    {
        static void TestLessOperator()
        {
            Console.WriteLine("\nTestLessOperator():\n");

            Name name_null = null;
            Name name_a_n_n = new Name { Last = "a" };
            Name name_a_n_n_dash = new Name { Last = "a" };
            Name name_b_n_n = new Name { Last = "b" };
            DerivedName derived_a_n_n__nick = new DerivedName { Last = "a", NickName = "nick" };
            DerivedName derived_b_n_n__nick = new DerivedName { Last = "b", NickName = "nick" };
            bool result;

            result = name_null < name_null;
            Console.WriteLine($"name_null < name_null: {result}");

            result = name_null < name_a_n_n;
            Console.WriteLine($"name_null < name_a_n_n: {result}");

            result = name_a_n_n < name_null;
            Console.WriteLine($"name_a_n_n < name_null: {result}");

            result = name_a_n_n < name_a_n_n;
            Console.WriteLine($"name_a_n_n < name_a_n_n: {result}");

            result = name_a_n_n < name_a_n_n_dash;
            Console.WriteLine($"name_a_n_n < name_a_n_n_dash: {result}");

            result = name_a_n_n < name_b_n_n;
            Console.WriteLine($"name_a_n_n < name_b_n_n: {result}");

            result = name_b_n_n < name_a_n_n;
            Console.WriteLine($"name_b_n_n < name_a_n_n: {result}");

            result = name_a_n_n < derived_a_n_n__nick;
            Console.WriteLine($"name_a_n_n < derived_a_n_n__nick: {result}");

            result = derived_a_n_n__nick < name_a_n_n;
            Console.WriteLine($"derived_a_n_n__nick < name_a_n_n: {result}");

            result = derived_a_n_n__nick < derived_b_n_n__nick;
            Console.WriteLine($"derived_a_n_n__nick < derived_b_n_n__nick: {result}");
        }

        static void TestGreaterOperator()
        {
            Console.WriteLine("\nTestGreaterOperator():\n");

            Name name_null = null;
            Name name_a_n_n = new Name { Last = "a" };
            Name name_a_n_n_dash = new Name { Last = "a" };
            Name name_b_n_n = new Name { Last = "b" };
            DerivedName derived_a_n_n__nick = new DerivedName { Last = "a", NickName = "nick" };
            DerivedName derived_b_n_n__nick = new DerivedName { Last = "b", NickName = "nick" };
            bool result;

            result = name_null > name_null;
            Console.WriteLine($"name_null > name_null: {result}");

            result = name_null > name_a_n_n;
            Console.WriteLine($"name_null > name_a_n_n: {result}");

            result = name_a_n_n > name_null;
            Console.WriteLine($"name_a_n_n > name_null: {result}");

            result = name_a_n_n > name_a_n_n;
            Console.WriteLine($"name_a_n_n > name_a_n_n: {result}");

            result = name_a_n_n > name_a_n_n_dash;
            Console.WriteLine($"name_a_n_n > name_a_n_n_dash: {result}");

            result = name_a_n_n > name_b_n_n;
            Console.WriteLine($"name_a_n_n > name_b_n_n: {result}");

            result = name_b_n_n > name_a_n_n;
            Console.WriteLine($"name_b_n_n > name_a_n_n: {result}");

            result = name_a_n_n > derived_a_n_n__nick;
            Console.WriteLine($"name_a_n_n > derived_a_n_n__nick: {result}");

            result = derived_a_n_n__nick > name_a_n_n;
            Console.WriteLine($"derived_a_n_n__nick > name_a_n_n: {result}");

            result = derived_a_n_n__nick > derived_b_n_n__nick;
            Console.WriteLine($"derived_a_n_n__nick > derived_b_n_n__nick: {result}");
        }

        static void TestLessEqualOperator()
        {
            Console.WriteLine("\nTestLessEqualOperator():\n");

            Name name_null = null;
            Name name_a_n_n = new Name { Last = "a" };
            Name name_a_n_n_dash = new Name { Last = "a" };
            Name name_b_n_n = new Name { Last = "b" };
            DerivedName derived_a_n_n__nick = new DerivedName { Last = "a", NickName = "nick" };
            DerivedName derived_b_n_n__nick = new DerivedName { Last = "b", NickName = "nick" };
            bool result;

            result = name_null <= name_null;
            Console.WriteLine($"name_null <= name_null: {result}");

            result = name_null <= name_a_n_n;
            Console.WriteLine($"name_null <= name_a_n_n: {result}");

            result = name_a_n_n <= name_null;
            Console.WriteLine($"name_a_n_n <= name_null: {result}");

            result = name_a_n_n <= name_a_n_n;
            Console.WriteLine($"name_a_n_n <= name_a_n_n: {result}");

            result = name_a_n_n <= name_a_n_n_dash;
            Console.WriteLine($"name_a_n_n <= name_a_n_n_dash: {result}");

            result = name_a_n_n <= name_b_n_n;
            Console.WriteLine($"name_a_n_n <= name_b_n_n: {result}");

            result = name_b_n_n <= name_a_n_n;
            Console.WriteLine($"name_b_n_n <= name_a_n_n: {result}");

            result = name_a_n_n <= derived_a_n_n__nick;
            Console.WriteLine($"name_a_n_n <= derived_a_n_n__nick: {result}");

            result = derived_a_n_n__nick <= name_a_n_n;
            Console.WriteLine($"derived_a_n_n__nick <= name_a_n_n: {result}");

            result = derived_a_n_n__nick <= derived_b_n_n__nick;
            Console.WriteLine($"derived_a_n_n__nick <= derived_b_n_n__nick: {result}");
        }

        static void TestGreaterEqualOperator()
        {
            Console.WriteLine("\nTestGreaterEqualOperator():\n");

            Name name_null = null;
            Name name_a_n_n = new Name { Last = "a" };
            Name name_a_n_n_dash = new Name { Last = "a" };
            Name name_b_n_n = new Name { Last = "b" };
            DerivedName derived_a_n_n__nick = new DerivedName { Last = "a", NickName = "nick" };
            DerivedName derived_b_n_n__nick = new DerivedName { Last = "b", NickName = "nick" };
            bool result;

            result = name_null >= name_null;
            Console.WriteLine($"name_null >= name_null: {result}");

            result = name_null >= name_a_n_n;
            Console.WriteLine($"name_null >= name_a_n_n: {result}");

            result = name_a_n_n >= name_null;
            Console.WriteLine($"name_a_n_n >= name_null: {result}");

            result = name_a_n_n >= name_a_n_n;
            Console.WriteLine($"name_a_n_n >= name_a_n_n: {result}");

            result = name_a_n_n >= name_a_n_n_dash;
            Console.WriteLine($"name_a_n_n >= name_a_n_n_dash: {result}");

            result = name_a_n_n >= name_b_n_n;
            Console.WriteLine($"name_a_n_n >= name_b_n_n: {result}");

            result = name_b_n_n >= name_a_n_n;
            Console.WriteLine($"name_b_n_n >= name_a_n_n: {result}");

            result = name_a_n_n >= derived_a_n_n__nick;
            Console.WriteLine($"name_a_n_n >= derived_a_n_n__nick: {result}");

            result = derived_a_n_n__nick >= name_a_n_n;
            Console.WriteLine($"derived_a_n_n__nick >= name_a_n_n: {result}");

            result = derived_a_n_n__nick >= derived_b_n_n__nick;
            Console.WriteLine($"derived_a_n_n__nick >= derived_b_n_n__nick: {result}");
        }

        static void Main(string[] args)
        {
            TestLessOperator();
            TestGreaterOperator();
            TestLessEqualOperator();
            TestGreaterEqualOperator();
        }
    }
}
