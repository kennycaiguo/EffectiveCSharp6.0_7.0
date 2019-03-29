using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRemoveAll
{
    public class MyList<T> : IEnumerable<T>
    {
        List<T> list;
        public MyList(List<T> list)
        {
            this.list = list;
        }

        public void RemoveAll(IPredicate<T> match)
        {
            list.RemoveAll(match.Match);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
