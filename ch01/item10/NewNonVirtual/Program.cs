using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNonVirtual
{
    class Program
    {
        static object MakeObject()
        {
            return new MyOtherClass();
        }

        static void Main(string[] args)
        {
            object c = MakeObject();

            // MyClass経由で実行
            MyClass cl = c as MyClass;
            cl.MagicMethod();

            // MyOtherClass経由で実行
            MyOtherClass cl2 = c as MyOtherClass;
            cl2.MagicMethod();
        }
    }
}
