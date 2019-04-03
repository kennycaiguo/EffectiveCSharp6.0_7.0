using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByMethod
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{{ LastName={LastName}, FirstName={FirstName}, Age={Age}, Department={Department} }}";
        }
    }
}
