namespace PokemonBattle;

public class Pokemon
{

    public string Name { get; }
    public PokemonType Type { get; }
    public double LifePoints { get; private set; }
    
    public Pokemon(string name, PokemonType type, double lifePoints)
    {
        Name = name;
        Type = type;
        LifePoints = lifePoints;
    }
    
    public void Entry()
    {
        Console.WriteLine($"{Name} type {Type} enter the arena! \n");
    }
    
    public void ReceiveDamage(double Damage)
    {
        LifePoints = Math.Max(0, LifePoints - Damage);
        Console.WriteLine($"{Name} has {LifePoints} HP left!");
        if (IsFainted())
        {
            Console.WriteLine($"{Name} is KO! \n");
        }
        else
        {
            Console.WriteLine($"{Name} is alive! \n");
        }
    }

	public void ReceiveHeal(double Heal)
	{
		LifePoints = Math.Max(100, LifePoints + Heal);
	}

	public  bool IsFainted()
	{
		return LifePoints <= 0;
	}
    public void Catch()
    {
        LifePoints = 0;
        Console.WriteLine($"{Name} has been caught!");
    }
}