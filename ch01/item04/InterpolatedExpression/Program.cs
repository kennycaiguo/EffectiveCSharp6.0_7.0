using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolatedExpression
{
    public class Customer
    {
        public string Name { get; set; }
    }

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
    class Program
    {
        static void NullCoalescingOperator(Customer c)
        {
            Console.WriteLine($"顧客名は{c?.Name ?? "名前が見つかりません"}");
        }

        static void NestedInterpolatedString(Records records, int index)
        {
            string result = default(string);
            Console.WriteLine($"レコードは{(records.TryGetValue(index, out result) ? result : $"インデックス{index}のレコードはありません")}");
        }

        static string LinqQuery(IEnumerable<int> src)
        {
            var output = $"最初の5項目は：{src.Take(5).Select(n => $"項目：{n.ToString()}").Aggregate((a, c) => $"{a}{Environment.NewLine}{c}")}";
            return output;
        }

        static void Main(string[] args)
        {
            Customer c = new Customer() { Name = "sasaki" };
            NullCoalescingOperator(c);
            NullCoalescingOperator(null);

            Records records = new Records();
            NestedInterpolatedString(records, 1);
            NestedInterpolatedString(records, 2);
            NestedInterpolatedString(records, 3);

            var src = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(LinqQuery(src));
        }
    }
}
