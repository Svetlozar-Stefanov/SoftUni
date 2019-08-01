using Moq;
using NUnit.Framework;
using Skeleton.Contracts;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Mock<ITarget> dummyMock;

        [SetUp]
        public void SetUpDummy()
        {
            dummyMock = new Mock<ITarget>();
            dummyMock.Setup(d => d.Health).Returns(20);
            dummyMock.Setup(d => d.GiveExperience()).Returns(10);
            dummyMock.Setup(d => d.IsDead()).Returns(false);
        }

        [Test]
        public void AttackShouldTakeOutDurability()
        {
            Axe axe = new Axe(20, 45);

            int initialDurability = axe.DurabilityPoints;

            axe.Attack(dummyMock.Object);

            Assert.That(axe.DurabilityPoints, Is.LessThan(initialDurability),"Durability doesn`t change");
        }

        [Test]
        public void ShouldNotBeAbleToAttackWithBrokenWeapon()
        {
            Axe axe = new Axe(20, 0);

            Assert.That(() => axe.Attack(dummyMock.Object), Throws.InvalidOperationException, "Shouldn`t be able to attack with broken weapon");
        }
    }
}
