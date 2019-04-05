using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinGroupJoinMethod
{
    class Program
    {
        static void Test_joinPhrase()
        {
            Console.WriteLine("Test_joinPhrase():");

            var numbers = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var labels = new string[] { "0", "1", "2", "3", "4", "5" };
            var query = from num in numbers
                        join label in labels on num.ToString() equals label
                        select new { num, label };

            foreach (var item in query)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            Test_joinPhrase();
        }
    }
}
