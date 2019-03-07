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
            return new MyType();
            //return new MyType2();
        }
    }
}
