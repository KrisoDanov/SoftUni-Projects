using System;
using System.Linq;

namespace upr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int pariZaDavane = 0;

            if (n > l)
            {
                pariZaDavane = (n - l) * m;
            }
            Console.WriteLine(pariZaDavane);
        }
    }
}
