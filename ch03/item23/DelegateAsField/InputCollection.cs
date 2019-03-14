using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsField
{
    public delegate T CreateFromStream<T>(TextReader reader);
    public class InputCollection<T>
    {
        private List<T> thingsRead = new List<T>();
        private readonly CreateFromStream<T> readFunc;

        public InputCollection(CreateFromStream<T> readFunc)
        {
            this.readFunc = readFunc;
        }

        public void ReadFromStream(TextReader reader) =>
            thingsRead.Add(readFunc(reader));

        public IEnumerable<T> Values => thingsRead;
    }
}
