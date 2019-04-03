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

        // trace Select method
        public LinqTracer<U> Select<U>(Func<T, U> selector)
        {
            Console.WriteLine(".Select()");
            return new LinqTracer<U>(enumerable.Select(selector));
        }

        /*
        // trace OrderBy, OrderByDescending method
        public LinqTracer_Ordered<T> OrderBy<K>(Func<T, K> keySelector)
        {
            Console.WriteLine(".OrderBy()");
            return new LinqTracer_Ordered<T>(enumerable.OrderBy(keySelector));
        }
        */
    }

    /*
    public class LinqTracer_Ordered<T> : LinqTracer<T>
    {
        IEnumerable<T> enumerable;
        public LinqTracer_Ordered(IEnumerable<T> enumerable)
        {

        }
    }
    */
}
