using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    class Program
    {
        public static IEnumerable<int> MakeSequence()
        {
            var counter = 0;
            var numbers = Extensions.Generate(30, () => counter++);
            return numbers;
        }

        private class Closure
        {
            public int generatedCounter;
            public int generatedFunc() => generatedCounter++;
        }

        public static IEnumerable<int> MakeSequence2()
        {
            var c = new Closure();
            c.generatedCounter = 0;
            var sequence = Extensions.Generate(30, new Func<int>(c.generatedFunc));
            return sequence;
        }

        static void Main(string[] args)
        {
            foreach (var elem in MakeSequence())
                Console.Write($"{elem} ");
            Console.WriteLine();

            foreach (var elem in MakeSequence2())
                Console.Write($"{elem} ");
            Console.WriteLine();
        }
    }
}
