using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonLib;

//　悪い例
//　拡張メソッドでクラスの機能を拡張する
namespace ConsoleExtensions
{
    public static class ConsoleReport
    {
        public static string Format(this Person target) =>
            $"{target.LastName,20}, {target.FirstName,15}";
    }
}
