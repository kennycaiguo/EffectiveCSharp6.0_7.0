using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableClosure
{
    public class Extensions
    {
        public static IEnumerable<int> Generate(Func<int> generate)
        {
            for (; ; )
                yield return generate();
        }
    }
}
