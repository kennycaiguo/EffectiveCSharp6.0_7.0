using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ParseCSVFile
{
    using static ParseCSV;
    class Program
    {
        private static readonly string DIR = @"C:\books\EffectiveCSharp6.0_7.0\ch04\item41\ParseCSVFile\data\";

        static void Main(string[] args)
        {
            var rowOfNumbers = ReadNumbersFromFile(DIR + "TestFile.txt");

            foreach (var line in rowOfNumbers)
            {
                foreach (int num in line)
                    Write("{0}, ", num);
                WriteLine();
            }

        }
    }
}
