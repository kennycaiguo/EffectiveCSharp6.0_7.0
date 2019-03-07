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
                // 文字列補間で直接、条件式を使用することはできません。':' によって補間が終了するためです。条件式をかっこで囲んでください
            Console.WriteLine($"円周率の値は{(round ? Math.PI.ToString() : Math.PI.ToString("F2"))}");

        }
    }
}
