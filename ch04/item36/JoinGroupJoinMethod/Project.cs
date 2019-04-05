using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinGroupJoinMethod
{
    public class Project
    {
        string name;
        public Project(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
        public override string ToString()
        {
            return $"Prject{{ Name={Name} }}";
        }
    }
}
