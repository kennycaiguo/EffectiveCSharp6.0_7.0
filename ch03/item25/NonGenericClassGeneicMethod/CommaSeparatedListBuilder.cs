using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericClassGeneicMethod
{
    public class CommaSeparatedListBuilder
    {
        private StringBuilder storage = new StringBuilder();

        public void Add<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                if (storage.Length > 0)
                    storage.Append(", ");
                storage.Append("\"");
                storage.Append(item.ToString());
                storage.Append("\"");
            }
        }

        public override string ToString() => storage.ToString();
    }
}
