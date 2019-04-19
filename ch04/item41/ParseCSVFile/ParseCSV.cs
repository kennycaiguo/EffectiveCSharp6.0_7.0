using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseCSVFile
{
    public static class ParseCSV
    {
        public static IEnumerable<string> ParseFile(string path)
        {
            using (var r = new StreamReader(File.OpenRead(path)))
            {
                var txt = r.ReadLine();
                while (txt != null)
                {
                    yield return txt;
                    txt = r.ReadLine();
                }
            }
        }

        public static int DefaultParse(this string input, int defaultValue)
        {
            int answer;
            return (int.TryParse(input, out answer))
                ? answer : defaultValue;
        }

        public static IEnumerable<IEnumerable<int>>
            ReadNumbersFromFile(string path)
        {
            var allLines = from line in ParseFile(path)
                           select line.Split(',');
            var matrixOfValues = from line in allLines
                                 select from item in line
                                        select item.DefaultParse(0);
            return matrixOfValues;
        }
    }
}
