using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraVariance
{
    class Program
    {
        static void CompareCelestialBody()
        {
            Console.WriteLine("CompareCelestialBody():");
            var earch = new Planet { Name = "Earch", Mass = 5.5e22 };
            var moon = new Moon { Name = "Moon", Mass = 2.2e21 };
            var hygioa = new Asteroid { Name = "Hygia", Mass = 8.85e19 };
            int result;

            result = earch.CompareTo(moon);
            Console.WriteLine($"earch.CompareTo(moon): {result}");

            result = moon.CompareTo(hygioa);
            Console.WriteLine($"moon.CompareTo(hygioa): {result}");

            result = hygioa.CompareTo(earch);
            Console.WriteLine($"hygioa.CompareTo(earch): {result}");
        }

        static void Main(string[] args)
        {
            CompareCelestialBody();
        }
    }
}
