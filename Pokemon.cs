public class Pokemon
{

    public string Name { get; }
    public PokemonType Type { get; }
    public int LifePoints { get; private set; }
    
    public Pokemon(string name, PokemonType type, int lifePoints)
    {
        Name = name;
        Type = type;
        LifePoints = lifePoints;
    }
    
    public void Entry()
    {
        Console.WriteLine($"{Name} type {Type} enter the combat!");
    }
    
    public void Attack(Pokemon target, int Damage)
    {
        Console.WriteLine($"{Name} attacks {target.Name} and deals {Damage} damage!");
        target.ReceiveDamage(Damage);
    }

    public void ReceiveDamage(int Damage)
    {
        LifePoints = Math.Max(0, LifePoints - Damage);
        Console.WriteLine($"{Name} has {LifePoints} HP left!");
        if (LifePoints == 0)
        {
            Console.WriteLine($"{Name} is KO!");
        }
        else
        {
            Console.WriteLine($"{Name} is alive! \n");
        }
    }
}