using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalizer
{
    class CriticalSection
    {
        public CriticalSection()
        {
            EnterCriticalSection();
        }

        ~CriticalSection()
        {
            ExitCriticalSection();
        }

        private void EnterCriticalSection()
        {
            Console.WriteLine("CriticalSection.EnterCriticalSection()");
        }

        private void ExitCriticalSection()
        {
            Console.WriteLine("CriticalSection.ExitCriticalSection()");
        }

    }
}
