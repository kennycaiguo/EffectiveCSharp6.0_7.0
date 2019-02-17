using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonly
{
    class Program
    {
        public const int Millennium = 2000;
        public static readonly int ThisYear = 2004;

        //private const DateTime classCreation = new DateTime(2000, 1, 1, 0, 0, 0);
        private static readonly DateTime classCreation = new DateTime(2000, 1, 1, 0, 0, 0);

        static void Main(string[] args)
        {
            var myDateTime = new DateTime(2000, 1, 1, 0, 0, 0);
            if (myDateTime.Year == Millennium)
            {
                Console.WriteLine("MyDateTime.Year is Millemminum");
            }

            Console.WriteLine("classCreation: " + classCreation);
        }
    }
}
