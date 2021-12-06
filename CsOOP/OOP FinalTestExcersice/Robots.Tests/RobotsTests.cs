namespace Robots.Tests
{
    using NUnit.Framework;
    using System;


    [TestFixture]
    public class RobotsTests
    {
        private RobotManager robotManager;
        private Robot robot;

        [SetUp]
        public void InicializeManager()
        {
            robotManager = new RobotManager(4);
            robot = new Robot("Ivan", 100);

        }
        [Test]
        public void TestCapacityProperty()
        {
            Assert.AreEqual(4, robotManager.Capacity);
        }

        [Test]
        public void SetCapacityThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-2));
        }

        [Test]
        public void CountProperyReturnCorrectlyValue()
        {

            Assert.AreEqual(0, robotManager.Count);

            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
        }
        [Test]
        public void AddMethodThrowsExceptionWhenAddRobotWithSameName()
        {
            robotManager.Add(robot);
            Robot robot2 = new Robot("Ivan", 120);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot2));
        }
        [Test]
        public void AddMethodThrowsAnExceptionIfOverflowTheCapacity()
        {
            var manager = new RobotManager(0);
            Assert.Throws<InvalidOperationException>(() => manager.Add(robot));
        }
        [Test]
        public void AddMethodWorkCorrectly()
        {
            Assert.AreEqual(0, robotManager.Count);
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
        }
        [Test]
        public void RemoveMethodThrowsAnExceptionForInvalidName()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("Djonka"));
        }
        [Test]
        public void RemoveMethodWorksCorrectly()
        {
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
            robotManager.Remove("Ivan");
            Assert.AreEqual(0, robotManager.Count);
        }
        [Test]
        public void WorkMethodThrowsAnExceptionForInvalidName()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Ivan", "Coding", 11));
        }
        [Test]
        public void WorkMethodThrowsAnExceptionWhenTheBatteryIsBelowTheNeccesity()
        {
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Ivan", "Washing", 110));
        }
        [Test]
        public void WorkMethodWorksCorrectly()
        {
            Assert.AreEqual(100, robot.Battery);
            robotManager.Add(robot);
            robotManager.Work("Ivan", "Singing", 50);

            Assert.AreEqual(50, robot.Battery);

        }
        [Test]
        public void ChargeMethodThrowsAnExceptionWhenAnInvalidNameIsGiven()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Lapeto"));
        }
        [Test]
        public void ChargeMethodWorksCorrectly()
        {
            robotManager.Add(robot);
            robotManager.Work("Ivan", "Blacksmit", 44);

            Assert.AreEqual(56, robot.Battery);
            robotManager.Charge("Ivan");
            Assert.AreEqual(100, robot.Battery);
        }
    }
}
