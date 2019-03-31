using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereMethod
{
    class Program
    {
        static void TestWherePhrase()
        {
            Console.WriteLine("TestWherePhrase():");

            // 2019.03.31 change
            // 配列初期化子で暗黙的に型指定された変数を初期化することはできません。
            //var numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbers = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var smallNumbers = from n in numbers
                               where n < 5
                               select n;

            foreach (var n in smallNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();
        }

        static void TestWhereMethod()
        {
            Console.WriteLine("TestWhereMethod():");

            // 2019.03.31 change
            // 配列初期化子で暗黙的に型指定された変数を初期化することはできません。
            //var numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var smallNumbers = numbers.Where(n => n < 5);

            foreach (var n in smallNumbers)
                Console.Write($"{n} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestWherePhrase();
            TestWhereMethod();
        }
    }
}
