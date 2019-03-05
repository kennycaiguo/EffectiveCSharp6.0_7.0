using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCall_in_Construcotor
{
    abstract class B
    {
        protected B()
        {
            VFunc();
        }

        protected abstract void VFunc();
    }
}
