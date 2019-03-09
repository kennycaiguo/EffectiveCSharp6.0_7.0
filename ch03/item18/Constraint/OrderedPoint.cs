using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraint
{
    public class OrderedPoint : Point, IComparable<OrderedPoint>, IComparable<Point>
    {
        public int CompareTo(OrderedPoint other)
        {
            if (other == null) return -1;

            int cmp = X.CompareTo(other.X);
            if (cmp != 0) return cmp;
            return Y.CompareTo(other.Y);
        }

        public int CompareTo(Point other)
        {
            if (other == null) return -1;

            int cmp = X.CompareTo(other.X);
            if (cmp != 0) return cmp;
            return Y.CompareTo(other.Y);
        }
    }
}
