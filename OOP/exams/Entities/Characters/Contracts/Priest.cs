using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Inventory.Contracts;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Priest : Character, IHealer
    {
        private const double priestBaseHealth = 50;
        private const double priestBaseArmor = 25;
        private const double priestBaseAbilityPoints = 40;

        public Priest(string name)
            : base(name, priestBaseHealth, priestBaseArmor, priestBaseAbilityPoints, new Backpack())
        {
        }

        public void Heal(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                character.Health += AbilityPoints;
            }
        }
    }
}
