using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosureSharedBy2Queries
{
    class Program
    {
        private static IEnumerable<int> LeakingClosure(int mod)
        {
            var filter = new ResourceHogFilter();
            var source = new CheapNumberGenerator();
            var results = new CheapNumberGenerator();

            var importantStatistic = (from num in
                                          source.GetNumbers(50)
                                      where filter.ParsesFilter(num)
                                      select num).Average();

            return from num in results.GetNumbers(100)
                   where num > importantStatistic
                   select num;
        }

        static void TestLeakingClosure()
        {
            Console.WriteLine("TestLeakingClosure():");

            var sequence = LeakingClosure(100);

            Console.WriteLine("collecting garbage after sequence = LeakingClosure()");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放

            foreach (var e in sequence)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.WriteLine("collecting garbage after foreach (... in sequence)");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放

            sequence = null;

            Console.WriteLine("collecting garbage after sequence = null");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }

        static void Main(string[] args)
        {
            TestLeakingClosure();
        }
    }
}
