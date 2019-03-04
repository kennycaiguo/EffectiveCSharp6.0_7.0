using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableObject
{
    class Program
    {
        static User thisUser = new User { Name = "Sophia" };

        static string UseStringConcatination()
        {
            string msg = "Hello, ";
            msg += thisUser.Name;
            msg += ". Today is ";
            msg += System.DateTime.Now.ToString();

            return msg;
        }

        static string UseStringInterpolation()
        {
            string msg = string.Format("Hello, {0}. Today is {1}",
                thisUser.Name, DateTime.Now.ToString());

            return msg;
        }

        static string UseStringBuilder()
        {
            StringBuilder msg = new StringBuilder("Hello, ");
            msg.Append(thisUser.Name);
            msg.Append(", Today is ");
            msg.Append(DateTime.Now.ToString());
            string finalMsg = msg.ToString();

            return finalMsg;
        }

        static void Main(string[] args)
        {
            var msg = UseStringConcatination();
            Console.WriteLine(msg);

            msg = UseStringInterpolation();
            Console.WriteLine(msg);

            msg = UseStringBuilder();
            Console.WriteLine(msg);
        }
    }
}
