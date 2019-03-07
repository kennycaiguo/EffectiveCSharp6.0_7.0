using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
        static bool CheckWithUser()
        {
            Console.Write("continue ? (y/n) > ");
            string line = Console.ReadLine();
            return line[0] == 'y';
        }
        static bool CheckWithSystem()
        {
            return true;
        }

        static void Main(string[] args)
        {
            var jobs = new List<ComplicatedClass>() {
                new ComplicatedClass { Name = "job1" }, new ComplicatedClass { Name = "job2" },
                new ComplicatedClass { Name = "job3"}
            };
            Func<bool> cp = () => CheckWithUser();
            cp += () => CheckWithSystem();
            var c = new CancelableExecution(jobs);

            Console.WriteLine("DoLengthyOperation():");
            c.LengthyOperation(cp);

            Console.WriteLine("DoLengthyOperation2():");
            c.LengthyOperation2(cp);
        }
    }
}
