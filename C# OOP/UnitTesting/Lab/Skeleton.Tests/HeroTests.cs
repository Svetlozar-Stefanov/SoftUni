using Moq;
using NUnit.Framework;
using Skeleton.Contracts;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        private Mock<ITarget> dummy;
        private Mock<IWeapon> weapon;

        [SetUp]
        public void SetMockings()
        {
            dummy = new Mock<ITarget>();

            dummy.Setup(d => d.Health).Returns(0);
            dummy.Setup(d => d.GiveExperience()).Returns(10);
            dummy.Setup(d => d.IsDead()).Returns(true);

            weapon = new Mock<IWeapon>();
        }

        [Test]
        public void HeroShouldTakeXPFromTarget()
        {
            Hero hero = new Hero("Koicho - The Brave", weapon.Object);

            int initialXP = hero.Experience;
            hero.Attack(dummy.Object);

            Assert.That(hero.Experience, Is.GreaterThan(initialXP));
        }
    }
}
