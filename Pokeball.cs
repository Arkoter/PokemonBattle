namespace PokemonBattle;

public class Pokeball : IItem
{
    public string Name { get; }
    public int Cost { get; }

    public Pokeball(string name = "Pokeball", int cost = 200)
    {
        Name = name;
        Cost = cost;
    }

    public void Use(Pokemon target)
    {
        target.Catch();
    }
}