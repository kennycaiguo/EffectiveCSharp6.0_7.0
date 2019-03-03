using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            Console.WriteLine($"Labels: {myClass.Labels}, Labels.Count: {myClass.Labels.Count}");
        }
    }
}
