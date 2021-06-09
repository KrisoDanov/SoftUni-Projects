using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Kiro", 10, 10)]
        public void ConstructorMakesItOk(string name, int dmg, int hp)
        {
            Warrior warrior = new Warrior(name: name, damage: dmg, hp: hp);

            Assert.AreEqual(warrior.Name, name);
            Assert.AreEqual(warrior.Damage, dmg);
            Assert.AreEqual(warrior.HP, hp);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void NameIsNotNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name: name, 10, 10));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void DamageIsMoreThanzeroOrNegative(int dmg)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Kiro", dmg, 10));
        }

        [Test]
        [TestCase(-5)]
        public void HP_IsMoreThanzero(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Kiro", 10, hp));
        }
        [Test]
        [TestCase("Bace", 10, 10, "Kiro", 10, 10)]
        [TestCase("Bace", 10, 100, "Kiro", 10, 10)]
        [TestCase("Bace", 10, 50, "Kiro", 100, 50)]
        public void HP_IsMoreThanMinHpToAttack(
            string warriorName, int warriorDmg,
            int warriorHp, string BaceName,
            int baceDmg, int BaceHp)
        {
            var warrior = new Warrior(warriorName, warriorDmg, warriorHp);
            var bace = new Warrior(BaceName, baceDmg, BaceHp);

            Assert.Throws<InvalidOperationException>(() => 
            warrior.Attack(bace));
        }

        [Test]
        [TestCase("Bace", 50, 100, "Kiro", 100, 100)]
        
        public void HP_IsEnoughToAttack(
            string warriorName, int warriorDmg,
            int warriorHp, string BaceName,
            int baceDmg, int BaceHp)
        {
            var warrior = new Warrior(warriorName, warriorDmg, warriorHp);
            var bace = new Warrior(BaceName, baceDmg, BaceHp);
            warrior.Attack(bace);
            var expectedOutpu = 50;
            var realOtput = bace.HP;

            Assert.AreEqual(expectedOutpu, realOtput);
        }
        [Test]
        [TestCase("Bace", 50, 100, "Kiro", 100, 49)]

        public void HP_IsEnoughToAttackAndGoesZero(
            string warriorName, int warriorDmg,
            int warriorHp, string BaceName,
            int baceDmg, int BaceHp)
        {
            var warrior = new Warrior(warriorName, warriorDmg, warriorHp);
            var bace = new Warrior(BaceName, baceDmg, BaceHp);
            warrior.Attack(bace);
            var expectedOutpu = 0;
            var realOtput = bace.HP;

            Assert.AreEqual(expectedOutpu, realOtput);
        }


    }
}