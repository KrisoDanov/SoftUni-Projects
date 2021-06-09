using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;

        public Character(string name, double health,
            double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.BagOfPlayer = bag;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        public double BaseHealth
        {
            get { return baseHealth; }
            set { baseHealth = value; }
        }
     

        public double Health
        {
            get { return health; }
            set
            {
                if (value <= baseHealth && value >= 0)
                {

                    health = value;
                }

            }
        }
       

        public double BaseArmor
        {
            get { return baseArmor; }
            set { baseArmor = value; }
        }
        private double armor;

        public double Armor
        {
            get { return armor; }
            set
            {
                if (armor >= 0)
                {
                    armor = value;
                }

            }
        }

        public double AbilityPoints { get; set; }

        public Bag BagOfPlayer { get; set; }


        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            if (this.IsAlive == true)
            {
                double hitPointsLeft = 0;
                if (Armor - hitPoints <= 0)
                {
                    hitPointsLeft = hitPoints - Armor;
                    Armor = 0;
                    Health -= hitPointsLeft;
                }
                if (Health <= 0)
                {
                    IsAlive = false;
                    
                }
            }
        }
        public void UseItem(Item item)
        {
            if (IsAlive == true)
            {
                item.AffectCharacter(this);
            }
        }

    }
}