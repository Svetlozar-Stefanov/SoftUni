using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy livingDummy;
        private Dummy deadDummy;

        [SetUp]
        public void SetDummies()
        {
            livingDummy = new Dummy(45, 20);
            deadDummy = new Dummy(0, 20);
        }

        [TearDown]
        public void TearDummies()
        {
            livingDummy = null;
            deadDummy = null;
        }

        [Test]
        public void DummyShouldLoseHealthWhenAttacked()
        {
            int initialHealth = livingDummy.Health;

            livingDummy.TakeAttack(20);

            Assert.That(livingDummy.Health, Is.LessThan(initialHealth), "Health doesn`t lower after an attack");
        }

        [Test]
        public void DummyShouldNotBeAttackedIfDead()
        {
            Assert.That(() => deadDummy.TakeAttack(20), Throws.InvalidOperationException, "Dummy was attacked when dead");
        }

        [Test]
        public void DeadDummyShouldThrowXP()
        {
            int expectedXP = 20;
            int actualXP = deadDummy.GiveExperience();

            Assert.AreEqual(expectedXP, actualXP, "Dummy doesn`t give XP");
        }

        [Test]
        public void AliveDummyShouldntThrowXP()
        {
            Assert.That(() => livingDummy.GiveExperience(), Throws.InvalidOperationException, "Alive dummy threw XP");
        }
    }
}
