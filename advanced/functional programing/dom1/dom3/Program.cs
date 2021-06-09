using System;
using System.Linq;

namespace dom3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minNum = x =>
            {
                int min = Int32.MaxValue;
                foreach (var item in x)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(minNum(nums));

        }
    }
}
