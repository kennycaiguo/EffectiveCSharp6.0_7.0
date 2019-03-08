using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNullConditionalOperator
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
            Updated?.Invoke(this, counter);
        }

        private int counter;
    }
}
