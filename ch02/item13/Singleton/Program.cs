using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = MySingleton.TheOnly;
            var singleton2 = MySingleton.TheOnly;
        }
    }
}
