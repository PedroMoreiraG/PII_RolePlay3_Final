namespace Ucu.Poo.RoleplayGame;

public abstract class Enemies : Character
{
    public Enemies(string Name) : base(Name)
    {
        this.Name = Name;
    }
}