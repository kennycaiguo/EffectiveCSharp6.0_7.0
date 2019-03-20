﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenssionMethod
{
    public static class Comparable
    {
        public static bool LessThan<T>(this T left, T right)
            where T : IComparable<T> => left.CompareTo(right) < 0;

        public static bool GreaterThan<T>(this T left, T right)
            where T : IComparable<T> => left.CompareTo(right) > 0;

        public static bool LessThanEqual<T>(this T left, T right)
            where T : IComparable<T> => left.CompareTo(right) <= 0;

        public static bool GreaterThanEqual<T>(this T left, T right)
            where T : IComparable<T> => left.CompareTo(right) >= 0;
    }
}
