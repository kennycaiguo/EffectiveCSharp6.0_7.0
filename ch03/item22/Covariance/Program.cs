using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    using static VariantGeneric;
    class Program
    {
        static void TestCovariantGeneric()
        {
            Console.WriteLine("TestCovariantGeneric():");
            IEnumerable<Planet> planets = new List<Planet>
            {
                new Planet { Name="earch", Mass=1000},
                new Planet{Name="jupitar", Mass=1000000 },
                new Planet {Name="mars", Mass=50}
            };
            CovariantGeneric(planets);
        }

        static void TestInvariantGeneric()
        {
            Console.WriteLine("TestInvariantGeneric():");
            IList<Planet> planets = new List<Planet>
            {
                new Planet { Name="earch", Mass=1000},
                new Planet{Name="jupitar", Mass=1000000 },
                new Planet {Name="mars", Mass=50}
            };
            // compile error
            //InvariantGeneric(planets);
            // 'System.Collections.Generic.IList<Covariance.Planet>' から 
            // 'System.Collections.Generic.IList<Covariance.CelestialBody>' 
            // へ変換することはできません。
        }

        static void Main(string[] args)
        {
            TestCovariantGeneric();
            TestInvariantGeneric();
        }
    }
}
