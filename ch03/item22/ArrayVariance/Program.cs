using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVariance
{
    class Program
    {
        static void TestCoVariantArray()
        {
            Console.WriteLine("TestCoVariantArray():");
            var array = new Planet[]
            {
                new Planet { Name="earch", Mass=1000},
                new Planet{Name="jupitar", Mass=1000000 },
                new Planet {Name="mars", Mass=50}
            };
            VariantArray.CoVariantArray(array);

        }

        static void TestUnsafeCoVariantArray()
        {
            Console.WriteLine("TestUnsafeCoVariantArray():");
            var planets = new Planet[]
            {
                new Planet { Name="earch", Mass=1000},
                new Planet{Name="jupitar", Mass=1000000 },
                new Planet {Name="mars", Mass=50}
            };
            VariantArray.UnsafeCoVariantArray(planets);

        }

        static void Main(string[] args)
        {
            TestCoVariantArray();
            TestUnsafeCoVariantArray();
        }
    }
}
