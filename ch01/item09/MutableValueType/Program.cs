using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableValueType
{
    public struct Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var attendees = new List<Person>();
            Person p = new Person { Name = "以前の名前" };
            attendees.Add(p);

            Person p2 = attendees[0];
            p2.Name = "新しい名前";

            Console.WriteLine(attendees[0].ToString());
        }
    }
}
