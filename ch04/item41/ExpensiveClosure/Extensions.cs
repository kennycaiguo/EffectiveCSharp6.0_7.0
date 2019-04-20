using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensiveClosure
{
    public class Extensions
    {
        public static IEnumerable<int> Generate(int count, Func<int> generate)
        {
            for (var i = 0; i < count; i++)
                yield return generate();
        }
    }
}
