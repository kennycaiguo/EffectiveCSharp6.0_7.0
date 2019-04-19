using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCallback
{
    public static class ParseCSV
    {
        public static IEnumerable<string> ReadLines(this TextReader reader)
        {
            var txt = reader.ReadLine();
            while (txt != null)
            {
                yield return txt;
                txt = reader.ReadLine();
            }
        }

        public static int DefaultParse(this string input, int defaultValue)
        {
            int answer;
            return (int.TryParse(input, out answer))
                ? answer : defaultValue;
        }

    }
}
