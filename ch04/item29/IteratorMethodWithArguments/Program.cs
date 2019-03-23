using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorMethodWithArguments
{
    using static Iterator;

    class Program
    {
        static void PrintChars(char first, char last)
        {
            Console.WriteLine($"\nPrintChars(first={(int)first}, last={(int)last}):\n");

            IEnumerable<char> enemerable;
            try
            {
                Console.WriteLine($"try call GenerateAlphabetSubset({(int)first},{(int)last})");
                enemerable = GenerateAlphabetSubset(first, last);
                try
                {
                    Console.WriteLine("try print chars");
                    foreach (var c in enemerable)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void PrintChars_compiled(char first, char last)
        {
            Console.WriteLine($"\nPrintChars_compiled(first={(int)first}, last={(int)last}):\n");

            IEnumerable<char> enemerable;
            try
            {
                Console.WriteLine($"try call EmbeddedSubsetIterator.GenerateAlphabetSubset({(int)first},{(int)last})");
                enemerable = EmbeddedSubsetIterator.GenerateAlphabetSubset(first, last);
                try
                {
                    Console.WriteLine("try print chars");
                    foreach (var c in enemerable)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main(string[] args)
        {
            PrintChars('a', 'z');
            PrintChars('\t', 'z');
            PrintChars((char)127, 'z');
            PrintChars('b', 'a');
            PrintChars('a', (char)127);

            PrintChars_compiled('a', 'z');
            PrintChars_compiled('\t', 'z');
            PrintChars_compiled((char)127, 'z');
            PrintChars_compiled('b', 'a');
            PrintChars_compiled('a', (char)127);

        }
    }
}
