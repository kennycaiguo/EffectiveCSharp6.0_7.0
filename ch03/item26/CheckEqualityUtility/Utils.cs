using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEqualityUtility
{
    public static class Utils
    {
        public static bool CheckEquality(object left, object right)
        {
            if (left == null)
                return right == null;
            return left.Equals(right);
        }
    }
}
