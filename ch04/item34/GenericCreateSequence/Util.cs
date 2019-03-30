using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCreateSequence
{
    public static class Util
    {
        public static IEnumerable<int> CreateSequence(int numberOfElements,
            int startAt, int stepBy)
        {
            for (var i = 0; i < numberOfElements; i++)
                yield return startAt + i * stepBy;
        }

        public static IEnumerable<T> CreateSequence<T>(
            int numberOfElements,
            Func<T> generator)
        {
            for (var i = 0; i < numberOfElements; i++)
                yield return generator();
        }

        public static IEnumerable<T> CreateSequence<T>(
            int numberOfElements,
            Func<int, T> generator)
        {
            for (var i = 0; i < numberOfElements; i++)
                yield return generator(i);
        }
    }
}
