using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachIEnumerable
{
    class MyType
    {
        private int value;
        public MyType(int v)
        {
            this.value = v;
        }
        public void DoStuff()
        {
            Console.WriteLine("MyType.DoStuff() : value=" + value);
        }
    }
}
