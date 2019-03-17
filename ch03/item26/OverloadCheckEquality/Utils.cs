using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadCheckEquality
{
    public static class Utils
    {
        public static bool CheckEquality(object left, object right)
        {
            if (left == null)
                return right == null;
            return left.Equals(right);
        }

        public static bool CheckEquality<T>(T left, T right)
            where T : IEquatable<T>
        {
            if (left == null)
                return right == null;
            return left.Equals(right);
        }
    }
}
