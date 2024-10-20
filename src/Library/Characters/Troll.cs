namespace Ucu.Poo.RoleplayGame;

public class Troll : Enemies
{
    public Troll(string name) : base(name)
    {
        this.Name = name;
        
        this.AddItem(new Sword());
        this.AddItem(new Axe());
        this.AddItem(new Shield());
    }
}