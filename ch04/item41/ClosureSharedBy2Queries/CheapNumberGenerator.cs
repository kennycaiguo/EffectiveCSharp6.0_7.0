using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosureSharedBy2Queries
{
    public class CheapNumberGenerator : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("... disposing CheapNumberGenerator");
        }
        ~CheapNumberGenerator()
        {
            Console.WriteLine("... finalizing CheapNumberGenerator");
        }

        public IEnumerable<int> GetNumbers(int count)
        {
            var rnd = new Random();
            for (int i = 0; i < count; i++)
                yield return rnd.Next(10);
        }
    }
}
