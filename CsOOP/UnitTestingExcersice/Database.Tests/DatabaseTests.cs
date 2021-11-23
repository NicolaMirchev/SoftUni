using NUnit.Framework;
using System;

namespace Tests
{

    [TestFixture]
    public class DatabaseTests
    {
        private Database.Database dataBase;


        [Test]        
        public void ChekAddMethodForBorderCases()
        {
            dataBase = new Database.Database(new int[16]);

            Assert.Throws<InvalidOperationException>
                (() => dataBase.Add(69));
        }

        [TestCase(17)]
        [TestCase(30)]
        
        //Regression
        public void CheckIfItIsPossibleToEnterBiggerArray(int value)
        {
            Assert.Throws<InvalidOperationException>(() 
                => new Database.Database(new int[value]));
        }
    }
}