using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastrucure; // 2019.02.17 add

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = UsefulValues.StartValue;
                i < UsefulValues.EndValue; i++)
                Console.WriteLine("値は {0}", i);
        }
    }
}
