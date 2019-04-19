using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace AlgorithmCallback
{
    class Program
    {
        private static readonly string DIR = @"C:\books\EffectiveCSharp6.0_7.0\ch04\item41\AlgorithmCallback\data\";

        // デリゲート型の宣言
        public delegate TResult ProcessElementsFromFile<TResult>(
            IEnumerable<IEnumerable<int>> values);

        // ファイルを読み取り、デリゲートを使用して各行を処理するメソッド
        public static TResult ProcessFile<TResult>(string filePath,
            ProcessElementsFromFile<TResult> action)
        {
            // 2019.04.20 change
            //using (TextReader t = new StreamReader(File.Open(filePath)))
            using (TextReader t = new StreamReader(File.OpenRead(filePath)))
            {
                var allLines = from line in t.ReadLines()
                               select line.Split(',');
                var matrixOfValues = from line in allLines
                                     select from item in line
                                            select item.DefaultParse(0);
                return action(matrixOfValues);
            }
        }

        static void Main(string[] args)
        {
            //　使用例：ファイル名と、ファイルをの各行に対して実行する処理を
            //　引数として指定する
            ProcessFile(DIR + "TestFile.txt",
                (arrayOfNums) =>
                {
                    foreach (var line in arrayOfNums)
                    {
                        foreach (int num in line)
                            Write($"{num}, ");
                        WriteLine();
                    }

                    // コンパイラに迷惑をかけないように何かしら値を返す
                    return 0;
                }
            );
        }
    }
}
