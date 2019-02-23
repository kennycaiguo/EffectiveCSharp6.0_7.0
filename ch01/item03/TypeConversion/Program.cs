using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class MyType
    {

    }
    class SecondType
    {
        private MyType _value;
        public static implicit operator
            MyType(SecondType t)
        {
            return t._value;
        }
    }
    class Factory
    {
        public static object GetObject()
        {
            return new SecondType();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object o = Factory.GetObject();

            // version 1
            MyType t = o as MyType;
            if (t != null)
            {
                Console.WriteLine("o is MyType");
            }
            else
            {
                Console.WriteLine("o is not MyType");
            }

            // version 2
            try
            {
                MyType t1;
                t1 = (MyType)o;
                Console.WriteLine("o is casted to MyType");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("o is not casted to MyType");
            }

            // version 3
            SecondType st = o as SecondType;
            try
            {
                MyType t1;
                t1 = (MyType)st;
                Console.WriteLine("o is casted to MyType through SecondType");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("o is not casted to MyType through SecondType");
            }

            // DoStuffWithObject
            DoStuffWithObject(o);

            // compile error
            //MyType t2 = st as MyType;
        }

        private static void DoStuffWithObject(object o)
        {
            try
            {
                MyType t;
                t = (MyType)o;
                Console.WriteLine("o is casted to MyType in DoStuffWithObject(o)");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("o is not casted to MyType in DoStuffWithObject(o)");
            }
        }
    }
}
