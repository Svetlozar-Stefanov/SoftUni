using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior testWarrior;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            testWarrior = new Warrior("Leonidas", 20, 100);
        }

        [Test]
        public void ConstructorInitializesCorrectly()
        {
            Arena arena = new Arena();

            Assert.That(arena.Warriors, Is.Not.Null, "Constructor initilaizes incorrectly");
        }

        [Test]
        public void EnrollShouldAddWarrior()
        {
            int expectedCount = 1;

            arena.Enroll(testWarrior);

            Assert.AreEqual(expectedCount, arena.Count, "Doesnt enroll correctly");
        }

        [Test]
        public void EnrollCannotAddWarriorTwice()
        {
            arena.Enroll(testWarrior);
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(testWarrior);
            });
        }

        [Test]
        [TestCase("Any", "Leonidas")]
        [TestCase("Leonidas", "Any")]
        public void FightValidation(string warrior1, string warrior2)
        {
            arena.Enroll(testWarrior);
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(warrior1, warrior2);
            });
        }

        [Test]
        public void FightShouldAffectWarriors()
        {
            int expectedAttackerHp = 80;
            int expectedDefenderHp = 80;

            Warrior defender = new Warrior("Koicho", 20 ,100);

            arena.Enroll(testWarrior);
            arena.Enroll(defender);

            arena.Fight(testWarrior.Name, defender.Name);

            Assert.AreEqual(expectedAttackerHp, testWarrior.HP);
            Assert.AreEqual(expectedDefenderHp, testWarrior.HP);
        }
    }
}
