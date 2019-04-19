using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DisposableClosure
{
    class Program
    {
        class Closure : IDisposable
        {
            private int count;
            public int GetNextNumber() => count++;

            public void Dispose()
            {
                WriteLine("破棄中です");
            }
        }

        static IEnumerable<int> SomeFunction()
        {
            using (var c = new Closure())
            {
                for (; ; )
                    yield return c.GetNextNumber();
            }
        }

        static IEnumerable<int> SomeFunction2()
        {
            var c = new Closure();
            for (; ; )
                yield return c.GetNextNumber();
        }

        static IEnumerable<int> SomeFunction3()
        {
            int count = 0;
            return Extensions.Generate(() => count++);
        }

        static void TestIteratorWithUsing()
        {
            WriteLine("TestIteratorWithUsing():");

            var query = (from n in SomeFunction() select n).Take(5);

            foreach (var s in query)
                WriteLine(s);

            WriteLine("繰り返します");
            foreach (var s in query)
                WriteLine(s);
        }

        static void TestIteratorWithoutUsing()
        {
            WriteLine("TestIteratorWithoutUsing():");

            var query = (from n in SomeFunction2() select n).Take(5);

            foreach (var s in query)
                WriteLine(s);

            WriteLine("繰り返します");
            foreach (var s in query)
                WriteLine(s);
        }

        static void TestIteratorWithClosure()
        {
            WriteLine("TestIteratorWithClosure():");

            var query = (from n in SomeFunction3() select n).Take(5);

            foreach (var s in query)
                WriteLine(s);

            WriteLine("繰り返します");
            foreach (var s in query)
                WriteLine(s);
        }

        static void Main(string[] args)
        {
            TestIteratorWithUsing();
            TestIteratorWithoutUsing();
            TestIteratorWithClosure();
        }
    }
}
