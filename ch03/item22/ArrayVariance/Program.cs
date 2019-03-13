using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayVariance
{
    // 2019.03.13 add
    using static VariantArray;

    class Program
    {
        static void TestCoVariantArray()
        {
            Console.WriteLine("TestCoVariantArray():");
            var planets = new Planet[]
            {
                new Planet { Name="earch", Mass=1000},
                new Planet{Name="jupitar", Mass=1000000 },
                new Planet {Name="mars", Mass=50}
            };
            CoVariantArray(planets);

        }

        static void TestUnsafeCoVariantArray()
        {
            Console.WriteLine("TestUnsafeCoVariantArray():");

            var planets = new Planet[]
            {
                new Planet { Name="earch", Mass=1000},
                new Planet { Name="jupitar", Mass=1000000 },
                new Planet { Name="mars", Mass=50}
            };
            try
            {
                Console.WriteLine("try call UnsafeoVariantarray(planet):");
                UnsafeCoVariantArray(planets);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("try assign Asteroid[] to CelestailBody[] variable:");
            try
            {
                CelestialBody[] spaceJunk = new Asteroid[5];
                spaceJunk[0] = new Planet();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            TestCoVariantArray();
            TestUnsafeCoVariantArray();
        }
    }
}
