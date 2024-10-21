namespace Ucu.Poo.RoleplayGame;

public abstract class Heroes : Character
{
    public int totalVictoryPoints = 0;
    public int TotalVictoryPoints
    {
        get
        {
            return this.totalVictoryPoints;
        }
        set
        {
            this.totalVictoryPoints = value < 0 ? 0 : value;
        }
    }
    
    public Heroes(string Name) : base(Name)
    {
    }

    public void AddVictoryPoints(int points)
    {
        TotalVictoryPoints += points;
    }
}
