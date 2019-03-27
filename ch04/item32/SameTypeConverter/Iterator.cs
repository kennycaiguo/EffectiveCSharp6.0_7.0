using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameTypeConverter
{
    public static class Iterator
    {
        public static IEnumerable<T> Select<T>(
            IEnumerable<T> sequence, Func<T, T> method)
        {
            // sequenceとmethodのnullチェックは省略
            foreach (T element in sequence)
                yield return method(element);
        }
    }
}
