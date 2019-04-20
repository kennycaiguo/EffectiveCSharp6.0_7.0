using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensiveClosure
{
    public class ResourceHog : IDisposable
    {
        private int start = -10;
        private int count = 50;

        public void Dispose()
        {
            Console.WriteLine("...disposing ResourceHog") ;
        }

        ~ResourceHog()
        {
            Console.WriteLine("...finalizing ResourceHog");
        }

        public IEnumerable<int> SequenceGeneratedFromResourceHog(Func<int, bool> pred)
        {
            //            return Enumerable.Range(start, count).Where(pred);
            for (int c = 0; c < count; c++)
                if (pred(start + c))
                    yield return start + c;
        }
    }
}
