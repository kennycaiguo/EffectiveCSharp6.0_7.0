using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = Factory.GetObject();
            try
            {
                MyType t;
                t = (MyType)o;
                if (t == null)
                {
                    Console.WriteLine("o is null");
                }
                else
                {
                    Console.WriteLine("o is casted to MyType");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("o is not casted to MyType");
            }
        }
    }
}
