using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ListManipulate
{

    class Program
    {
        static void Main(string[] args)
        {
            var myInts = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            myInts.RemoveAll(collectionMember => collectionMember == 5);
            myInts.ForEach(collectionMember => WriteLine(collectionMember));
        }
    }
}
