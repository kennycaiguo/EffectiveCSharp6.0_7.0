using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAnalyzer
{
    public class LinqTracer<T> : IEnumerable<T>
    {
        IEnumerable<T> enumerable;
        public LinqTracer(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        // implements IEnumerable<T>

        public IEnumerator<T> GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }

        // trace Where method
        public LinqTracer<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine(".Where()");
            return new LinqTracer<T>(enumerable.Where(predicate));
        }

    }
}
