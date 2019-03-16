using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericStaticUtility
{
    public static class Utils
    {
        public static T Max<T>(T left, T right) =>
            Comparer<T>.Default.Compare(left, right) < 0 ? right : left;

        public static double Max(double left, double right) =>
            Math.Max(left, right);
        // その他の数値型に対応するバージョンは省略

        public static T Min<T>(T left, T right) =>
            Comparer<T>.Default.Compare(left, right) < 0 ? left : right;

        public static double Min(double left, double right) =>
            Math.Min(left, right);
        // その他の数値型に対応するバージョンは省略
    }
}
