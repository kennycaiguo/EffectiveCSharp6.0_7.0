using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.02.24 add
using System.Threading;

namespace TestThreadSafe
{
    class Program
    {
        private const int LOOP_COUNT = 1000;
        private const int RAISE_COUNT = 500;
        private const int sleep_ms = 10;

        static void Main(string[] args)
        {
            var source = new EventSource();
            var client = new ClientThread(source);

            Thread t = new Thread(new ThreadStart(client.exec));
            t.Start();

            try
            {
                for (int i = 0; i < LOOP_COUNT; ++i)
                {
                    Thread.Sleep(sleep_ms);
                    for (int j = 0; j < RAISE_COUNT; ++j)
                    {
                        source.RaiseUpdates();
                    }
                }
                Console.WriteLine("all done");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Execption occured: {e}");
                client.StopRequest = true;
            }
            Console.WriteLine($"LastCounter: {client.LastCounter}");
            t.Join();
        }
    }
}
