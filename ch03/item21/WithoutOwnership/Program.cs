using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOwnership
{
    class Program
    {
        static void TestNonDisposableEngine()
        {
            Console.WriteLine("TestNonDisposableEngine():");

            var engine = new NonDisposableEngine();
            var driver = new EngineDriver<NonDisposableEngine>(engine);
            driver.GetThingsDone();
        }

        static void TestDisposableEngine()
        {
            Console.WriteLine("TestDisposableEngine():");

            using (var engine = new DisposableEngine())
            {
                var driver = new EngineDriver<DisposableEngine>(engine);
                driver.GetThingsDone();
            }
        }

        static void Main(string[] args)
        {
            TestNonDisposableEngine();
            TestDisposableEngine();
        }
    }
}
