using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference
{
    class MyType
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new MyType();
            Console.WriteLine($"宣言された型：{foo.GetType().Name}");
        }
    }
}
