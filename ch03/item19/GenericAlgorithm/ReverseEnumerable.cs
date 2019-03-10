using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAlgorithm
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

        IEnumerable<T> sourceSequence;
        IList<T> originalSequence;

        public ReverseEnumerable(IEnumerable<T> sequence)
        {
            sourceSequence = sequence;
        }

        // IEnumerable<T>メンバ
        public IEnumerator<T> GetEnumerator()
        {
            Console.WriteLine("GetEnumerator():");

            //　元のシーケンスをコピーし、逆順にできるようにする
            if (originalSequence == null)
            {
                Console.WriteLine(".. copy original sequence into new List<T>()");

                originalSequence = new List<T>();
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
