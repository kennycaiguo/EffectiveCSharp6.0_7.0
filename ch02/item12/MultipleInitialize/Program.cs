using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 val1 = new MyClass2();
            MyClass2 val2 = new MyClass2(10);

            Console.WriteLine($"default constructor: {val1.Labels.Capacity}, constructor with size: {val2.Labels.Capacity}");

            MyClass2_internal val1_internal = new MyClass2_internal();
            MyClass2_internal val2_internal = new MyClass2_internal(10);

            Console.WriteLine($"default constructor: {val1_internal.Labels.Capacity}, constructor with size: {val2_internal.Labels.Capacity}");
        }
    }
}
