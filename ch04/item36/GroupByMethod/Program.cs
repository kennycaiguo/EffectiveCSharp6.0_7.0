using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByMethod
{
    class Program
    {
        private static IEnumerable<Employee> MakeEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { LastName = "Last#3", FirstName = "First#B", Age = 40, Department = "dev1" },
                new Employee { LastName = "Last#3", FirstName = "First#B", Age = 30, Department = "dev2" },
                new Employee { LastName = "Last#3", FirstName = "First#B", Age = 50, Department = "dev3" },
                new Employee { LastName = "Last#3", FirstName = "First#A", Age = 40, Department = "dev1" },
                new Employee { LastName = "Last#3", FirstName = "First#A", Age = 30, Department = "dev1" },
                new Employee { LastName = "Last#1", FirstName = "First#b", Age = 50, Department = "dev2" },
                new Employee { LastName = "Last#1", FirstName = "First#b", Age = 30, Department = "dev3" },
                new Employee { LastName = "Last#1", FirstName = "First#b", Age = 40, Department = "dev1" },
                new Employee { LastName = "Last#1", FirstName = "First#a", Age = 40, Department = "dev1" },
                new Employee { LastName = "Last#1", FirstName = "First#a", Age = 30, Department = "dev2" },
                new Employee { LastName = "Last#2", FirstName = "First#1", Age = 50, Department = "dev3" },
                new Employee { LastName = "Last#2", FirstName = "First#1", Age = 30, Department = "dev3" },
                new Employee { LastName = "Last#2", FirstName = "First#2", Age = 50, Department = "dev1" },
                new Employee { LastName = "Last#2", FirstName = "First#2", Age = 40, Department = "dev1" },
                new Employee { LastName = "Last#2", FirstName = "First#2", Age = 30, Department = "dev3" },
            };
            return employees;
        }

        static void Test_groupPhraseWithContinuation()
        {
            Console.WriteLine("Test_groupPhraseWithContinuation():");

            var employees = MakeEmployees();
            var results = from e in employees
                         group e by e.Department into d
                         select new
                         {
                             Department = d.Key,
                             Size = d.Count()
                         };

            foreach (var p in results)
                Console.WriteLine(p);
        }

        static void Test_groupPhraseWithNestedQuery()
        {
            Console.WriteLine("\nTest_groupPhraseWithNestedQuery():");

            var employees = MakeEmployees();
            var results = from d in
                             from e in employees group e by e.Department
                         select new
                         {
                             Department = d.Key,
                             Size = d.Count()
                         };

            foreach (var p in results)
                Console.WriteLine(p);
        }

        static void TestGroupByMethod()
        {
            Console.WriteLine("\nTestGroupByMethod():");

            var employees = MakeEmployees();
            var results = employees.GroupBy(e => e.Department).
                            Select(d => new { Department = d.Key, Size = d.Count() });

            foreach (var p in results)
                Console.WriteLine(p);
        }

        static void Test_groupPhraseWithSequence()
        {
            Console.WriteLine("\nTest_groupPhraseWithSequence():");

            var employees = MakeEmployees();
            var results = from e in employees
                          group e by e.Department into d
                          select new
                          {
                              Department = d.Key,
                              Employees = d.AsEnumerable()
                          };

            foreach (var r in results)
            {
                Console.WriteLine($"{{ Department={r.Department}, Employees={{");
                foreach (var p in r.Employees)
                {
                    Console.WriteLine($"\t{p},");
                }
                Console.WriteLine("}}");
            }
        }

        static void TestGroupByMethodWithSequence()
        {
            Console.WriteLine("\nTestGroupByMethodWithSequence():");

            var employees = MakeEmployees();
            var results = employees.GroupBy(e => e.Department).
                            Select(d => new {
                                Department = d.Key,
                                Employees = d.AsEnumerable()
                            });

            foreach (var r in results)
            {
                Console.WriteLine($"{{ Department={r.Department}, Employees={{");
                foreach (var p in r.Employees)
                {
                    Console.WriteLine($"\t{p},");
                }
                Console.WriteLine("}}");
            }
        }

        static void Main(string[] args)
        {
            Test_groupPhraseWithContinuation();
            Test_groupPhraseWithNestedQuery();
            TestGroupByMethod();
            Test_groupPhraseWithSequence();
            TestGroupByMethodWithSequence();
        }
    }
}
