using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableValueType
{
    public struct Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
