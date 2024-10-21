namespace Ucu.Poo.RoleplayGame;

//Consideramos que está bien como Interfaz dado que los valores de ataque varian segun el item
public interface IAttackItem: IItem
{
    int AttackValue { get; }
}
