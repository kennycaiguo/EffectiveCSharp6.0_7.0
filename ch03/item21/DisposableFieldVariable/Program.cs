using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableFieldVariable
{
    class Program
    {
        static void TestNonDisposableEngine()
        {
            Console.WriteLine("TestNonDisposableEngine():");

            using (var driver = new EngineDriver2<NonDisposableEngine>())
            {
                driver.GetThingsDone();
            }
        }

        static void TestDisposableEngine()
        {
            Console.WriteLine("TestDisposableEngine():");

            using (var driver = new EngineDriver2<DisposableEngine>())
            {
                driver.GetThingsDone();
            }
        }

        static void TestMultipleDispose()
        {
            Console.WriteLine("TestMultipleDispose():");

            var driver = new EngineDriver2<DisposableEngine>();
            driver.GetThingsDone();
            driver.Dispose();
            driver.Dispose();
        }

        static void Main(string[] args)
        {
            TestNonDisposableEngine();
            TestDisposableEngine();
            TestMultipleDispose();
        }
    }
}
