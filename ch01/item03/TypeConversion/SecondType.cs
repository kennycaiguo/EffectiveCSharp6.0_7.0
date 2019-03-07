using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class SecondType
    {
        private MyType _value;
        public SecondType(MyType mytype)
        {
            this._value = mytype;
        }

        public static implicit operator
            MyType(SecondType t)
        {
            return t._value;
        }
    }
}
