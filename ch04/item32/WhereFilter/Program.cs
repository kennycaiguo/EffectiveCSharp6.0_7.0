using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace WhereFilter
{
    using static Iterator;

        class Program
    {
        static void TestWhere()
        {
            WriteLine("\nTestWhere():\n");

            var ints = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var filtered = Where(ints, n => n % 2 == 0);
            foreach (var item in filtered)
                WriteLine(item);
        }

        static void TestNullSequence()
        {
            WriteLine("\nTestNullSequence():\n");

            try
            {
                int[] ints = null;
                var filtered = Where(ints, n => n % 2 == 0);
                // エラーを発生させるためには、実際にシーケンスを走査する必要がある
                //　item29を参照
                foreach (var item in filtered) 
                    WriteLine(item);
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
        }

        static void TestNullPredicate()
        {
            WriteLine("\nTestNullPredicate():\n");

            try
            {
                var ints = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Predicate<int> pred = null;
                var filtered = Where(ints, pred);
                // エラーを発生させるためには、実際にシーケンスを走査する必要がある
                //　item29を参照
                foreach (var item in filtered)
                    WriteLine(item);
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            TestWhere();
            TestNullSequence();
            TestNullPredicate();
        }
    }
}
