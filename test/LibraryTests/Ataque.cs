using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

[TestFixture]

public class Ataque {
    [Test]

    public void PruebaDeAtaque()
    {
        Troll troll = new troll ("Rodrigo");
        Wizard wizard = new Wizard ("Hechizero generico!");
        
        Encounter encounter = new Encounter();
        encounter.AddCharacter(troll)
        encounter.AddCharacter(wizard)

        //verifico su salud inicial 
         Assert.AreEqual(100, troll.health);
         Assert.AreEqual(100, wizard.health);

         encounter.DoEncounter(); 
         //verifico si se bajo vida en el encuentro dado
        Assert.IsTrue(troll.Health < 100 || troll.IsDead());
        Assert.IsTrue(wizard.Health < 100 || wizard.IsDead());
        //verifico que ocurrio en el encuentro 
        if (troll.IsDead())
            {
                Assert.IsTrue(encounter.listEnemies.Count == 0);
            }
            else if (wizard.IsDead())
            {
                Assert.IsTrue(encounter.listHeroes.Count == 0);
    }
    }
}