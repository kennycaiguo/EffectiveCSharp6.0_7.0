using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementConflictingExtensionMethod
{
    public static class FooExtensions
    {
        public static void NextMarker(this IFoo thing)
        {
            thing.Marker += 1;
        }
    }
}
