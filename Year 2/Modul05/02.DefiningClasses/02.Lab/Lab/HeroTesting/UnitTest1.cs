using NUnit.Framework;
using Skeleton.Interfaces;
using Skeleton;
using Moq;
namespace HeroTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestRequiredFakeImplemetationOfBigInterface()
        {
            ITarget fakeTarget = new FakeTarget();
            IWeapon fakeWeapon = new FakeWeaponcs();

            Hero hero = new Hero("Peter", fakeWeapon);
            hero.Attack(fakeTarget);

            Assert.AreEqual(20, hero.Experience);
        }

        [Test]
        public void HeroGainsXPAfterDummyDeath()
        {
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(x => x.Health).Returns(0);
            fakeTarget.Setup(x => x.GiveExperience()).Returns(20);
            fakeTarget.Setup(x => x.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();

            Hero hero = new Hero("Peter", fakeWeapon.Object);

            hero.Attack(fakeTarget.Object);

            Assert.AreEqual(20, hero.Experience);

        }
    }
}