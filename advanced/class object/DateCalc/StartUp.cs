using System;

namespace DateCalc
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateCalc = new DateModifier();
            var result = dateCalc.GetDaysDiff(startDate, endDate);
            Console.WriteLine(Math.Abs(result));
        }
    }
}
