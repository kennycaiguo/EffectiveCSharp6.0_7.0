using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalOverload
{
    public static class Utils
    {
        public static bool AreEqual<T>(T left, T right) =>
            left.Equals(right);

        public static bool AreEqual2<T>(T left, T right)
        {
            if (left == null)
                return right == null;
            if (left is IEquatable<T>)
            {
                IEquatable<T> lval = left as IEquatable<T>;
                return lval.Equals(right);
            }
            return left.Equals(right);
        }
    }
}
