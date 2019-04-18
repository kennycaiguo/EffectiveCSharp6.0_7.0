using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableCSV
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

        public static IEnumerable<IEnumerable<int>>
            ReadNumbersFromStream(TextReader t)
        {
            var allLines = from line in t.ReadLines()
                           select line.Split(',');
            var matrixOfValues = from line in allLines
                                 select from item in line
                                        select item.DefaultParse(0);
            return matrixOfValues;
        }
    }
}
