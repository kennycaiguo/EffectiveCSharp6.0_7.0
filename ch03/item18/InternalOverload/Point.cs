using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalOverload
{
    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class EquatablePointClass : PointClass, IEquatable<EquatablePointClass>
    {
        public bool Equals(EquatablePointClass other)
        {
            if (other == null)
                return false;
            if (GetType() != other.GetType())
                return false;

            return X == other.X && Y == other.Y;
        }
    }
}
