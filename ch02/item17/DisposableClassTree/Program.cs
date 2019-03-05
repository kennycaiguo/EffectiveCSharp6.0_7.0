using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableClassTree
{
    class Program
    {
        static void DisposeBaseClass()
        {
            Console.WriteLine("DisposeBaseClass():");
            using (var o = new MyResourceHog())
            {

            }
        }

        static void UseClassAfterDisposed()
        {
            Console.WriteLine("UseClassAfterDisposed():");
            var o = new MyResourceHog();
            o.Dispose();
            try
            {
                o.ExampleMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            DisposeBaseClass();
            UseClassAfterDisposed();
        }
    }
}
