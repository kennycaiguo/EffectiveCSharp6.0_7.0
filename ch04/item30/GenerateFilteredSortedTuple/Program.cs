using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateFilteredSortedTuple
{
    class Program
    {
        private static IEnumerable<Tuple<int, int>> ProduceIndices3()
        {
            var storage = new List<Tuple<int, int>>();
            for (var x = 0; x < 100; x++)
                for (var y = 0; y < 100; y++)
                    if (x + y < 100)
                        storage.Add(Tuple.Create(x, y));

            storage.Sort((point1, point2) =>
                (point2.Item1 * point2.Item1 + point2.Item2 * point2.Item2)
                .CompareTo(
                    point1.Item1 * point1.Item1 + point1.Item2 * point1.Item2));
            return storage;
        }

        private static IEnumerable<Tuple<int, int>> QueryIndices3()
        {
            return from x in Enumerable.Range(0, 100)
                   from y in Enumerable.Range(0, 100)
                   where x + y < 100
                   orderby (x*x + y*y) descending
                   select Tuple.Create(x, y);
        }

        static void Main(string[] args)
        {
            foreach (var tupple in ProduceIndices3())
                Console.WriteLine(tupple);
            Console.WriteLine("generated filtered sorted tuples with nested loop:");

            Console.Write("enter return-key to continue: ");
            Console.ReadLine();

            foreach (var tupple in QueryIndices3())
                Console.WriteLine(tupple);
            Console.WriteLine("generated filtered sorted tuples with nested query:");
        }
    }
}
