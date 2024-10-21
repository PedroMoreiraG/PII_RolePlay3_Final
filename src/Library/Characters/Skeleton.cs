namespace Ucu.Poo.RoleplayGame;

public class Skeleton : Enemies
{
    public Skeleton(string Name) : base(Name, 5)
    {
        this.Name = Name;
        this.AddItem(new Helmet());
    }
}