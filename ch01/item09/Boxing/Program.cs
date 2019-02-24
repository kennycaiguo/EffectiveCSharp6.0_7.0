using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1, secondNumber = 2, thirdNumber = 3;
            Console.WriteLine($"いくつかの数値：{firstNumber}, {secondNumber}, {thirdNumber}");
            Console.WriteLine($"いくつかの数値：{firstNumber.ToString()}, {secondNumber.ToString()}, {thirdNumber.ToString()}");

        }
    }
}
