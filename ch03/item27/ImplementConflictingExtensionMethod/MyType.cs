using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementConflictingExtensionMethod
{
    class MyType : IFoo
    {
        public int Marker { get; set; }
        public void UpdateMarker() => this.NextMarker();
    }
}
