using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name)
            : base(name)
        {
            
        }
        public override int Power => 80;
        public override void CastAbility(string personName)
        {
            Console.WriteLine($"{GetType().Name} - {personName} hit for {Power} damage");
        }
    }
}
