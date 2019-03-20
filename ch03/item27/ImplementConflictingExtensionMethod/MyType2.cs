using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementConflictingExtensionMethod
{
    class MyType2 : IFoo
    {
        public int Marker { get; set; }
        public void NextMarker() => Marker += 5;
        public void UpdateMarker() => this.NextMarker();
    }
}
