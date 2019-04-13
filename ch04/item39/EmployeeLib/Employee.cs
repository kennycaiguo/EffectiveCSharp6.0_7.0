using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public enum Classification
    {
        Salary,
        Manager,
        Retired
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public Classification Classification { get; set; }
        public int YearsOfService { get; set; }
        public decimal MonthlySalary { get; set; }

        public override string ToString()
        {
            return $"{{ EmployeeID = {EmployeeID}, Classification = {Classification}, YearsOfService = {YearsOfService}, MonthlySalary = {MonthlySalary} }}";
        }

        public static List<Employee> FindAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                EmployeeID = 10001,
                Classification = Classification.Salary,
                YearsOfService = 11,
                MonthlySalary = 50.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10001,
                Classification = Classification.Salary,
                YearsOfService = 5,
                MonthlySalary = 30.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10003,
                Classification = Classification.Manager,
                YearsOfService = 21,
                MonthlySalary = 60.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10002,
                Classification = Classification.Retired,
                YearsOfService = 31,
                MonthlySalary = decimal.MaxValue
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10003,
                Classification = Classification.Manager,
                YearsOfService = 23,
                MonthlySalary = 70.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10001,
                Classification = Classification.Salary,
                YearsOfService = 7,
                MonthlySalary = 40.0M
            }
            );
            return employees;
        }
    }
}
