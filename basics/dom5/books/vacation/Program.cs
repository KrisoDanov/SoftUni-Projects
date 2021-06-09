using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyVacation = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendingDays = 0;
            
            
            while (true)
            {             
                string spendOrSave = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (spendOrSave == "spend")
                {
                    ownedMoney -= money;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                    spendingDays++;
                }
                else if (spendOrSave == "save")
                {
                    ownedMoney += money;
                    spendingDays = 0;
                }
                days++;

                if (spendingDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
                else if (ownedMoney >= moneyVacation)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }

           
        }
    }
}
