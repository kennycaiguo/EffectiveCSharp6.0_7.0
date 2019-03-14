using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsFuncArg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 7;
            int sum = Example.Add(a, b, (x, y) => x + y);
            Console.WriteLine($"sum: {sum}");
        }
    }
}
