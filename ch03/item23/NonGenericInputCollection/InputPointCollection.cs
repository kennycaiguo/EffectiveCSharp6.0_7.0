using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericInputCollection
{
    class InputPointCollection
    {
        private List<Point> thingsRead = new List<Point>();
        public void ReadFromStream(TextReader reader) =>
            thingsRead.Add(new Point(reader));

        public IEnumerable<Point> Values => thingsRead;
    }
}
