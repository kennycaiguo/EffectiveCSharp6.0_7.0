using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNonVirtual
{
    public class MyClass
    {
        public void MagicMethod()
        {
            Console.WriteLine("MyClass");
        }
    }

    public class MyOtherClass : MyClass
    {
        // MagicMethodをこのクラス用に再定義
        public new void MagicMethod()
        {
            Console.WriteLine("MyOtherClass");
        }
    }
}
