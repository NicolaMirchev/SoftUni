using NUnit.Framework;
using System;
using System.Text;

namespace Gyms.Tests
{

    [TestFixture]
    public class GymsTests
    {
        private Athlete athlete;
        private Gym gym;

        [SetUp]
        public void SetUpAsingleAthleteAndAGym()
        {
            athlete = new Athlete("Ivan");
            gym = new Gym("Sila", 1000);
        }
        [Test]
        public void TestAthleteConstructor()
        {
            Assert.AreEqual("Ivan", athlete.FullName);
            Assert.IsFalse(athlete.IsInjured);
        }
        [Test]
        public void TestGymConstructor()
        {
            Assert.AreEqual("Sila", gym.Name);
            Assert.AreEqual(1000, gym.Capacity);
        }
        [Test]
        public void NullOrEmptyStringForGymNameThrowsAnException()
        {
            Assert.Throws<ArgumentNullException>(() => new Gym("", 200));
        }
        [Test]
        public void CannotBeNegativeIntegerForCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Gym("Nice", -5));
        }
        [Test]
        public void CountReturnsCorrectly()
        {
            Assert.AreEqual(0, gym.Count);
            gym.AddAthlete(athlete);
            Assert.AreEqual(1, gym.Count);
        }
        [Test]
        public void AddAthleteThrowExceprionWhenTheGymIsFull()
        {
            var gym = new Gym("Walltopia", 1);
            gym.AddAthlete(athlete);

            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(new Athlete("Pesho")));
        }
        [Test]
        public void RemoveAthleteThrowsExceptionIfTheAthleteDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Ivan"));

        }
        [Test]
        public void RemoveAthleteWorksCorrectly()
        {
            gym.AddAthlete(athlete);
            Assert.AreEqual(1, gym.Count);
            gym.RemoveAthlete("Ivan");
            Assert.AreEqual(0, gym.Count);
        }
        [Test]
        public void InjuriedAthleteMethodThrowExceptionForInvalidName()
        {
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Ivan"));
        }
        [Test]
        public void InjuriAthleteWorksCorrectly()
        {
            gym.AddAthlete(athlete);
            Assert.IsFalse(athlete.IsInjured);
            gym.InjureAthlete("Ivan");
            Assert.IsTrue(athlete.IsInjured);
        }
        [Test]
        public void ReportMethodReturnOnlyActiveSportists()
        {
            Athlete athlete2 = new Athlete("Obi");
            Athlete athlete3 = new Athlete("Ober");
            Athlete athlete4 = new Athlete("Torbs");

            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);
            gym.AddAthlete(athlete4);


            Assert.IsTrue(gym.Report().Contains("Torbs"));

            gym.InjureAthlete("Torbs");
            gym.InjureAthlete("Ober");

            Assert.IsFalse(gym.Report().Contains("Torbs"));
            Assert.IsTrue(gym.Report().Contains("Ivan"));

        }
        [Test]
        public void ReportMethodReturnsCorrectlyMessage()
        {
            Athlete athlete2 = new Athlete("Obi");
            Athlete athlete3 = new Athlete("Ober");

            gym.AddAthlete(athlete2);
            gym.AddAthlete(athlete3);

            var sb = new StringBuilder();
            sb.AppendLine($"Active athletes at {gym.Name}: Obi, Ober");

            Assert.AreEqual(sb.ToString().TrimEnd(), gym.Report());
        }
        [Test]
        public void ConstructorInicializeCorrectlyTheListOfAthletes()
        {
            var gym = new Gym("Atletik", 2);

            Assert.DoesNotThrow(() => gym.AddAthlete(athlete));
        }


    }
}
