using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericZipper
{
    public static class Util
    {
        public static IEnumerable<string> Zip(
            IEnumerable<string> first,
            IEnumerable<string> second)
        {
            using (var firstSequence = first.GetEnumerator())
            {
                using (var secondSequence = second.GetEnumerator())
                {
                    while (firstSequence.MoveNext() &&
                        secondSequence.MoveNext())
                        yield return string.Format("{0} {1}",
                            firstSequence.Current,
                            secondSequence.Current);
                }
            }
        }

        public static IEnumerable<TResult> Zip<T1, T2, TResult>(
            IEnumerable<T1> first,
            IEnumerable<T2> second,
            Func<T1, T2, TResult> zipper)
        {
            using (var firstSequence = first.GetEnumerator())
            {
                using (var secondSequence = second.GetEnumerator())
                {
                    while (firstSequence.MoveNext() &&
                        secondSequence.MoveNext())
                        yield return zipper(firstSequence.Current,
                            secondSequence.Current);
                }
            }
        }
    }
}
