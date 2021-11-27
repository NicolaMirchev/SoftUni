﻿namespace INStock.Tests
{
    using Moq;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ProductStockTests
    {
        private Stock stocks;

        [SetUp]
        public void GenerateStockAndOneProductToAdd()
        {
            stocks = new Stock();
        }

        [Test]
        public void ChekTheAddMethodInTheStock()
        {
            Product singleCole = new Coke("2123", 5, 1);
            stocks.Add(singleCole);

            Assert.AreEqual(1, stocks.Count);
            Assert.IsTrue(stocks.Contains(singleCole));
        }
        [Test]

        public void AddThrawsAnExeptionWhenProductWithSameLabelIsGiven()
        {
            Product coke = new Coke("1212", 2, 2);
            Product snacks = new Snacks("1212", 2, 2);

            stocks.Add(coke);

            Assert.Throws<Exception>(() => stocks.Add(snacks));
        }
        [Test]
        public void CheckContainsMethodReturnTrueAboutAllOfTheParticipantsInTheStock()
        {
            Product coke1 = new Coke("1213", 1, 2);
            Product coke2 = new Coke("1214", 1, 2);
            Product snacks1 = new Coke("1215", 1, 2);
            Product faikProduct = new Snacks("1111", 0, 0);

            stocks.Add(coke2);
            stocks.Add(coke1);
            stocks.Add(snacks1);

            Assert.IsTrue(stocks.Contains(coke2));
            Assert.IsTrue(stocks.Contains(coke1));
            Assert.IsTrue(stocks.Contains(snacks1));
            Assert.IsFalse(stocks.Contains(faikProduct));
        }
        [Test]
        public void FindMethodReturnCorrectTheIndexOfTheMembersInTheOrderOfAppearence()
        {
            Product coke = new Coke("2222", 2, 2);
            Product snack = new Snacks("2223", 2, 2);

            stocks.Add(coke);
            stocks.Add(snack);
            int indexOfTheAppearenceOfTheSnacks = 1;

            Assert.AreEqual(snack, stocks.Find(indexOfTheAppearenceOfTheSnacks));
     
        }
        [Test]
        public void FindMethodThrowsAnExeptionWhenTheIndexIsOutOfRange()
        {
            Product coke = new Coke("11", 1, 1);

            stocks.Add(coke);

            Assert.Throws<IndexOutOfRangeException>(() => stocks.Find(2));
        }

    }
}
