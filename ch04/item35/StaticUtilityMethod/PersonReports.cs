using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PersonLib;

namespace StaticUtilityMethod
{
    public static class PersonReports
    {
        public static string FormatAsText(Person target) =>
            $"{target.LastName,20}, {target.FirstName,15}";
        public static string FormatAsXML(Person target) =>
            new XElement("Person",
                new XElement("LastName", target.LastName),
                new XElement("FirstName", target.FirstName)
            ).ToString();
    
    }
}
