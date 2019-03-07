using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolatedExpression
{
    public class Records
    {
        public bool TryGetValue(int index, out string result)
        {
            switch (index % 3)
            {
                case 1:
                    result = "rest 1";
                    return true;
                case 2:
                    result = "rest 2";
                    return true;
                default:
                    result = "unknown";
                    return false;
            }
        }
    }
}
