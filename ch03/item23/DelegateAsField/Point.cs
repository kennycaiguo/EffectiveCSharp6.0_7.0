using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsField
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

        public Point(System.IO.TextReader reader)
        {
            string line = reader.ReadLine();
            string[] field = line.Split(',');
            if (field.Length != 2)
                throw new InvalidOperationException("入力形式が不正です");

            double value;
            if (!double.TryParse(field[0], out value))
                throw new InvalidOperationException("Xの値を解析できません");
            else
                X = value;

            if (!double.TryParse(field[1], out value))
                throw new InvalidOperationException("Yの値を解析できません");
            else
                Y = value;
        }

        // 2019.03.14 add
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
