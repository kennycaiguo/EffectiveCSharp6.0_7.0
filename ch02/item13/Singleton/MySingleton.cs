using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class MySingleton
    {
        private static readonly MySingleton theOneAndOnly = new MySingleton();

        public static MySingleton TheOnly
        {
            get { return theOneAndOnly; }
        }

        private MySingleton()
        {
            Console.WriteLine("create MySingleton instance");
        }
    }


}
