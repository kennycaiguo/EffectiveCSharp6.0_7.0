using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Factory
    {
        static MyType myType = new MyType();
        static SecondType secondType = new SecondType(myType);

        public static object GetObject()
        {
            return secondType;;
        }
    }
}
