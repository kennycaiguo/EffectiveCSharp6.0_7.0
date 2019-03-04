using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var var1 = new MyClass();
            var var2 = new MyClass(10);
            var var3 = new MyClass(100, "Sophia");

            Console.WriteLine($"var1.Name:{var1.Name}, var1.Collection.Capacity:{var1.Collection.Capacity}");
            Console.WriteLine($"var2.Name:{var2.Name}, var2.Collection.Capacity:{var2.Collection.Capacity}");
            Console.WriteLine($"var3.Name:{var3.Name}, var3.Collection.Capacity:{var3.Collection.Capacity}");
        }
    }
}
