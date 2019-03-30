using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLib;
using ConsoleExtensions;
// 拡張メソッドの場合、それを定義する静的クラスの using static は必要ない

//using XmlExtensions;
// 次のメソッドまたはプロパティ間で呼び出しが不適切です: 
// 'ConsoleExtensions.ConsoleReport.Format(PersonLib.Person)' と 'XmlExtensions.XmlReport.Format(PersonLib.Person)'

namespace OverloadExtension
{
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
                Console.WriteLine(p.Format());

            XmlExtensionsUser.ReportAsXml(somePresidents);
        }
    }
}
