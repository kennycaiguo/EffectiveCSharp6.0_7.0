using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReviveFinalizedObject
{
    class Program
    {
        static void UseBadClassLocally()
        {
            Console.WriteLine("UseBadClassLocally():");
            var badClass = new BadClass("local variable");
        }

        static void Main(string[] args)
        {
            UseBadClassLocally();
            Console.WriteLine($"FinalizedList.Count: {BadClass.FinalizedList.Count}");

            GC.Collect();
            Thread.Sleep(10);
            Console.WriteLine($"FinalizedList.Count: {BadClass.FinalizedList.Count}");
        }
    }
}
