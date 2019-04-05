using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyMethod
{
    public static class LinqImpl
    {
        public static IEnumerable<TOutput> MySelectMany<T1, T2, TOutput>(
            this IEnumerable<T1> src,
            Func<T1, IEnumerable<T2>> inputSelector,
            Func<T1, T2, TOutput> resultSelector)
        {
            foreach (T1 first in src)
            {
                foreach (T2 second in inputSelector(first))
                    yield return resultSelector(first, second);
            }
        }
    }
}
