using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatString
{
    class Program
    {
        public static string ToGerman(FormattableString src)
        {
            /*
            return string.Format(null,
                System.Globalization.CultureInfo.
                CreateSpecificCulture("de-de"),
                src.Format,
                src.GetArguments());
            */
            return src.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("de-de"));
        }

        public static string ToFrenchCanada(FormattableString src)
        {
            return src.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fr-CA"));
        }

        static void Main(string[] args)
        {
            String first =
                $"今日は{DateTime.Now.Month}月{DateTime.Now.Day}日です";
            Console.WriteLine(first);

            FormattableString second =
                $"今日は{DateTime.Now.Month}月{DateTime.Now.Day}日です";
            Console.WriteLine(second);

            var third =
                $"今日は{DateTime.Now.Month}月{DateTime.Now.Day}日です";
            Console.WriteLine(third);

            var num = $"{123.45}";
            FormattableString formattable = $"{123.45}";

            Console.WriteLine(num);
            Console.WriteLine(ToGerman(formattable));
            Console.WriteLine(ToFrenchCanada(formattable));
        }
    }
}
