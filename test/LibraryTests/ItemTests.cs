using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]
public class ItemTests
{
    [Test]
    public void Prueba()
    {
        Archer archer = new Archer("Pedro");
        Assert.That(15 == archer.AttackValue);
    }
}