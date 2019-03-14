using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsSequenceAlgorithm
{
    public static class Example
    {
        public static IEnumerable<TOutput> Zip<T1, T2, TOutput>
            (IEnumerable<T1> left, IEnumerable<T2> right,
            Func<T1, T2, TOutput> generator)
        {
            // 2019.03.14：using文を使うべき
            IEnumerator<T1> leftSequence = left.GetEnumerator();
            IEnumerator<T2> rightSequence = right.GetEnumerator();
            while (leftSequence.MoveNext() && rightSequence.MoveNext())
            {
                yield return generator(leftSequence.Current,
                    rightSequence.Current);
            }
            leftSequence.Dispose();
            rightSequence.Dispose();
        }
    }
}
