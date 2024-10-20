using Ucu.Poo.RoleplayGame;

namespace Library.Encounters;

public abstract class Encounter
{
    public Character Character1 { get; }
    public Character Character2 { get; }

    public Encounter(Character one, Character two)
    {
        this.Character1 = one;
        this.Character2 = two;
    }
    
    public void DoEncounter()
    {
        
    }
}
