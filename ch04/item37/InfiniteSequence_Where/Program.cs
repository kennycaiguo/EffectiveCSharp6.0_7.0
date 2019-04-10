using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteSequence_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            var answers = from number in AllNumbers()
                          where number < 10
                          select number;
            foreach (var num in answers)
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
