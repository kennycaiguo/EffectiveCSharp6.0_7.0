using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public class ComplicatedClass
    {
        public string Name { get; set; }
        public void DoLengthyOperation()
        {
            Console.WriteLine("Do " + Name);
        }
    }
}
