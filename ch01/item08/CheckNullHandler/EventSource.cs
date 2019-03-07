using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNullHandler
{
    public class EventSource
    {
        private EventHandler<int> Updated;
        public void SetHandler(EventHandler<int> h)
        {
            Updated = h;
        }
        public void ClearHandler()
        {
            Updated = null;
        }
        public void RaiseUpdates()
        {
            counter++;
            if (Updated != null)
                Updated(this, counter);
        }

        private int counter;
    }
}
