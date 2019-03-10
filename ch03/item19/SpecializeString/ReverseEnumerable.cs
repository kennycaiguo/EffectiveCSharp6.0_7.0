using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecializeString
{
    public sealed class ReverseEnumerable<T> : IEnumerable<T>
    {
        private sealed class ReverseEnuerator : IEnumerator<T>
        {
            int currentIndex;
            IList<T> collection;

            public ReverseEnuerator(IList<T> srcCollection)
            {
                collection = srcCollection;
                currentIndex = collection.Count;
            }

            // IEnumerator<T>メンバ
            public T Current => collection[currentIndex];

            // IDisposal<T>メンバ
            public void Dispose()
            {
                //　実装コードはないが、IEnumerator<T>がIDisposableを実装しているため必要
                //　このクラスはsealedなのでprotected版のDispose()を実装する必要はない
            }

            // Enumeratorメンバ
            object IEnumerator.Current => this.Current;

            public bool MoveNext() => --currentIndex >= 0;
            public void Reset() => currentIndex = collection.Count;
        }

        private sealed class ReverseStringEnumerator : IEnumerator<char>
        {
            private string sourceSequence;
            private int currentIndex;

            public ReverseStringEnumerator(string source)
            {
                sourceSequence = source;
                currentIndex = source.Length;
            }

            // IEnumerable<char>メンバ
            public char Current => sourceSequence[currentIndex];

            // IDisposableメンバ
            public void Dispose()
            {
                //　実装コードはないものの、
                //　IEnumerator<T>がIDisposableを実装するため必須
            }

            //　IEnumeratorメンバ
            object IEnumerator.Current => sourceSequence[currentIndex];

            public bool MoveNext() => --currentIndex >= 0;

            public void Reset() => currentIndex = sourceSequence.Length;
        }

        IEnumerable<T> sourceSequence;
        IList<T> originalSequence;

        public ReverseEnumerable(IEnumerable<T> sequence)
        {
            Console.WriteLine("ReverseEnumerable(IEnumerable<T>):");

            sourceSequence = sequence;
            // シーケンスがIList<T>を実装していない場合、originalSequenceはnullになるだけなので、
            //　これで正しく動作する
            originalSequence = sequence as IList<T>;
        }

        public ReverseEnumerable(IList<T> sequence)
        {
            Console.WriteLine("ReverseEnumerable(IList<T>):");

            sourceSequence = sequence;
            originalSequence = sequence;
        }

        // IEnumerable<T>メンバ
        public IEnumerator<T> GetEnumerator()
        {
            // stringは特殊ケース
            if (sourceSequence is string)
            {
                Console.WriteLine("... string case : new ReverseStringEnumerator(sourceSequence)");

                // Tがコンパイル時にはcharでない場合があるため
                //　キャストしていることに注意
                return new ReverseStringEnumerator(sourceSequence as string)
                    as IEnumerator<T>;
            }

            //　元のシーケンスをコピーし、逆順にできるようにする
            if (originalSequence == null)
            {
                if (sourceSequence is ICollection<T>)
                {
                    Console.WriteLine(".. copy source sequence into new List<T>(Count)");
                    ICollection<T> source = sourceSequence as ICollection<T>;
                    originalSequence = new List<T>(source.Count);
                }
                else
                {
                    Console.WriteLine(".. copy source sequence into new List<T>()");
                    originalSequence = new List<T>();
                }

                foreach (T item in sourceSequence)
                {
                    originalSequence.Add(item);
                }
            }
            return new ReverseEnuerator(originalSequence);
        }

        // IEnumerableメンバ
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
