using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMethodWithArguments
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
            var letter = first;
            while (letter <= last)
            {
                yield return letter;
                letter++;
            }
        }

        public class EmbeddedSubsetIterator : IEnumerable<char>
        {
            private readonly char first;
            private readonly char last;
            public EmbeddedSubsetIterator(char first, char last)
            {
                this.first = first;
                this.last = last;
            }

            public static IEnumerable<char> GenerateAlphabetSubset(char first, char last) =>
                new EmbeddedSubsetIterator(first, last);

            public IEnumerator<char> GetEnumerator() => new LetterEnumerator(first, last);
            IEnumerator IEnumerable.GetEnumerator() => new LetterEnumerator(first, last);

            private class LetterEnumerator : IEnumerator<char>
            {
                private readonly char first;
                private readonly char last;

                private bool isInitialized = false;

                public LetterEnumerator(char first, char last)
                {
                    this.first = first;
                    this.last = last;
                }

                // 2019.03.24 change
                //private char letter = (char)('a' - 1);
                private char letter;

                public bool MoveNext()
                {
                    if (!isInitialized)
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
                        letter = (char)(first - 1);
                        isInitialized = true;   // 2019.03.24 add
                    }
                    letter++;
                    return letter <= last;
                }

                public char Current => letter;

                object IEnumerator.Current => letter;

                public void Dispose() { }

                public void Reset() => isInitialized = false;
            }
        }

    }
}
