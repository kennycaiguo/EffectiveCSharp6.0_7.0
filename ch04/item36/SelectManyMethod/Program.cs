using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyMethod
{
    class Program
    {
        static void Test_multiple_fromPhrase()
        {
            Console.WriteLine("Test_multiple_fromPhase():");

            int[] odds = { 1, 3, 5, 7 };
            int[] evens = { 2, 4, 6, 8 };
            var pairs = from oddNumber in odds
                        from evenNumber in evens
                        select new
                        {
                            oddNumber,
                            evenNumber,
                            Sum = oddNumber + evenNumber
                        };
            foreach (var item in pairs)
                Console.WriteLine(item);
        }

        static void Test_SelectManyMethod()
        {
            Console.WriteLine("\nTest_SelectManyMethod():");

            int[] odds = { 1, 3, 5, 7 };
            int[] evens = { 2, 4, 6, 8 };
            var pairs = odds.SelectMany(oddNumber => evens,
                        (oddNumber, evenNumber) =>
                        new
                        {
                            oddNumber,
                            evenNumber,
                            Sum = oddNumber + evenNumber
                        });
            foreach (var item in pairs)
                Console.WriteLine(item);
        }

        static void Test_SelectManyImplement()
        {
            Console.WriteLine("\nTest_SelectManyImplement():");

            int[] odds = { 1, 3, 5, 7 };
            int[] evens = { 2, 4, 6, 8 };
            var pairs = ((IEnumerable<int>)odds).MySelectMany(oddNumber => evens,
                        (oddNumber, evenNumber) =>
                        new
                        {
                            oddNumber,
                            evenNumber,
                            Sum = oddNumber + evenNumber
                        });
            foreach (var item in pairs)
                Console.WriteLine(item);
        }


        static void Test_multiple_from_wherePhrase()
        {
            Console.WriteLine("\nTest_multiple_from_wherePhase():");

            int[] odds = { 1, 3, 5, 7 };
            int[] evens = { 2, 4, 6, 8 };
            var pairs = from oddNumber in odds
                        from evenNumber in evens
                        where oddNumber > evenNumber
                        select new
                        {
                            oddNumber,
                            evenNumber,
                            Sum = oddNumber + evenNumber
                        };
            foreach (var item in pairs)
                Console.WriteLine(item);
        }

        static void Test_SelectMany_WhereMethod()
        {
            Console.WriteLine("\nTest_SelectMany_WhereMethod():");

            int[] odds = { 1, 3, 5, 7 };
            int[] evens = { 2, 4, 6, 8 };
            var pairs = odds.SelectMany(oddNumber => evens,
                        (oddNumber, evenNumber) =>
                        new { oddNumber, evenNumber}).
                        Where(pair => pair.oddNumber > pair.evenNumber).
                        Select(pair => new
                        {
                            pair.oddNumber,
                            pair.evenNumber,
                            Sum = pair.oddNumber + pair.evenNumber
                        });
            foreach (var item in pairs)
                Console.WriteLine(item);
        }

        static void Test_triple_fromPhrase()
        {
            Console.WriteLine("Test_triple_fromPhase():");

            var triples = from n in new int[] { 1, 2, 3 }
                          from s in new string[] { "one", "two", "three" }
                          from r in new string[] { "I", "II", "III" }
                          select new { Arabic = n, Word = s, Roman = r };
            foreach (var item in triples)
                Console.WriteLine(item);

        }

        static void Test_double_SelectManyMethod()
        {
            Console.WriteLine("\nTest_double_SelectManyMethod():");

            var numbers = new int[] { 1, 2, 3 };
            var words = new string[] { "one", "two", "three" };
            var romanNumerals = new string[] { "I", "II", "III" };
            var triples = numbers.SelectMany(n => words,
                (n, s) => new { n, s }).
                SelectMany(pair => romanNumerals,
                (pair, r) => new {
                    Arablic = pair.n,
                    Word = pair.s,
                    Roman = r
                });
            foreach (var item in triples)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            Test_multiple_fromPhrase();
            Test_SelectManyMethod();
            Test_SelectManyImplement();
            Test_multiple_from_wherePhrase();
            Test_SelectMany_WhereMethod();
            Test_triple_fromPhrase();
            Test_double_SelectManyMethod();
        }
    }
}
