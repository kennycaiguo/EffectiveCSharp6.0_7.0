using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    public class VariantGeneric
    {
        public static void CovariantGeneric(IEnumerable<CelestialBody> baseItems)
        {
            foreach (var thing in baseItems)
            {
                Console.WriteLine("{0} の質量は {1} Kgです",
                    thing.Name, thing.Mass);
            }
        }

        public static void InvariantGeneric(IList<CelestialBody> baseItems)
        {
            baseItems[0] = new Asteroid { Name = "Hygiea", Mass = 8.85e19 };
        }
    }
}
