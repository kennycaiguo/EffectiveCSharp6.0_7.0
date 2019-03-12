using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDisposableVariable
{
    class Program
    {
        static void TestEngineDriverOne()
        {
            Console.WriteLine("TestEngineDriverOne():");

            var driver = new EngineDriverOne<DisposableEngine>();
            driver.GetThingsDone();

        }

        static void TestEngineDriver2()
        {
            Console.WriteLine("TestEngineDriver2():");

            var driver = new EngineDriver2<DisposableEngine>();
            driver.GetThingsDone();

            var driver2 = new EngineDriver2<NonDisposableEngine>();
            driver2.GetThingsDone();
        }

        static void Main(string[] args)
        {
            TestEngineDriverOne();
            TestEngineDriver2();
        }
    }
}
