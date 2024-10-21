using Ucu.Poo.RoleplayGame;

namespace Library.Encounters;

public class Encounter
{
    public List<Heroes> listHeroes = new List<Heroes>();
    public List<Enemies> listEnemies = new List<Enemies>();

    public void AddCharacter(Character character)
    {
        if (character is Heroes)
        {
            listHeroes.Add((Heroes)character);
        }
        else if (character is Enemies)
        {
            listEnemies.Add((Enemies)character);
        }
    }
    
    
    public void DoEncounter()
    {
        while (listEnemies.Count > 0 && listHeroes.Count > 0)
        {
            for (int i = 0; i < listEnemies.Count && i < listHeroes.Count; i++) //Se recorren las listas para que primero ataquen los enemies
            {
                Enemies enemy = listEnemies[i];
                Heroes hero = listHeroes[i % listHeroes.Count]; 
            
                hero.ReceiveAttack(enemy);
                Console.WriteLine($"{enemy.Name} ataco a {hero.Name}");
            
                if (hero.IsDead()) //Si el hero esta muerto lo borra del equipo
                {
                    Console.WriteLine($"{hero.Name} ha sido derrotado por {enemy.Name}");
                    listHeroes.Remove(hero);
                }
            }

        
            for (int i = 0; i < listHeroes.Count && i < listEnemies.Count; i++)// Ahora los heroes que sobreviven ataquen
            {
                Heroes hero = listHeroes[i];
                Enemies enemy = listEnemies[i % listEnemies.Count];
            
                enemy.ReceiveAttack(hero);
                Console.WriteLine($"{hero.Name} ataco a {enemy.Name}");
            
                if (enemy.IsDead()) //Si el enemy esta muerto lo borra del equipo
                {
                    Console.WriteLine($"{enemy.Name} ha sido derrotado por {hero.Name}");
                    hero.AddVictoryPoints(enemy.VictoryPoints);
                    listEnemies.Remove(enemy);
                }
            }
            foreach (Heroes heroe in listHeroes)
            {
                //Si los heroe tienen 5 o más puntos de victoria lo cura
                if (heroe.TotalVictoryPoints > 4)
                {
                    heroe.Cure();
                    Console.WriteLine($"{heroe.Name} recupero toda su salud");
                    heroe.TotalVictoryPoints = 0; //Aca lo resetea
                }
            }
        }

        if (listEnemies.Count == 0)
        {
            Console.WriteLine("El equipo de los heroes gano");
        }

        if (listHeroes.Count == 0)
        {
            Console.WriteLine("El equipo de los enemies perdio");
        }
    }
}
