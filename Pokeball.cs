namespace PokemonBattle;

public class Pokeball : IItem
{
    public string Name { get; }
    public int Cost { get; }
    public int Proba { get; }
    private Random rnd = new Random();

    public Pokeball(string name = "Pokeball", int cost = 500, int proba = 4)
    {
        Name = name;
        Cost = cost;
        Proba = proba;
    }

    public void Use(Pokemon target)
    {
        int number = rnd.Next(1, Proba);
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