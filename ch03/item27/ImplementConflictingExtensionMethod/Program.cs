using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementConflictingExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyType t = new MyType();
            t.UpdateMarker();
            Console.WriteLine(t.Marker);

            MyType2 t2 = new MyType2();
            t2.UpdateMarker();
            Console.WriteLine(t2.Marker);

        }
    }
}
