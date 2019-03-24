using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = (from n in Enumerable.Range(0, 100)
                       select n * n).ToArray();

            foo.ForAll((n) => Console.WriteLine(n.ToString()));
        }
    }
}
