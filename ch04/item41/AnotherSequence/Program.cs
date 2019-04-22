using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherSequence
{
    class Program
    {
        public IEnumerable<int> MakeAnotherSequence()
        {
            var counter = 0;

            var interim = Extensions.Generate(30,
                () => counter++);
            //var gen = new Random();
            var gen = new Random();

            var numbers = from n in interim
                          // select gen.Next() - n;
                          select gen.Next(30) - n;
            return numbers;
        }

        static void TestMakeAnotherSequence()
        {
            Console.WriteLine("TestMakeAnotherSequence():");

            var prog = new Program();
            var sequence = prog.MakeAnotherSequence();
            foreach (var e in sequence)
                Console.Write($"{e} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestMakeAnotherSequence();
        }
    }
}
