namespace PokemonBattle;

public abstract class Attack
{
    public string Name { get; }
    public PokemonType Type { get; }

    protected Attack(string name, PokemonType type)
    {
        Name = name;
        Type = type;
    }

    public abstract void Use(Pokemon user, Pokemon target);

    public abstract void GetDescription();
}