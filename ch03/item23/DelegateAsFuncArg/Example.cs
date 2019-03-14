using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsFuncArg
{
    public static class Example
    {
        public static T Add<T>(T left, T right, Func<T, T, T> AddFunc) =>
            AddFunc(left, right);
    }
}
