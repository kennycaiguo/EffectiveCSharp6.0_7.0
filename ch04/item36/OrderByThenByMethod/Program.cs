using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LinqAnalyzer;

namespace OrderByThenByMethod
{
    class Program
    {
        private static IEnumerable<Employee> MakeEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { LastName = "Last#3", FirstName = "First#B", Age = 40 },
                new Employee { LastName = "Last#3", FirstName = "First#B", Age = 30 },
                new Employee { LastName = "Last#3", FirstName = "First#B", Age = 50 },
                new Employee { LastName = "Last#3", FirstName = "First#A", Age = 40 },
                new Employee { LastName = "Last#3", FirstName = "First#A", Age = 30 },
                new Employee { LastName = "Last#1", FirstName = "First#b", Age = 50 },
                new Employee { LastName = "Last#1", FirstName = "First#b", Age = 30 },
                new Employee { LastName = "Last#1", FirstName = "First#b", Age = 40 },
                new Employee { LastName = "Last#1", FirstName = "First#a", Age = 40 },
                new Employee { LastName = "Last#1", FirstName = "First#a", Age = 30 },
                new Employee { LastName = "Last#2", FirstName = "First#1", Age = 50 },
                new Employee { LastName = "Last#2", FirstName = "First#1", Age = 30 },
                new Employee { LastName = "Last#2", FirstName = "First#2", Age = 50 },
                new Employee { LastName = "Last#2", FirstName = "First#2", Age = 40 },
                new Employee { LastName = "Last#2", FirstName = "First#2", Age = 30 },
            };
            return employees;
        }

        static void Test_orderbyPhrase()
        {
            Console.WriteLine("Test_orderbyPhrase():");

            var employees = MakeEmployees();
            var people = from e in employees
                         where e.Age > 30
                         orderby e.LastName, e.FirstName, e.Age
                         select e;

            foreach (var p in people)
                Console.WriteLine(p);
        }

        static void TestOrderByThenByMethod()
        {
            Console.WriteLine("\nTestOrderByThenByMethod():");

            var employees = MakeEmployees();
            var people = employees.Where(e => e.Age > 30).
                        OrderBy(e => e.LastName).
                        ThenBy(e => e.FirstName).
                        ThenBy(e => e.Age);

            foreach (var p in people)
                Console.WriteLine(p);
        }

        /*
        static void AnalizeOrderByPhrase()
        {
            Console.WriteLine("\nAnalizeOrderByPhrase():");

            var employees = MakeEmployees();
            var tracer = new LinqTracer<Employee>(employees);

            var people = from e in tracer
                         where e.Age > 30
                         orderby e.LastName, e.FirstName, e.Age
                         select e;

            foreach (var p in people.AsEnumerable())
                Console.WriteLine(p);

        }
        */

        static void TestMultiple_orderbyPhrase()
        {
            Console.WriteLine("\nTestMultiple_orderbyPhrase():");
            var employees = MakeEmployees();

            // 不適切。シーケンス全体が3回ソートされる
            var people = from e in employees
                         where e.Age > 30
                         orderby e.LastName
                         orderby e.FirstName
                         orderby e.Age
                         select e;

            foreach (var p in people)
                Console.WriteLine(p);
        }

        static void Test_orderby_descendingPhrase()
        {
            Console.WriteLine("\nTest_orderby_descendingPhrase():");

            var employees = MakeEmployees();
            var people = from e in employees
                         where e.Age > 30
                         orderby e.LastName descending, e.FirstName, e.Age
                         select e;

            foreach (var p in people)
                Console.WriteLine(p);
        }

        static void TestOrderByDescendingThenByMethod()
        {
            Console.WriteLine("\nTestOrderByDescendingThenByMethod():");

            var employees = MakeEmployees();
            var people = employees.Where(e => e.Age > 30).
                        OrderByDescending(e => e.LastName).
                        ThenBy(e => e.FirstName).
                        ThenBy(e => e.Age);

            foreach (var p in people)
                Console.WriteLine(p);
        }

        static void Main(string[] args)
        {
            Test_orderbyPhrase();
            TestOrderByThenByMethod();
            TestMultiple_orderbyPhrase();
            Test_orderby_descendingPhrase();
            TestOrderByDescendingThenByMethod();
        }
    }
}
