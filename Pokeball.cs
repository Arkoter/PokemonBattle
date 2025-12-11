namespace PokemonBattle;

public class Pokeball : IItem
{
    public string Name { get; }
    public int Cost { get; }
    private Random rnd = new Random();

    public Pokeball(string name = "Pokeball", int cost = 200)
    {
        Name = name;
        Cost = cost;
    }

    public void Use(Pokemon target)
    {
        int number = rnd.Next(1, 3);
        if (number == 1)
        {
            target.Catch();
        }
        else
        {
            Console.WriteLine("Vous avez raté!");
        }
    }
}