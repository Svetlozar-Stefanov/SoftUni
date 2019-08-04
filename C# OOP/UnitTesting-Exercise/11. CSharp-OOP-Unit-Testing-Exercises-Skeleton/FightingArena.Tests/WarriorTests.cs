using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class WarriorTests
    {
        private const string testName = "Achilies";
        private const int testDamage = 10;
        private const int testHp = 100;

        private Warrior testWarrior;

        [SetUp]
        public void Setup()
        {
            testWarrior = new Warrior(testName, testDamage, testHp);
        }

        [Test]
        public void ConstructorInitializesCorrectly()
        {
            string expectedName = testName;
            int expectedDamage = testDamage;
            int expectedHp = testHp;

            Warrior warrior = new Warrior(testName, testDamage, testHp);

            Assert.AreEqual(expectedName, warrior.Name);
            Assert.AreEqual(expectedDamage, warrior.Damage);
            Assert.AreEqual(expectedHp, warrior.HP);
        }

        [Test]
        [TestCase(null)]
        [TestCase("   ")]
        [TestCase("")]
        public void NameCannotBeNullOrWhitespace(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(name, testDamage, testHp);
            }
                , "Name cannot be null, empty or whitespace");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void DamageCannotBeZeroOrNegative(int damage)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(testName, damage, testHp);
            }
                , "Damage cannot be zero or negative");
        }

        [Test]
        [TestCase(-1)]
        public void HpCannotBeNegative(int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Warrior warrior = new Warrior(testName, testDamage, hp);
            }
                , "Hp cannot be negative");
        }

        [Test]
        public void AttackerCannotAttackWithLowHp()
        {
            Warrior warrior = new Warrior(testName, testDamage, 10);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(testWarrior);
            }
                , "Should not attack with low hp");
        }

        [Test]
        public void AttackerCannotAttackDefenderWithLowHp()
        {
            Warrior defender = new Warrior(testName, testDamage, 10);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testWarrior.Attack(defender);
            }
                , "Should not attack defender with low hp");
        }

        [Test]
        public void CannotAttackStrongerEnemy()
        {
            Warrior attacker = new Warrior(testName, testDamage, 40);
            Warrior defender = new Warrior(testName, 50, 40);

            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            }
                , "Should not attack stronger enemy");
        }

        [Test]
        public void DeffenderShouldDieIfHpIsZero()
        {
            int expectedAttackerHp = 90;
            int expectedDefenderHp = 0;

            Warrior attacker = new Warrior(testName, 40, 100);
            Warrior defender = new Warrior(testName, 10, 35);

            attacker.Attack(defender);

            Assert.AreEqual(expectedAttackerHp, attacker.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }

        [Test]
        public void DeffenderShouldTakeOutAttackersDamage()
        {
            int expectedAttackerHp = 90;
            int expectedDefenderHp = 80;

            Warrior attacker = new Warrior(testName, 10, 100);
            Warrior defender = new Warrior(testName, 10, 90);

            attacker.Attack(defender);

            Assert.AreEqual(expectedAttackerHp, attacker.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }
    }
}