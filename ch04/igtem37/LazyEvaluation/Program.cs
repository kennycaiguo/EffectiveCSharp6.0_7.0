using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace LazyEvaluation
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
            WriteLine($"1番目のテスト開始時間： {DateTime.Now:T}");
            var sequence = Generate(10, () => DateTime.Now);

            WriteLine("待機中....\tエンターキーを押してください");
            ReadLine();

            WriteLine("走査中...");
            foreach (var value in sequence)
                WriteLine($"{value:T}");

            WriteLine("待機中....\tエンターキーを押してください");
            ReadLine();

            WriteLine("走査中...");
            foreach (var value in sequence)
                WriteLine($"{value:T}");
        }
    }
}
