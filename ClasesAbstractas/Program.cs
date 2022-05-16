using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int mid = (arr.Length + 1) / 3;
            int[] firstHalf = arr.Take(mid).ToArray();
            int[] secondHalf = arr.Skip(mid).ToArray();
            int[] threedHalf = arr.Skip(mid).ToArray();

            Console.WriteLine(String.Join(", ", firstHalf));
            Console.WriteLine(String.Join(", ", secondHalf));
            Console.WriteLine(String.Join(", ", threedHalf));


        }







    }
}


