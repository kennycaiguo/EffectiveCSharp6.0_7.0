using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsForIEnumerableInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = Extensions.Generate(100, (i) => i * (100-i));

            double average = seq.Average();
            int max = seq.Max();
            int min = seq.Min();
            int sum = seq.Sum();

            Console.WriteLine($"Average: {average}, Max: {max}, Min: {min}, Sum: {sum}");
        }
    }
}
