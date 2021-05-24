using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_CompareTriplets
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }
}
