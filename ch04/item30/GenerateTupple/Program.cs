using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateTupple
{
    class Program
    {
        private static IEnumerable<Tuple<int, int>> ProduceIndices()
        {
            for (var x = 0; x < 100; x++)
                for (var y = 0; y < 100; y++)
                    yield return Tuple.Create(x, y);
        }

        private static IEnumerable<Tuple<int, int>> QueryIndices()
        {
            return from x in Enumerable.Range(0, 100)
                    from y in Enumerable.Range(0, 100)
                    select Tuple.Create(x, y);
        }

        static void Main(string[] args)
        {
            foreach (var tupple in ProduceIndices())
                Console.WriteLine(tupple);
            Console.WriteLine("generated tuples with nested loop:");

            Console.Write("enter return-key to continue: ");
            Console.ReadLine();

            foreach (var tupple in QueryIndices())
                Console.WriteLine(tupple);
            Console.WriteLine("generated tuples with nested query:");
        }
    }
}
