namespace Ucu.Poo.RoleplayGame;

public abstract class Character
{
    public string Name { get; set; }
    public int health = 100;
    public List<IItem> items = new List<IItem>();

    public Character(string Name)
    {
        this.Name = Name;
    }
    
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value < 0 ? 0 : value;
        }
    }
    
    public virtual int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IAttackItem)
                {
                    value += (item as IAttackItem).AttackValue;
                }
            }
            return value;
        }
    }

    public virtual int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IDefenseItem)
                {
                    value += (item as IDefenseItem).DefenseValue;
                }
            }
            return value;
        }
    }
    
    public void AddItem(IItem item)
    { 
        this.items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }

    public void Cure()
    {
        this.Health = 100;
    }

    public void ReceiveAttack(Character character)
    {
        if (this.DefenseValue < character.AttackValue)
        {
            this.Health -= character.AttackValue - this.DefenseValue;
        }
    }
    
    public bool IsDead()
    {
        return Health < 1;
    }
}