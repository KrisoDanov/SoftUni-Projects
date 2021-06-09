using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name)
            : base(name)
        {
        }
        public override int Power => 80;
        public override void CastAbility(string personName)
        {
            Console.WriteLine($"{GetType().Name} - {personName} healed for {Power}");
        }
    }
}
