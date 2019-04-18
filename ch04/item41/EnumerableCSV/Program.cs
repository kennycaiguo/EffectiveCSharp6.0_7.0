using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace EnumerableCSV
{
    using static ParseCSV;
    class Program
    {
        private static readonly string DIR = @"C:\books\EffectiveCSharp6.0_7.0\ch04\item41\EnumerableCSV\data\";

        static void TestParseCSV()
        {
            Console.WriteLine("TestParseCSV():");

            var t = new StreamReader(File.OpenRead(DIR + "TestFile.txt"));
            var rowOfNumbers = ReadNumbersFromStream(t);

            foreach (var line in rowOfNumbers)
            {
                foreach (int num in line)
                    Write("{0}, ", num);
                WriteLine();
            }
        }

        static void TestParseCSVwithAutoClose()
        {
            Console.WriteLine("TestParseCSVwithAutoClose():");

            IEnumerable<IEnumerable<int>> rowOfNumbers;
            using (TextReader t = new StreamReader(File.OpenRead(DIR + "TestFile.txt")))
                rowOfNumbers = ReadNumbersFromStream(t);

            foreach (var line in rowOfNumbers)
            {
                foreach (int num in line)
                    Write("{0}, ", num);
                WriteLine();
            }
        }

        static void TestParseCSVwithinUsing()
        {
            Console.WriteLine("TestParseCSVwithinUsing():");

            using (TextReader t = new StreamReader(File.OpenRead(DIR + "TestFile.txt")))
            {
                var rowOfNumbers = ReadNumbersFromStream(t);

                foreach (var line in rowOfNumbers)
                {
                    foreach (int num in line)
                        Write("{0}, ", num);
                    WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            TestParseCSV();
            try
            {
                TestParseCSVwithAutoClose();
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
            TestParseCSVwithinUsing();
        }
    }
}
