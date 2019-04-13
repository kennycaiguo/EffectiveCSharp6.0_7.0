using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeLib;
using static EmployeeLib.Employee;

namespace SumupSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var allEmployees = FindAllEmployees();
            try
            {
                var total = allEmployees.Aggregate(0M,
                    (sum, emp) => sum + emp.MonthlySalary);

                Console.WriteLine($"total = {total}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            foreach (var employee in allEmployees)
                Console.WriteLine(employee);

        }
    }
}
