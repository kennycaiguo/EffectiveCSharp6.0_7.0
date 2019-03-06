using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine1 = new TaxComputation1.ComputationEngine1();
            Console.WriteLine("Engine1:");
            Console.WriteLine($"Revision: ${engine1.Revision}, RevisionMessage: {engine1.RevisionMessage}");

            var engine2 = new TaxComputation2.ComputationEngine2();
            Console.WriteLine("Engine2:");
            Console.WriteLine($"Revision: ${engine2.Revision}, RevisionMessage: {engine2.RevisionMessage}");
        }
    }
}
