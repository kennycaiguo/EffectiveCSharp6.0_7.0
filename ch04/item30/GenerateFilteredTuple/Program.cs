using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateFilteredTuple
{
    class Program
    {
        private static IEnumerable<Tuple<int, int>> ProduceIndices2()
        {
            for (var x = 0; x < 100; x++)
                for (var y = 0; y < 100; y++)
                    if (x + y < 100)
                        yield return Tuple.Create(x, y);
        }

        private static IEnumerable<Tuple<int, int>> QueryIndices2()
        {
            return from x in Enumerable.Range(0, 100)
                   from y in Enumerable.Range(0, 100)
                   where x + y < 100
                   select Tuple.Create(x, y);
        }

        static void Main(string[] args)
        {
            foreach (var tupple in ProduceIndices2())
                Console.WriteLine(tupple);
            Console.WriteLine("generated filtered tuples with nested loop:");

            Console.Write("enter return-key to continue: ");
            Console.ReadLine();

            foreach (var tupple in QueryIndices2())
                Console.WriteLine(tupple);
            Console.WriteLine("generated filtered tuples with nested query:");
        }
    }
}
