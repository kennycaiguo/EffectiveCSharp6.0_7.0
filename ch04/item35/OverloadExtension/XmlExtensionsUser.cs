using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLib;
using XmlExtensions;

namespace OverloadExtension
{
    public static class XmlExtensionsUser
    {
        public static void ReportAsXml(IEnumerable<Person> peaple)
        {
            foreach (Person p in peaple)
                Console.WriteLine(p.Format());
        }
    }
}
