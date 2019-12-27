using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statika_ISD
{

    class Program
    {
        static void Main(string[] args)
        {
            // Calc
            Console.WriteLine(Calculator.Plus(4, 6));
            Console.WriteLine(Calculator.Division(1, 7));

            // Extended method
            int[] extArr = new int[5] { 6, 15, 3, -2, 298};

            extArr.SortExtendedArray(SortWay.asc);
            for (int i = 0; i < extArr.Length; i++)
            {
                Console.WriteLine($"extArr[{i}] = {extArr[i]}");
            }
            // Extended method with bool
            bool IsAscending = false;
            extArr.SortExtendedArray(IsAscending);
            for (int i = 0; i < extArr.Length; i++)
            {
                Console.WriteLine($"extArr[{i}] = {extArr[i]}");
            }

            // Extended string 
            string test = "An array is a group of like-typed variables that are referred to by a common name.";

            Console.WriteLine(test.ExtIndexOf('d'));
            Console.WriteLine(test.ExtSubString(5, 19));
            Console.WriteLine(test.ExtReplace("array", "collection"));


            Console.ReadLine();
        }
    }
}
