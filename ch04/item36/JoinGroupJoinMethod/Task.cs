using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinGroupJoinMethod
{
    public class Task
    {
        Project project;
        string name;
        public Task(Project project, string name)
        {
            this.project = project;
            this.name = name;
        }

        public Project Parent { get { return project; } }
        public string Name { get { return name; } }
        public override string ToString()
        {
            return $"Task{{ Parent={Parent}, Name={Name} }}";
        }
    }
}
