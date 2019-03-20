using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenssionMethod
{
    public class Name : IComparable<Name>
    {
        public string First { get; set; }
        public string Last { get; set; }

        public int CompareTo(Name other)
        {
            if (Object.ReferenceEquals(this, other))
                return 0;
            if (Object.ReferenceEquals(other, null))
                return 1; // 非nullの値はnullより大
            int rVal = Comparer<string>.Default.Compare(Last, other.Last);
            if (rVal != 0)
                return rVal;
            return Comparer<string>.Default.Compare(First, other.First);
        }
    }
}
