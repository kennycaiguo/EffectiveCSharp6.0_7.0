using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAsFuncArg
{
    public interface IAdd<T>
    {
        T Add(T x, T y);
    }
}
