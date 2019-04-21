using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosureSharedBy2Queries
{
    public class ResourceHogFilter : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("... disposing ResourceHogFilter");
        }

        ~ResourceHogFilter()
        {
            Console.WriteLine("... finalizing ResourceHogFilter");
        }

        public bool ParsesFilter(int num)
        {
            return num >= 2;
        }
    }
}
