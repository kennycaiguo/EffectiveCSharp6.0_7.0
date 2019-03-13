using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraVariance
{
    abstract public class CelestialBody : IComparable<CelestialBody>
    {
        public double Mass { get; set; }
        public string Name { get; set; }

        public int CompareTo(CelestialBody other)
        {
            if (other == null)
                return 1;
            return Mass.CompareTo(other.Mass);
        }
    }

    public class Planet : CelestialBody
    {
        // 省略
    }

    public class Moon : CelestialBody
    {
        // 省略
    }
    public class Asteroid : CelestialBody
    {
        // 省略
    }
}
