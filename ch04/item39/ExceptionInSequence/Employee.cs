using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInSequence
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
    }
}
