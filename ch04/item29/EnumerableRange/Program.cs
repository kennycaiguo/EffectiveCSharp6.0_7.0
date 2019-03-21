using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var allEnumbers = Enumerable.Range(0, int.MaxValue);

            // 100個までの素数を出力する
            const int max_count = 100;
            int count = 0;
            foreach (var i in allEnumbers)
            {
                if (count >= max_count) break;
                if (i < 2) continue;

                int sqrt = (int)Math.Sqrt(i);
                bool is_prime = true;
                for (int divisor = 2; divisor <= sqrt; divisor++)
                {
                    if (i % divisor == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }
                if (is_prime)
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine();
        }
    }
}
