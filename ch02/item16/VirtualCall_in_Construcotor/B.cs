using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCall_in_Construcotor
{
    class B
    {
        protected B()
        {
            VFunc();
        }

        protected virtual void VFunc()
        {
            Console.WriteLine("B内のVFunc");
        }
    }
}
