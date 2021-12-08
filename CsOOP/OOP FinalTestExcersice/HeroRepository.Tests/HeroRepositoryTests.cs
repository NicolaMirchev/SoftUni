using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    private Hero hero;
    private HeroRepository repo;

    [SetUp]
    public void InicialiceRepositoryAndAHero()
    {
        hero = new Hero("Ivan", 5);
        repo = new HeroRepository();
    }

    [Test]
    public void HeroConstructorTest()
    {

        Assert.AreEqual("Ivan", hero.Name);
        Assert.AreEqual(5, hero.Level);
    }

    [Test]
    public void HeroCreateMethodThrowAnExceptionIfParameterIsNull()
    {
        Hero nullHero = null;

        Assert.Throws<ArgumentNullException>(() => repo.Create(nullHero));
    }
    [Test]
    public void HeroCreateThrowsCorrectExceptionIfIsGivenExistingHero()
    {
        Hero newHero = new Hero("Ivan", 3);
        repo.Create(hero);

        Assert.Throws<InvalidOperationException>(() => repo.Create(newHero));
    }

    [Test]
    public void CreateMethodReturnCorrectMessage()
    {

        Assert.AreEqual($"Successfully added hero Ivan with level 5", repo.Create(hero));
    }
    [Test]
    public void RemoveMethodThrowCorrectlyExceptionsForNullOrWhitespace()
    {
        Assert.Throws<ArgumentNullException>(() => repo.Remove(" "));
    }
    [Test]
    public void RemoveMethodWorkCorrectly()
    {

        Assert.IsFalse(repo.Remove("Ivan"));
        repo.Create(hero);
        Assert.IsTrue(repo.Remove("Ivan"));
    }
    [Test]
    public void ReturnHighestLevelHeroWorksCorrectly()
    {
        Hero newHero = new Hero("newHero", 6);
        Hero Pot = new Hero("Pot", 8);
        Hero Tor = new Hero("Tor", 14);

        repo.Create(hero);
        repo.Create(Pot);
        repo.Create(Tor);
        repo.Create(newHero);

        Assert.AreEqual(Tor, repo.GetHeroWithHighestLevel());
    }
    [Test]
    public void GetHeroMethodWorksCorrectly()
    {
        Assert.AreEqual(null, repo.GetHero("Ivan"));

        repo.Create(hero);
        Assert.AreEqual(hero, repo.GetHero("Ivan"));

    }
    [Test]
    public void TestHeroRepositoryConstructorIsNotNull()
    {
        Assert.That(repo.Heroes != null);
    }
}