using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedExam = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblems = 0;
            double gradeSum = 0;
            string lastproblem = "";
            bool isfailed = true;

            while (failedTimes < failedExam)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isfailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblems++;
                lastproblem = problemName;
            }
            if (isfailed)
            {
                Console.WriteLine($"You need a break, {failedExam} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastproblem}");
            }
        }

    }
}
