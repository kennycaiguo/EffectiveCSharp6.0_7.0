using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypeConverter
{
    public static class Iterator
    {
        public static IEnumerable<Tout> Select<Tin, Tout>(
            IEnumerable<Tin> sequence, Func<Tin, Tout> method)
        {
            // sequenceとmethodのnullチェックは省略
            foreach (Tin element in sequence)
                yield return method(element);
        }
    }
}
