using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = Factory.GetObject();
            MyType t = o as MyType;
            if (t != null)
            {
                Console.WriteLine("o is MyType");
            }
            else
            {
                Console.WriteLine("o is not MyType");
            }
        }
    }
}
