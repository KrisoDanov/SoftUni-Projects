using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Inventory.Contracts;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Warrior : Character , IAttacker 
    {
        private const double warriorBaseHealth = 100;
        private const double warriorBaseArmor = 50;
        private const double warriorBaseAbilityPoints = 40;
 
        public Warrior(string name) 
            : base(name, warriorBaseHealth, warriorBaseArmor, warriorBaseAbilityPoints, new Satchel())
        {
        }

        public void Attack(Character character)
        {
            if (this.IsAlive && character.IsAlive)
            {
                if (this.Name == character.Name)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }
                character.TakeDamage(AbilityPoints);
            }
            
        }
    }
}
