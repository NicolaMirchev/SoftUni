using NUnit.Framework;
using UnitTestingExcersice;
using UnitTestProject;

namespace UnitTestProject
{
    [TestFixture]
    public class AxeTests
    {

        [Test]
        public void AxeDurabilityTest()
        {
            var axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy); 

            Assert.That(axe.DurabilityPoints == 9);
        }

        [Test]
        public void DummyHPGoinDownAfterBeingAttacked()
        {
            var axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);
            Assert.IsTrue(dummy.HP == 0);

        }
    }
}