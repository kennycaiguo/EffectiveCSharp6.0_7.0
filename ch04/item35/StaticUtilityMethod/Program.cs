using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLib;
namespace StaticUtilityMethod
{
    using static PersonReports;
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> somePresidents =
                new List<Person>
                {
                    new Person
                    {
                        FirstName = "George",
                        LastName = "Washington"
                    },
                    new Person
                    {
                        FirstName = "Thomas",
                        LastName = "Jefferson"
                    },
                    new Person
                    {
                        FirstName = "Abe",
                        LastName = "Lincoln"
                    }
                };
            foreach (Person p in somePresidents)
            {
                Console.WriteLine(FormatAsText(p));
                Console.WriteLine(FormatAsXML(p));
            }
        }
    }
}
