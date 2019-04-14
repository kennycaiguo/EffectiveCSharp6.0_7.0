using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeLib;
using static EmployeeLib.Employee;

namespace ModifyCopyThenUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            var allEmployees = FindAllEmployees();
            try
            {
                var updates = (from e in allEmployees
                               select new Employee
                               {
                                   EmployeeID = e.EmployeeID,
                                   Classification = e.Classification,
                                   YearsOfService = e.YearsOfService,
                                   // 2019.04.14 change: must not modify original sequence
                                   //MonthlySalary = e.MonthlySalary *= 1.05M
                                   MonthlySalary = e.MonthlySalary * 1.05M
                               }).ToList();
                allEmployees = updates;
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
