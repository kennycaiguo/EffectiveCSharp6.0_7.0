using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LinqAnalyzer;
namespace SelectMethod
{
    class Program
    {
        static void TestSimpleSelect()
        {
            Console.WriteLine("TestSimpleSelect():");

            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var allNumbers = from n in numbers select n;
            foreach (var n in allNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            allNumbers = numbers.Select(n => n);
            foreach (var n in allNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            var tr_numbers = new LinqTracer<int>(numbers);
            var tr_allNumbers = from n in tr_numbers select n;
            foreach (var n in tr_allNumbers.AsEnumerable())
                Console.Write($"{n} ");
            Console.WriteLine();
        }

        static void TestValueConversionSelect()
        {
            Console.WriteLine("\nTestValueConversionSelect():");

            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var allNumbers = from n in numbers
                             where n < 5
                             select n * n;
            foreach (var n in allNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            allNumbers = numbers.Where(n => n < 5).Select(n => n * n);
            foreach (var n in allNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            var tr_numbers = new LinqTracer<int>(numbers);
            var tr_allNumbers = from n in tr_numbers
                                where n < 5
                                select n * n;
            foreach (var n in tr_allNumbers.AsEnumerable())
                Console.Write($"{n} ");
            Console.WriteLine();
        }

        static void TestTypeConversionSelect()
        {
            Console.WriteLine("\nTestTypeConversionSelect():");

            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var allNumbers = from n in numbers
                             select new { Number = n, Square = n * n };
            foreach (var n in allNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            allNumbers = numbers.Select(n => new { Number = n, Square = n * n });
            foreach (var n in allNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            var tr_numbers = new LinqTracer<int>(numbers);
            var tr_allNumbers = from n in tr_numbers
                                select new { Number = n, Square = n * n };
            foreach (var n in tr_allNumbers.AsEnumerable())
                Console.Write($"{n} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestSimpleSelect();
            TestValueConversionSelect();
            TestTypeConversionSelect();
        }
    }
}
