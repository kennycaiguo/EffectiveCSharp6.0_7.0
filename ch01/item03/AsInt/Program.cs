using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsInt
{
    class Factory
    {
        public static int GetValue()
        {
            return 101;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object o = Factory.GetValue();
            // can not compile
            //int i = o as int;
            var i = o as int?;
            if (i != null)
                Console.WriteLine(i.Value);
        }
    }
}
