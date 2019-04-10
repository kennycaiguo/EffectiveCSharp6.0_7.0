using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteSequence_Take
{
    class Program
    {
        static void Main(string[] args)
        {
            var answers = from number in AllNumbers()
                          select number;
            var smallNumbers = answers.Take(10);
            foreach (var num in smallNumbers)
                Console.WriteLine(num);
        }

        static IEnumerable<int> AllNumbers()
        {
            var number = 0;
            while (number < int.MaxValue)
            {
                yield return number++;
            }
        }
    }
}
