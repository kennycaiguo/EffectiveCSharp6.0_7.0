using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeDisposableTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new MyResourceHog();
            var derivedResource = new DerivedResourceHog();

            Console.WriteLine("finishing Main()");
        }
    }
}
