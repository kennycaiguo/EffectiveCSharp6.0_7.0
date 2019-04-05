using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyMethod
{
    class Program
    {
        static void Test_selectPhrase()
        {
            Console.WriteLine("Test_selectPhase():");

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

        static void Main(string[] args)
        {
            Test_selectPhrase();                
        }
    }
}
