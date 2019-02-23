using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullArgument
{
    class Program
    {
        public static void ExceptionMessage(object thisCantBeNull)
        {
            if (thisCantBeNull == null)
                throw new
                    ArgumentNullException(nameof(thisCantBeNull),
                        "値をnullにできません");
        }
        static void Main(string[] args)
        {
            ExceptionMessage(args);
            ExceptionMessage(null);

        }
    }
}
