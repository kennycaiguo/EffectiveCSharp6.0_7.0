using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsField
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\books\EffectiveCSharp6.0_7.0\ch03\item23\DelegateAsField\data\point.txt";
            using (StreamReader reader = new StreamReader(filename))
            {
                var readValues = new InputCollection<Point>(
                    (inputStream) => new Point(inputStream));

                // EOFまでテキストを読んで、readValuesにPointを追加する：
                // Point(TextReader)コンストラクタはEOFに遭遇すると、
                // line.Split(',')の箇所で、NullReferenceExceptionを発生する
                while (true)
                {
                    try
                    {
                        readValues.ReadFromStream(reader);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("meet EOF");
                        break;
                    }
                }

                foreach (var pt in readValues.Values)
                {
                    Console.WriteLine(pt.ToString());
                }
            }
        }
    }
}
