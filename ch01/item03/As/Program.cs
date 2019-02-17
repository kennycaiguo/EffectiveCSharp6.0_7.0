using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As
{
    class MyType
    {

    }
    class MyType2
    {

    }
    class Factory
    {
        public static object GetObject()
        {
            //return new MyType();
            return new MyType2();
        }
    }
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
