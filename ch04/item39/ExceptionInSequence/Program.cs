using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInSequence
{
    class Program
    {
        static List<Employee> FindAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee {
                EmployeeID = 10001,
                Classification = Classification.Salary,
                YearsOfService = 21,
                MonthlySalary = 56.7M }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10002,
                Classification = Classification.Retired,
                YearsOfService = 11,
                MonthlySalary = 0 }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10003,
                Classification = Classification.Manager,
                YearsOfService = 23,
                MonthlySalary = 78.9M
            }
            );
            return employees;
        }

        static void Main(string[] args)
        {
            var allEmployees = FindAllEmployees();
            try
            {
                allEmployees.ForEach(e => {
                    if (e.MonthlySalary == 0)
                        throw new ArithmeticException("singular value");
                    else e.MonthlySalary *= 1.05M;
                });
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
