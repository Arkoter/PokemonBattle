namespace PokemonBattle;

public class Program
{
    public static void Main()
    {
        var pikachu = new Pokemon("Pikachu", PokemonType.Electric, 100, 100);
        var dracaufeu = new Pokemon("Dracaufeu", PokemonType.Fire, 100, 100);
        var potionSoins = new Potion();
        var pokeball = new Pokeball();
        Random rnd = new Random();
		Attack thunderShock = new DamageAttack("ThunderShock", 30, PokemonType.Electric);
		Attack healPulse = new HealingAttack("HealPulse", 10, PokemonType.Normal);
		Attack drainLife = new VampireAttack("DrainLife", 20, 0.5, PokemonType.Dark);
        int money = 600;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Voulez vous entrez dans l'arène?");
        var input = Console.ReadLine();
        if ("Oui".Equals(input, StringComparison.OrdinalIgnoreCase))
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            pikachu.Entry();
            dracaufeu.Entry();
            while (dracaufeu.LifePoints != 0 & pikachu.LifePoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Qu'est-ce que vous voulez faire ?");
                Console.WriteLine("1:Attaquer");
                Console.WriteLine("2:Objets");
                input = Console.ReadLine();
                if ("1".Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Quelles attaques voulez vous utilisé ?");
                    Console.WriteLine("1:ThunderShock");
                    Console.WriteLine("2:HealPulse");
                    Console.WriteLine("3:DrainLife");
                    input = Console.ReadLine();
                    if ("1".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        thunderShock.Use(pikachu, dracaufeu);
                        Console.ReadLine();
                    }
                    else if ("2".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        healPulse.Use(pikachu, pikachu);
                        Console.ReadLine();
                    }
                    else if ("3".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        drainLife.Use(pikachu, dracaufeu);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Choix invalide");
                        Thread.Sleep(1500);
                        continue;
                    }
                }
                else if ("2".Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Quelle objet voulez vous utilisez?");
                    Console.WriteLine("1:Potion");
                    Console.WriteLine("2:Pokeball");
                    input = Console.ReadLine();
                    if ("1".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        if (money - potionSoins.Cost >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            potionSoins.Use(pikachu);
                            money -= 200;
                            Console.WriteLine($"Il vous reste {money}$");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Vous n'avez pas assez d'argent.");
                            Thread.Sleep(1500);
                            continue;
                        }
                    }
                    else if ("2".Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        if (money - pokeball.Cost >= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            pokeball.Use(dracaufeu);
                            money -= 500;
                            Console.WriteLine($"Il vous reste {money}$");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Vous n'avez pas assez d'argent.");
                            Thread.Sleep(1500);
                            continue;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Choix invalide");
                        Thread.Sleep(1500);
                        continue;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Choix invalide");
                    Thread.Sleep(1500);
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                int enemyrandom = rnd.Next(1, 4);
                if (enemyrandom == 1)
                {
                    Console.Clear();
                    thunderShock.Use(dracaufeu, pikachu);
                    Console.ReadLine();
                }
                else if (enemyrandom == 2)
                {
                    Console.Clear();
                    healPulse.Use(dracaufeu, pikachu);
                    Console.ReadLine();
                }
                else if (enemyrandom == 3)
                {
                    Console.Clear();
                    drainLife.Use(dracaufeu, pikachu);
                    Console.ReadLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            if (pikachu.LifePoints == 0)
            {
                Console.WriteLine("Dracaufeu wins the battle!");
            }
            else
            {
                Console.WriteLine("Pikachu wins the battle!");
            }

            Console.WriteLine("Presser entrer pour quitter.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.WriteLine("Vous avez abandonné le combat!");
        }
    }
}
