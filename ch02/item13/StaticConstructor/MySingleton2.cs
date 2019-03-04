using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class MySingleton2
    {
        private static readonly MySingleton2 theOneAndOnly;

        static MySingleton2()
        {
            theOneAndOnly = new MySingleton2();
        }

        public static MySingleton2 TheOnly
        {
            get { return theOneAndOnly; }
        }

        private MySingleton2()
        {
            Console.WriteLine("create MySingleton2 instance");
        }
    }
}
