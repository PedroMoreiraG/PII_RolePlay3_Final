namespace Ucu.Poo.RoleplayGame;

public class Troll : Enemies
{
    public Troll(string Name) : base(Name, 8)
    {
        this.Name = Name;
        
        this.AddItem(new Sword());
        this.AddItem(new Axe());
        this.AddItem(new Shield());
    }
}