using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStaticUtility
{
    public static class Utils<T>
    {
        public static T Max(T left, T right) =>
            Comparer<T>.Default.Compare(left, right) < 0 ? right : left;

        public static T Min(T left, T right) =>
            Comparer<T>.Default.Compare(left, right) < 0 ? left : right;
    }
}
