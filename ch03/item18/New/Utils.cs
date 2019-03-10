using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    public static class Utils
    {
        public delegate T FactoryFunc<T>();
        public static T Factory<T>(FactoryFunc<T> makeANewT)
            where T : new()
        {
            T rVal = makeANewT();
            if (rVal == null)
                return new T();
            else
                return rVal;
        }
    }
}
