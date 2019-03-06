using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonly
{
    class Program
    {
        // コンパイル時定数：
        public const int Millennium = 2000;

        //　実行時定数：
        public static readonly int ThisYear = 2004;

        //　コンパイル不可。readonlyを使用する必要がある
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
