using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachIEnumerable
{
    class SecondType
    {
        private MyType _value;

        public SecondType(MyType v)
        {
            _value = v;
        }

        public static implicit operator
            MyType(SecondType t)
        {
            return t._value;
        }
    }
}
