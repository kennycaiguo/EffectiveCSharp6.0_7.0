using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public class CancelableExecution
    {
        private List<ComplicatedClass> container;

        public CancelableExecution(List<ComplicatedClass> c)
        {
            container = c;
        }

        public void LengthyOperation(Func<bool> pred)
        {
            foreach (ComplicatedClass cl in container)
            {
                cl.DoLengthyOperation();
                if (false == pred())
                    return;
            }
        }

        public void LengthyOperation2(Func<bool> pred)
        {
            bool bContinue = true;
            foreach (ComplicatedClass cl in container)
            {
                cl.DoLengthyOperation();
                foreach (Func<bool> pr in pred.GetInvocationList())
                    bContinue &= pr();

                if (!bContinue)
                    return;
            }
        }
    }
}
