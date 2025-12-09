using System.Reflection.Metadata;

namespace PokemonBattle;

public class Program
{
    public static void Main()
    {
        var pikachu = new Pokemon("Pikachu", PokemonType.Fire, 100);
        var dracaufeu = new Pokemon("Dracaufeu", PokemonType.Grass, 100);
        var PotionSoins = new Potion();
        var Pokeball = new Pokeball();
		Attack thunderShock = new DamageAttack("Dégat", 30, PokemonType.Fire);
		Attack healPulse = new HealingAttack("Soin", 10, PokemonType.Grass);
		Attack drainLife = new VampireAttack("Vampirisme", 20, 0.5, PokemonType.Grass);
		Console.ForegroundColor = ConsoleColor.Blue;
		pikachu.Entry();
        dracaufeu.Entry();
        while (dracaufeu.LifePoints != 0 & pikachu.LifePoints != 0)
        {
            if (pikachu.LifePoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                thunderShock.Use(pikachu, dracaufeu);
            }
            if (dracaufeu.LifePoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                thunderShock.Use(dracaufeu, pikachu);
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        if (pikachu.LifePoints == 0)
        {
            Console.WriteLine("Dracaufeu wins the battle!");
        }
        else
        {
            Console.WriteLine("Pikachu wins the battle!");
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}
