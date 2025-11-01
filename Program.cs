public class Program
{
    public static void Main()
    {
        var pikachu = new Pokemon("Pikachu", PokemonType.Water, PokemonType.Electric, 100);
        var dracaufeu = new Pokemon("Dracaufeu", PokemonType.Grass, PokemonType.Grass, 100);
		Console.ForegroundColor = ConsoleColor.Blue;
		pikachu.Entry();
        dracaufeu.Entry();
        while (dracaufeu.LifePoints != 0 & pikachu.LifePoints != 0)
        {
            if (pikachu.LifePoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                pikachu.Attack(dracaufeu, 40);
            }
            if (dracaufeu.LifePoints != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dracaufeu.Attack(pikachu, 30);
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
