using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByThenByMethod
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{{ LastName={LastName}, FirstName={FirstName}, Age={Age} }}";
        }
    }
}
