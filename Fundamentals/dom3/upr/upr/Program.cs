using System;

namespace upr
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1000;
            int temp = 0;

            for (int i = 2; i <= num; i++)
            {
                temp = i;
                if (temp % 2 == 1)
                {
                    temp = temp - (2* temp);
                }
                Console.WriteLine(temp);
            }
        }
    }
}
