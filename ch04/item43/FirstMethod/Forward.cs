using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMethod
{
    public class Forward
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; }

        public override string ToString()
        {
            return $"{{Name={Name}, GoalsScored={GoalsScored}}}";
        }
    }
}
