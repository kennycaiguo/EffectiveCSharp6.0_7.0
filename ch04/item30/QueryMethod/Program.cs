using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryMethod
{
    class Program
    {
        private static IEnumerable<Tuple<int, int>> QueryMethod3()
        {
            return Enumerable.Range(0, 100).
                    SelectMany(x => Enumerable.Range(0, 100),
                        (x, y) => Tuple.Create(x, y)).
                    Where(pt => pt.Item1 + pt.Item2 < 100).
                    OrderByDescending(pt =>
                        pt.Item1 * pt.Item1 + pt.Item2 * pt.Item2);
        }

        static void Main(string[] args)
        {
            foreach (var tupple in QueryMethod3())
                Console.WriteLine(tupple);
            Console.WriteLine("generated filtered sorted tuples with query method:");
        }
    }
}
