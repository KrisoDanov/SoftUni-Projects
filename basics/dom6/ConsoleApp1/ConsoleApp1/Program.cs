using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            double presentCount = 0;
            double studentsFinalAssestment = 0;
           
            while (true)
            {
                string presentationName = Console.ReadLine();

                if (presentationName == "Finish")
                {
                    break;
                }

                    presentCount++;

                double presentationAvarege = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double juryGrade = double.Parse(Console.ReadLine());

                    presentationAvarege += juryGrade;
                }
                   
                presentationAvarege /= juryCount;
                studentsFinalAssestment += presentationAvarege;

                Console.WriteLine($"{presentationName} - {presentationAvarege:F2}.");
            }
            studentsFinalAssestment /= presentCount;

            Console.WriteLine($"Student's final assessment is {studentsFinalAssestment:F2}.");

        } 
    }
}
