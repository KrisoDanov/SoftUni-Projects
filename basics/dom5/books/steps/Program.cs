using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 10000;
            string home = "";

            while (true)
            {
                int stepsNow = int.Parse(Console.ReadLine());
                int currentSteps = 0;
                if (stepsNow <= currentSteps)
                {
                    currentSteps += stepsNow;
                   
                }
                if (home == "Going home")
                {
                    currentSteps += stepsNow;
                        break;

                }
                if (stepsNow >= currentSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{currentSteps - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{currentSteps - steps}more steps to reach goal.");
                }
            }

        }
    }
}
