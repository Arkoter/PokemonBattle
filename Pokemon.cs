namespace PokemonBattle;

public class Pokemon
{

    public string Name { get; }
    public PokemonType Type { get; }
	public PokemonType AttackType { get; }
    public double LifePoints { get; private set; }
    
    public Pokemon(string name, PokemonType type, PokemonType attacktype, double lifePoints)
    {
        Name = name;
        Type = type;
		AttackType = attacktype;
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
}