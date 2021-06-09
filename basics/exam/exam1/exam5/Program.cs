using System;

namespace exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int minutes = int.Parse(Console.ReadLine());
            int secs = int.Parse(Console.ReadLine());

            int goldCard = 0;
            int silverCard = 0;
            int bronzeCard = 0;

            string nameWinner = "";
            int minMinutes = int.MaxValue;
            int minSecs = int.MaxValue;

            while (true)
            {

                if (minutes == 0 && secs < 55)
                {
                    goldCard++;
                }
                if (minutes == 0 && secs >=55 || minutes == 1 && secs < 25)
                {
                    silverCard++;
                }
                if (minutes == 1 && secs >= 25 || minutes == 2 && secs == 0)
                {
                    bronzeCard++;
                }



                if (minutes < minMinutes)
                {
                    if (minutes == minMinutes )
                    {

                        if (secs < minSecs)
                        {
                            minMinutes = minutes;
                            minSecs = secs;
                            nameWinner = name;
                        }

                    }
                    else
                    {
                        minMinutes = minutes;
                        minSecs = secs;
                        nameWinner = name;
                    }
                    

                }
                name = Console.ReadLine();
                if (name == "Finish")
                {
                    break;
                }
                minutes = int.Parse(Console.ReadLine());
                secs = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"With {minMinutes} minutes and {minSecs} seconds {nameWinner} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {goldCard} Gold {silverCard} Silver and {bronzeCard} Bronze cards!");



        }
    }
}
