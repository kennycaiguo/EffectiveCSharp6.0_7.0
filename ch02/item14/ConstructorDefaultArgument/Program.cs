using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDefaultArgument
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

            // new制約を確認
            var list = new List<MyClass> { new MyClass(10), new MyClass(100, "Sophia") };
            foreach (var item in list)
            {
                Console.WriteLine($"Name:{item.Name}, Collection.Capacity:{item.Collection.Capacity}");
            }
        }
    }
}
