using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = MySingleton2.TheOnly;
            var var2 = MySingleton2.TheOnly;

            Console.WriteLine($"var1.Equals(var2) ? {var1.Equals(var2)}");
        }
    }
}
