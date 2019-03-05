using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeNestedDisposable
{
    class Program
    {
        static void DisposeParentDisposable()
        {
            Console.WriteLine("DisposeParentDisposable():");

            using (var o = new MyResourceHog(new NestedResourceHog()))
            {

            }
        }

        static void DisposeParentThenNested()
        {
            Console.WriteLine("DisposeParentThenNested():");
            var nested = new NestedResourceHog();
            var parent = new MyResourceHog(nested);

            parent.Dispose();
            nested.Dispose();
        }

        static void DisposeNestedThenParent()
        {
            Console.WriteLine("DisposeNestedThenParent():");
            var nested = new NestedResourceHog();
            var parent = new MyResourceHog(nested);

            nested.Dispose();
            parent.Dispose();
        }

        static void Main(string[] args)
        {
            DisposeParentDisposable();
            DisposeParentThenNested();
            DisposeNestedThenParent();
        }
    }
}
