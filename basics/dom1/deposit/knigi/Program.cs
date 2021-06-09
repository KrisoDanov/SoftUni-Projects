using System;

namespace knigi
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double timereading = pages / time;
            double result = timereading / days;

            Console.WriteLine(result);
        }
    }
}
