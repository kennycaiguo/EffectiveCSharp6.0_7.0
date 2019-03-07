using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.02.23 add
using System.ComponentModel;

namespace PropertyChanged
{
    public class Person
    {
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
