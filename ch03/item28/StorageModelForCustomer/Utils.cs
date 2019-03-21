using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageModelForCustomer
{
    public static class Utils
    {
        public static void SendEmail(string name, string address, string message)
        {
            Console.WriteLine($"SendEmail(name={name}, address={address}, message={message})");
        }
    }
}
