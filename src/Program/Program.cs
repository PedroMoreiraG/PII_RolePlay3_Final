using System;
using Library.Encounters;

namespace Ucu.Poo.RoleplayGame.Program;

class Program
{
    static void Main(string[] args)
    {
        SpellsBook book = new SpellsBook();
        book.AddSpell(new SpellOne());
        book.AddSpell(new SpellOne());

        Wizard gandalf = new Wizard("Gandalf");
        gandalf.AddItem(book);

        Dwarf gimli = new Dwarf("Gimli");
        DarkElf malekith = new DarkElf("Malekith");
        Knight arturo = new Knight("Arturo");
        Archer legolas = new Archer("Legolas");
        Troll troll = new Troll("Troll");
        Encounter encounter = new Encounter();
        encounter.AddCharacter(gandalf);
        encounter.AddCharacter(gimli);
        encounter.AddCharacter(malekith);
        encounter.AddCharacter(arturo);
        encounter.AddCharacter(legolas);
        encounter.AddCharacter(troll);
        encounter.DoEncounter();
    }
}
