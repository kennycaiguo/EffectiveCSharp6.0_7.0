using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new int[100];

            for (var num = 0; num < foo.Length; num++)
                foo[num] = num * num;

            foreach (int i in foo)
                Console.WriteLine(i.ToString());
        }
    }
}
