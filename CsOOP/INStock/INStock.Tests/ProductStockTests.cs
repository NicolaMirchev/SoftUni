namespace INStock.Tests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class ProductStockTests
    {

        [Test]
        public void ChekTheAddMethodInTheStock()
        {
            Product productCoke = new Coke("1111", 10, 20);

            Stock stock = new Stock();

            stock.Add(productCoke);

            Assert.AreEqual(1, stock.Count);
            Assert.IsTrue(stock.Contains(productCoke));
        }

    }
}
