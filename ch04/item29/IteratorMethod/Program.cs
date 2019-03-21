using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMethod
{
    using static Iterator;

    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in GenerateAlphabet())
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            foreach (var i in EmbeddedIterator.GenerateAlphabet())
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            var enumerable = EmbeddedIterator.GenerateAlphabet();
            var enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write("{0} ", enumerator.Current);
            }
            enumerator.Dispose();
            Console.WriteLine();
        }
    }
}
