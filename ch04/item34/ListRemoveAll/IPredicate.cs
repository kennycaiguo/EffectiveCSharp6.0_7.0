using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRemoveAll
{
    public interface IPredicate<T>
    {
        bool Match(T soughtObject);
    }
}
