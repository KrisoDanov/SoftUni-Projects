using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountOfWorriorsGetsBigger()
        {
            Warrior warrior = new Warrior("Kriso", 10, 10);
           
            Arena arena = new Arena();

            arena.Enroll(warrior);

            var ourTest = 1;
            var realTest = arena.Count;
            Assert.AreEqual(ourTest, realTest);
        }

        [Test]
        public void worriorsWithTheSameNameCCanTBeAdded()
        {
            Warrior warrior = new Warrior("Kriso", 10, 10);
            Warrior warrior2 = new Warrior("Kriso", 50, 50);

            Arena arena = new Arena();
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior2));
        }

        [Test]
        [TestCase ("Kiro" , "Bace")]
        [TestCase ("Bace" , "Kiro")]
        public void ShouldThrowExceptionIfWarriordoesntExist(
            string firstFigter, string secFighter)
        {
            Warrior warrior = new Warrior("Kiro", 100, 100);
            Arena arena = new Arena();
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            arena.Fight(firstFigter, secFighter));
        }
    }
}
