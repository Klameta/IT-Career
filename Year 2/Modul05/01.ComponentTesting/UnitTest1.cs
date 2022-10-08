using NUnit.Framework;
using System;
namespace Testing
{
    public class Tests
    {
        private Axe normalAxe;
        private Axe brokenAxe;

        private Dummy normalDummy;
        private Dummy deadDummy;
        private int normalPoints = 10;
        private int brokenPoints = 0;

        [SetUp]
        public void Setup()
        {
            this.normalAxe = new Axe(normalPoints, normalPoints);
            this.brokenAxe = new Axe(normalPoints, brokenPoints);
            this.normalDummy = new Dummy(normalPoints, normalPoints);
            this.deadDummy = new Dummy(brokenPoints, normalPoints);
        }

        [Test]
        public void DoesAxeLoseDurability()
        {
            normalAxe.Attack(normalDummy);

            Assert.AreEqual(9, normalAxe.DurabilityPoints);
        }
        [Test]
        public void AttackBrokenAxe()
        {
            Assert.Throws<InvalidOperationException>(
                () => brokenAxe.Attack(normalDummy));
        }
        [Test]
        public void DummyLosingHealthWhenAttacked()
        {
            normalAxe.Attack(normalDummy);

            Assert.AreEqual(brokenPoints, normalDummy.Health);
        }
        [Test]
        public void DeadDummyCannotBeAttacked()
        {
            var exception = Assert.Throws<InvalidOperationException>(
                () => normalAxe.Attack(deadDummy));
            Assert.AreEqual(exception.Message, "Dummy is dead.");
        }
        [Test]
        public void DeadDummyGivingXP()
        {
            Assert.AreEqual(normalPoints, deadDummy.GiveExperience());
        }
        [Test]
        public void AliveDummyDoesNotGiveXP()
        {
            var exception = Assert.Throws<InvalidOperationException>(
                () => normalDummy.GiveExperience());

            Assert.AreEqual(exception.Message, "Target is not dead.");
        }
    }
}