using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"円周率の値は{Math.PI}");
            Console.WriteLine($"円周率の値は{Math.PI.ToString()}");
            Console.WriteLine($"円周率の値は{Math.PI.ToString("F2")}");
            Console.WriteLine($"円周率の値は{Math.PI:F2}");

            bool round = false;
            // not compiled
            //Console.WriteLine($"円周率の値は{round ? Math.PI.ToString() : Math.PI.ToString("F2")}");
            Console.WriteLine($"円周率の値は{(round ? Math.PI.ToString() : Math.PI.ToString("F2"))}");

        }
    }
}
