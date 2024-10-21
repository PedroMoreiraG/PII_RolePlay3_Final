namespace Ucu.Poo.RoleplayGame;

public abstract class Enemies : Character
{
    public int VictoryPoints { get; set; }

    public Enemies(string Name, int victoryPoints) : base(Name)
    {
        this.VictoryPoints = victoryPoints;
    }
}
