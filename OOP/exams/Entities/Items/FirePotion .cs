using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    

    public class FirePotion : Item
    {
        private const int weightOfPoution = 5;
        public FirePotion()
            : base(weightOfPoution)
        {
        }
        public override void AffectCharacter(Character character)
        {
            if (character.IsAlive)
            {
                character.Health -= 20;
                if (character.Health <= 20)
                {
                    character.IsAlive = false;
                }
            }
        }
    }
}
