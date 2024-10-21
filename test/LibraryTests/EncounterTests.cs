using Library.Encounters;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]

public class EncounterTests
{
    [Test]
    public void Prueba()
    {
        //Test de las listas
        Encounter encounter = new Encounter();
        Dwarf gimli = new Dwarf("Gimli");
        encounter.AddCharacter(gimli);
        Assert.That(gimli == encounter.listHeroes[0]);

        Skeleton reductor = new Skeleton("Reductor");
        encounter.AddCharacter(reductor);
        Assert.That(reductor == encounter.listEnemies[0]);

        //Test DoEncounter
        encounter.DoEncounter();
        if (reductor.IsDead())
        {
            Assert.That(reductor.Health == 0);
            Assert.That(gimli.Health == 100);
            Assert.That(gimli.TotalVictoryPoints == 0);
        }
    }
}