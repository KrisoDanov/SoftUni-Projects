using System;
using System.Collections.Generic;
using System.Linq;

namespace dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = nums[0];
            int end = nums[1];

            string comands = Console.ReadLine();
            Func<int, int, List<int>> selection = (start, end) =>
             {
                 List<int> answear = new List<int>();
                 
                 for (int i = start; i < end + 1; i++)
                 {
                     answear.Add(i);
                 }
                 return answear;
             };
            List<int> numss = selection(start, end);

            if (comands == "odd")
            {

                numss = numss.Where(x => x % 2 == 1).ToList();
            }
            else if (comands == "even")
            {
                numss = numss.Where(x => x % 2 == 0).ToList();
            }
           
                Console.WriteLine(string.Join(" ", numss));
            
            
        }
    }
}
