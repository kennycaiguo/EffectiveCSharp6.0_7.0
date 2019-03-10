using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecializeGeneric
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
