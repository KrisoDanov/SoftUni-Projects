using System;

namespace Raiding
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int allPower = 0;
            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                if (heroType == "Paladin")
                {
                    BaseHero hero = new Paladin(heroType);
                    allPower += hero.Power;
                    hero.CastAbility(heroName);
                }
               else if (heroType == "Druid")
                {
                    BaseHero hero = new Druid(heroType);
                    allPower += hero.Power;
                    hero.CastAbility(heroName);
                }
                else if (heroType == "Warrior")
                {
                    BaseHero hero = new Warrior(heroType);
                    allPower += hero.Power;
                    hero.CastAbility(heroName);
                }
                else if(heroType == "Rogue")
                {
                    BaseHero hero = new Rogue(heroType);
                    allPower += hero.Power;
                    hero.CastAbility(heroName);
                }
               
            }
            int finalBoss = int.Parse(Console.ReadLine());
            if (finalBoss <= allPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
