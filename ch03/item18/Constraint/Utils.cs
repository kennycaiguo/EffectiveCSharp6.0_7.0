using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraint
{
    public static class Utils
    {
        public static bool AreEqual<T>(T left, T right)
        {
            if (left == null)
                return right == null;
            if (left is IComparable<T>)
            {
                IComparable<T> lval = left as IComparable<T>;
                if (right is IComparable<T>)
                    return lval.CompareTo(right) == 0;
                else
                    throw new ArgumentException(
                        "IComparable<T>が実装されていない型です",
                        nameof(right));
            }
            else
            {
                throw new ArgumentException(
                    "IComparable<T>が実装されていない型です",
                    nameof(left));
            }
        }

        public static bool AreEqual2<T>(T left, T right)
            where T : IComparable<T> =>
                left.CompareTo(right) == 0;
    }
}
