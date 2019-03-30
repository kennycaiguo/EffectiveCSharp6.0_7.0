using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFold
{
    using static Util;

    class Program
    {
        static void Main(string[] args)
        {
            var peeps = new List<Employee>()
            {
                new Employee { Name = "Sasaki", Salary = 62.5M },
                new Employee { Name = "Sophia", Salary = 25M },
                new Employee {Name = "Lisa", Salary = 30M}
            };

            var totalSalary = Fold(peeps, 0M, (person, sum) => sum + person.Salary);
            Console.WriteLine($"totalSalary: {totalSalary}");
        }
    }
}
