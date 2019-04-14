using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public enum EmployeeType
    {
        Salary,
        Manager,
        Retired,
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public EmployeeType Classification { get; set; }
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
                Classification = EmployeeType.Salary,
                YearsOfService = 11,
                MonthlySalary = 50.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10002,
                Classification = EmployeeType.Salary,
                YearsOfService = 5,
                MonthlySalary = 30.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10003,
                Classification = EmployeeType.Manager,
                YearsOfService = 21,
                MonthlySalary = 60.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10004,
                Classification = EmployeeType.Retired,
                YearsOfService = 31,
                MonthlySalary = decimal.MaxValue
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10005,
                Classification = EmployeeType.Manager,
                YearsOfService = 23,
                MonthlySalary = 70.0M
            }
            );
            employees.Add(new Employee
            {
                EmployeeID = 10006,
                Classification = EmployeeType.Salary,
                YearsOfService = 7,
                MonthlySalary = 40.0M
            }
            );
            return employees;
        }
    }
}
