using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]
public class CharacterTests
{
    [Test]
    public void Prueba()
    {
        Dwarf dwarf = new Dwarf("Jorge");
        Assert.That(100 == dwarf.Health);
    }
}
