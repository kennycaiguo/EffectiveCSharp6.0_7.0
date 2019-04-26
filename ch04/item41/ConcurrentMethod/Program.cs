using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentMethod
{
    class Program
    {
        private static void SomeMethod(ref int i)
        {
            i = 123;
        }

        private static void DoSomethingInBackground()
        {
            var i = 0;
            var thread = new Thread(delegate () { SomeMethod(ref i); });
            thread.Start();

            for (var j = 0; j < 10; j++)
                Console.WriteLine($"i: {i}");
        }

        static void Main(string[] args)
        {
            DoSomethingInBackground();
        }
    }
}
