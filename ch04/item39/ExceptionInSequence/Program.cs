using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeLib;
using static EmployeeLib.Employee;

namespace ExceptionInSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var allEmployees = FindAllEmployees();
            try
            {
                allEmployees.ForEach(e => e.MonthlySalary *= 1.05M);
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
