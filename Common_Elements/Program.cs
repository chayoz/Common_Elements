using System;
using System.Collections.Generic;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 10, 45, 2, 56, 12, 34, 90, 27 };
            int[] a2 = { 45, 1, 89, 77, 2, 90, 100 };
            var common = a1.Intersect(a2);
            common = common.OrderBy(x => x);
            foreach (var c in common)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
