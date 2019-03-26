using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ZipStringSequence
{
    class Program
    {
        public static IEnumerable<string> Zip(IEnumerable<string> first,
            IEnumerable<string> second)
        {
            using (var firstSequence = first.GetEnumerator())
            {
                using (var secondeSequence = second.GetEnumerator())
                {
                    while (firstSequence.MoveNext() &&
                        secondeSequence.MoveNext())
                    {
                        yield return string.Format("{0} {1}",
                            firstSequence.Current,
                            secondeSequence.Current);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var first = new string[] { "i", "ii", "iii", "iv", "v", "vi" };
            var second = new string[] { "one", "two", "three", "four", "five" };
            foreach (var pair in Zip(first, second))
                WriteLine(pair);
        }
    }
}
