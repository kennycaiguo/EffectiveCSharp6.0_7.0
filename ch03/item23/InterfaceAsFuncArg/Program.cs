using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAsFuncArg
{
    class AddInt : IAdd<int>
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 7;

            int sum = Example.Add(a, b, new AddInt());
            Console.WriteLine($"sum: {sum}");
        }
    }
}
