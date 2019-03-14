using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsSequenceAlgorithm
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        // 2019.03.14 add
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
