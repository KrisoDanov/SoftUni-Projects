using System;
using System.Collections.Generic;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;
using System.Linq;
using System.Text;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> players;
        private List<Item> itemss;
        public WarController()
        {
            players = new List<Character>();
            itemss = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            string characterType = args[0];
            string name = args[1];
            Character character;

            if (characterType != "Warrior" && characterType != "Priest")
            {
                throw new ArgumentException($"Invalid character type \"{characterType}\"!");
            }
            if (characterType == "Warrior")
            {
                character = new Warrior(name);
            }
            else
            {
                character = new Priest(name);
            }
            players.Add(character);
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string nameOfItem = args[0];
            Item item;

            if (nameOfItem != "FirePotion" && nameOfItem != "HealthPotion")
            {
                throw new ArgumentException($"Invalid item \"{nameOfItem}\"!");
            }
            if (nameOfItem == "FirePotion")
            {
                item = new FirePotion();
            }
            else
            {
                item = new HealthPotion();
            }
            itemss.Add(item);

            return $"{nameOfItem} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string name = args[0];
            if (players.FirstOrDefault(x => x.Name == name) == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }
            if (itemss.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
            players.FirstOrDefault(x => x.Name == name)
                .BagOfPlayer.AddItem(itemss.Last());
            string nameOfItem = itemss.Last().GetType().Name;
            itemss.Remove(itemss.Last());
            return $"{name} picked up {nameOfItem}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];
            if (players.FirstOrDefault(x => x.Name == characterName) == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            players.FirstOrDefault(x => x.Name == characterName).UseItem(players.FirstOrDefault(x => x.Name == characterName)
                .BagOfPlayer.Items.FirstOrDefault(x => x.GetType().Name == itemName));
            return $"{characterName} used {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            players = players.OrderByDescending(x => x.IsAlive).
                ThenBy(x => x.Health).ToList();
            foreach (var player in players)
            {

                string str = string.Empty;
                if (player.IsAlive)
                {
                    str = "Alive";
                }
                else
                {
                    str = "Dead";
                }
                sb.AppendLine($"{player.Name} - HP: {player.Health}/{player.BaseHealth}, AP: {player.Armor}/{player.BaseArmor}, Status: {str}");
            }
            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string receiverName = args[1];
            Character attacker = players.FirstOrDefault(x => x.Name == attackerName);
            Character receiver = players.FirstOrDefault(x => x.Name == receiverName);
            if (attacker == null)
            {
                throw new ArgumentException($"Character {attacker} not found!");
            }
            if (receiver == null)
            {
                throw new ArgumentException($"Character {receiver} not found!");
            }
            if (attacker.IsAlive == false)
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }
            receiver.TakeDamage(attacker.AbilityPoints);
            string output = $"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";
            if (receiver.IsAlive == false)
            {
                return output + Environment.NewLine + $"{receiver.Name} is dead!";
            }
            else
            {
                return output;
            }


        }

        public string Heal(string[] args)
        {
            string healerNamee = args[0];
            string healingReceiverNamee = args[1];
            Character healerName = players.FirstOrDefault(x => x.Name == healerNamee);
            Character healingReceiverName = players.FirstOrDefault(x => x.Name == healingReceiverNamee);
            if (healerName == null)
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }
            if (healingReceiverName == null)
            {
                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }
            if (healerName.IsAlive == false)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }
            healingReceiverName.Health += healerName.AbilityPoints;
            string output = $"{healerName} heals {healingReceiverName} for {healerName.AbilityPoints}! {healingReceiverName.Name} has {healingReceiverName.Health} health now!";


                return output;
          
        }
    }
}
