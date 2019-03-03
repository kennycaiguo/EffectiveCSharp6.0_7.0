using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroInitialize
{
    public struct MyValType
    {
        int iVal;
        double dVal;
        List<int> listVal;

        public int IntVal { get { return iVal; } }
        public double DoubleVal { get { return dVal; } }
        public List<int> ListVal { get { return listVal; } }
    }
}
