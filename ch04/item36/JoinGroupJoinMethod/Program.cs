using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinGroupJoinMethod
{
    class Program
    {
        static void Test_joinPhrase()
        {
            Console.WriteLine("Test_joinPhrase():");

            var numbers = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var labels = new string[] { "0", "1", "2", "3", "4", "5" };
            var query = from num in numbers
                        join label in labels on num.ToString() equals label
                        select new { num, label };

            foreach (var item in query)
                Console.WriteLine(item);
        }

        static void Test_JoinMethod()
        {
            Console.WriteLine("\nTest_JoinMethod():");

            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var labels = new string[] { "0", "1", "2", "3", "4", "5" };
            var query = numbers.Join(labels, num => num.ToString(),
                label => label, (num, label) => new { num, label });

            foreach (var item in query)
                Console.WriteLine(item);
        }

        private static void SetupProject(out Project[] projects, out Task[] tasks)
        {
            var proj1 = new Project("proj#1");
            var proj2 = new Project("proj#2");
            var proj3 = new Project("proj#3");
            projects = new Project[]{ proj1, proj2, proj3 };
            tasks = new Task[]
            {
                new Task(proj1, "task#11"), new Task(proj1, "task#12"),
                new Task(proj2, "task#21"),
                new Task(proj3, "task#31"), new Task(proj3, "task#32"), new Task(proj3, "task#33")
            };
        }

        static void Test_join_into_Phrase()
        {
            Console.WriteLine("\nTest_join_into_Phrase():");

            Project[] projects;
            Task[] tasks;
            SetupProject(out projects, out tasks);

            var groups = from p in projects
                         join t in tasks on p equals t.Parent
                         into projTasks
                         select new { Project = p, projTasks };

            foreach (var proj in groups)
            {
                Console.WriteLine($"{proj.Project}:");
                foreach (var task in proj.projTasks)
                    Console.WriteLine($"\t{task}");
            }
        }

        static void Test_GroupJoinMethod()
        {
            Console.WriteLine("\nTest_GroupJoinMethod():");

            Project[] projects;
            Task[] tasks;
            SetupProject(out projects, out tasks);

            var groups = projects.GroupJoin(tasks,
                p => p, t => t.Parent, (p, projTasks) =>
                    new { Project = p, TaskList = projTasks });

            foreach (var proj in groups)
            {
                Console.WriteLine($"{proj.Project}:");
                foreach (var task in proj.TaskList)
                    Console.WriteLine($"\t{task}");
            }
        }

        static void Main(string[] args)
        {
            Test_joinPhrase();
            Test_JoinMethod();
            Test_join_into_Phrase();
            Test_GroupJoinMethod();
        }
    }
}
