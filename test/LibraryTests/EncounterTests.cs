using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]

public class EncounterTests
{
    [Test]
    public void Prueba(){
        //Test de las listas
        Encounter encounter = new Encounter();
        Dwarf gimli = new Dwarf("Gimli");
        encounter.AddCharacter(gimli);
        Assert.That(gimli==listHeroes[0]);

        Skeleton reductor = new Skeleton("Reductor");
        encounter.AddCharacter(reductor);
        Assert.That(reductor == listEnemies[0]);

        //Test DoEncounter
        encounter.DoEncounter();
        if(reductor.IsDead){
            Assert.That(reductor.Health == 0);
            Assert.that(encounter.listEnemies==0);
        }
        if(gimli.TotalVictoryPoints >= 5)
            Assert.that(gimli.Health == 100);
            Assert.that(gimli.TotalVictoryPoints = 0);
    }
}