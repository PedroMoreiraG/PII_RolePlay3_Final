using Library.Encounters;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]

public class EncounterTests
{
    
    Encounter encounter = new Encounter();
    Dwarf gimli = new Dwarf("Gimli");
    Skeleton reductor = new Skeleton("Reductor");
    
    [Test]
    public void Prueba()
    {
        //Test de las listas
     
        encounter.AddCharacter(gimli);
        Assert.That(gimli == encounter.listHeroes[0]);
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
    
    
    [Test]
    public void PruebaError()
    {
        encounter.AddCharacter(gimli);
        Assert.That(gimli == encounter.listHeroes[1]);

        
        encounter.AddCharacter(reductor);
        Assert.That(reductor == encounter.listEnemies[2]);

        //Test DoEncounter
        encounter.DoEncounter();
        if (reductor.IsDead())
        {
            Assert.That(reductor.Health == 'a');
            Assert.That(gimli.Health == 1000);
            Assert.That(gimli.TotalVictoryPoints == -1);
        }
    }
}