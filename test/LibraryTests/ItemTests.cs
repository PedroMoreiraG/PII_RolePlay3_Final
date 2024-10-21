using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]
public class ItemTests
{
    [Test]
    public void PruebaItem()
    {
        Archer archer = new Archer("Pedro");
        Assert.That(15 == archer.AttackValue);
    }
}