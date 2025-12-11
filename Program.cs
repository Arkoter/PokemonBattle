namespace PokemonBattle;

public class Program
{
    public static void Main()
    {
        var pikachu = new Pokemon("Pikachu", PokemonType.Fire, 100);
        var dracaufeu = new Pokemon("Dracaufeu", PokemonType.Grass, 100);
        var potionSoins = new Potion();
        var pokeball = new Pokeball();
        Random rnd = new Random();
		Attack thunderShock = new DamageAttack("ThunderShock", 30, PokemonType.Fire);
		Attack healPulse = new HealingAttack("HealPulse", 10, PokemonType.Grass);
		Attack drainLife = new VampireAttack("DrainLife", 20, 0.5, PokemonType.Grass);
        int money = 600;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Voulez vous entrez dans l'arène?");
        var input = Console.ReadLine();
        if ("yes".Equals(input, StringComparison.OrdinalIgnoreCase))
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            pikachu.Entry();
            dracaufeu.Entry();
            while (dracaufeu.LifePoints != 0 & pikachu.LifePoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Voulez vous attaquer ou utiliser un objet?");
                input = Console.ReadLine();
                if ("Objet".Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vous avez choisi l’action Objet.");
                    Console.WriteLine("Voulez vous utilisé une pokeball ou une potion?");
                    input = Console.ReadLine();
                    if ("Potion".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        if (money - potionSoins.Cost >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            potionSoins.Use(pikachu);
                            money -= 200;
                            Console.WriteLine($"Il vous reste {money}$");
                        }
                        else
                        {
                            Console.WriteLine("Vous n'avez pas assez d'argent.");
                            continue;
                        }
                    }
                    else if ("Pokeball".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        if (money - pokeball.Cost >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            pokeball.Use(dracaufeu);
                            money -= 500;
                            Console.WriteLine($"Il vous reste {money}$");
                        }
                        else
                        {
                            Console.WriteLine("Vous n'avez pas assez d'argent.");
                            continue;
                        }
                    }
                }
                else if ("Attaquer".Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vous avez choisi l'action Attack.");
                    Console.WriteLine("Quelles attaques voulez vous utilisé ? (thunderShock, healPulse, drainLife)");
                    input = Console.ReadLine();
                    if ("thunderShock".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        thunderShock.Use(pikachu, dracaufeu);
                    }
                    else if ("healPulse".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        healPulse.Use(pikachu, pikachu);
                    }
                    else if ("drainLife".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        drainLife.Use(pikachu, dracaufeu);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                int enemyrandom = rnd.Next(1, 4);
                if (enemyrandom == 1)
                {
                    thunderShock.Use(dracaufeu, pikachu);
                }
                else if (enemyrandom == 2)
                {
                    healPulse.Use(dracaufeu, pikachu);
                }
                else if (enemyrandom == 3)
                {
                    drainLife.Use(dracaufeu, pikachu);
                }
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
