using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableFieldVariable
{
    public class NonDisposableEngine : IEngine
    {
        public void DoWork()
        {
            Console.WriteLine("NonDisposableEngine.DoWork()");
        }
    }
}
