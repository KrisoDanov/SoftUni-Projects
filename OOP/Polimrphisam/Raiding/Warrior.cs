using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        
        public Warrior(string name) 
            : base(name)
        {
            
        }
        public override int Power => 100;
        public override void CastAbility(string personName)
        {
            Console.WriteLine($"{GetType().Name} - {personName} hit for {Power} damage");
        }
    }
}
