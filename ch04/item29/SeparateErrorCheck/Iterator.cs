using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparateErrorCheck
{
    public static class Iterator
    {
        public static IEnumerable<char>
            GenerateAlphabetSubset(char first, char last)
        {
            if (first < 'a')
                throw new ArgumentException(
                    "1文字目はa以降にする必要があります", nameof(first));
            if (first > 'z')
                throw new ArgumentException(
                    "1文字目はz以前にする必要があります", nameof(first));
            if (last < first)
                throw new ArgumentException(
                    "最後の文字は1文字目より後方になければいけません", nameof(last));
            if (last > 'z')
                throw new ArgumentException(
                    "最後の文字はz以前にする必要があります", nameof(last));

            return GenerateAlphabetSubsetImpl(first, last);
        }

        private static IEnumerable<char> GenerateAlphabetSubsetImpl(
            char first, char last)
        {
            var letter = first;
            while (letter <= last)
            {
                yield return letter;
                letter++;
            }
        }
    }
}
