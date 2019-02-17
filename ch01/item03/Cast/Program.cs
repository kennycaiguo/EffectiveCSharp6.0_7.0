using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast
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
            //return new MyType2();
            return null;
        }
    }
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
                    Console.WriteLine("o is MyType");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("o is not MyType");
            }
        }
    }
}
