using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAsFuncArg
{
    public static class Example
    {
        public static T Add<T>(T left, T right, IAdd<T> Callback) =>
            Callback.Add(left, right);
    }
}
