using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace QueryComposition
{
    class Program
    {
        private static IEnumerable<TResult>
            Generate<TResult>(int number, Func<TResult> generator)
        {
            for (var i = 0; i < number; i++)
                yield return generator();
        }

        static void Main(string[] args)
        {
            var sequence1 = Generate(10, () => DateTime.Now);
            var sequence2 = from value in sequence1
                            select value.ToUniversalTime();

            WriteLine("ローカル時間を走査中...");
            foreach (var value in sequence1)
                WriteLine($"{value:T}");

            WriteLine("待機中....\tエンターキーを押してください");
            ReadLine();

            WriteLine("UTCを走査中...");
            foreach (var value in sequence2)
                WriteLine($"{value:T}");

        }
    }
}
