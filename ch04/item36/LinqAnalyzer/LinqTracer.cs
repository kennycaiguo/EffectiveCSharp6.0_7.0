using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAnalyzer
{
    public class LinqTracer<T>
    {
        IEnumerable<T> enumerable;
        public LinqTracer(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public IEnumerable<T> AsEnumerable() => this.enumerable;

        // trace Where method
        public LinqTracer<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine(".Where()");
            return new LinqTracer<T>(enumerable.Where(predicate));
        }

    }
}
