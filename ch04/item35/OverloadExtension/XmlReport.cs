using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;
using PersonLib;

// やはり悪い例
//　異なる名前空間において拡張メソッドの名前が重複している
namespace XmlExtensions
{
    public static class XmlReport
    {
        public static string Format(this Person target) =>
            new XElement("Person",
                new XElement("LastName", target.LastName),
                new XElement("FirstName", target.FirstName)
                ).ToString();
    }
}
