using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNullHandler
{
    class Program
    {
        static void Handler(Object sender, int param)
        {
            Console.WriteLine($"Handler called: param={param}");
        }

        static void Main(string[] args)
        {
            var source = new EventSource();
            source.SetHandler(Handler);
            source.RaiseUpdates();
            source.ClearHandler();
            source.RaiseUpdates();
        }
    }
}
