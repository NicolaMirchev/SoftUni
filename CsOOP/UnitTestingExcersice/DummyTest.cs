using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingExcersice;

namespace UnitTestProject
{
    [TestFixture]
    class DummyTest
    {
        [Test]
        public void DeadDummyCantBeAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy1 = new Dummy(10, 10, axe);

            Dummy dummy2 = new Dummy(10, 10, axe);

            dummy1.Wepon.Attack(dummy2);
            int deathDummyHp = dummy2.HP;

            dummy1.Wepon.Attack(dummy2);
            Assert.That(deathDummyHp == dummy2.HP); 
        }
        [Test]
        public void SuccessfullyKilledDummy()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy1 = new Dummy(10, 10, axe);

            Dummy dummy2 = new Dummy(10, 10, axe);


            Assert.AreEqual(dummy1.Wepon.Attack(dummy2),
                "Succssfully killed Dummy. \n " + "Earned 10 Xp");

        }

    }
}
