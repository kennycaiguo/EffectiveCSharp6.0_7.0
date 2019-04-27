using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMethod
{
    class Program
    {
        static List<Forward> Forwards = new List<Forward> {
            new Forward { Name = "#1", GoalsScored = 0 },
            new Forward { Name = "#2", GoalsScored = 2 },
            new Forward { Name = "#3", GoalsScored = 1 },
            new Forward { Name = "#4", GoalsScored = 1 },
            new Forward { Name = "#5", GoalsScored = 0 }
        };

        static void Main(string[] args)
        {
            // 動作する。nullが返る
            var answer = (from p in Forwards
                          where p.GoalsScored > 2
                          orderby p.GoalsScored
                          select p).FirstOrDefault();
            Console.WriteLine("asnwer is null ? " + (answer == null));

            // シーケンスに値がない場合、例外がスローされる
            try
            {
                var answer2 = (from p in Forwards
                               where p.GoalsScored > 2
                               orderby p.GoalsScored
                               select p).First();
                Console.WriteLine($"answer2: {answer2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            answer = (from p in Forwards
                      where p.GoalsScored > 0
                      orderby p.GoalsScored descending
                      select p).Skip(2).First();
            Console.WriteLine($"answer: {answer}");

        }
    }
}
