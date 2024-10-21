namespace Ucu.Poo.RoleplayGame;

//Consideramos que está bien como Interfaz dado que los valores de defensa varian segun el item
public interface IDefenseItem: IItem
{
    int DefenseValue { get; }
}
