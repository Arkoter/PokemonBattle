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
    
    public void Attack(Pokemon target, double Damage)
    {
		Damage = Damage * Coef.GetTypeEffectiveness(AttackType, target.Type);
		if (Coef.GetTypeEffectiveness(AttackType, target.Type) == 2.0)
			Console.WriteLine("It's super effective!");
		else if (Coef.GetTypeEffectiveness(AttackType, target.Type) == 0.5)
            Console.WriteLine("It's not very effective...");
        Console.WriteLine($"{Name} attacks {target.Name} and deals {Damage} damage!");
        target.ReceiveDamage(Damage);
    }

    public void ReceiveDamage(double Damage)
    {
        LifePoints = Math.Max(0, LifePoints - Damage);
        Console.WriteLine($"{Name} has {LifePoints} HP left!");
        if (LifePoints == 0)
        {
            Console.WriteLine($"{Name} is KO! \n");
        }
        else
        {
            Console.WriteLine($"{Name} is alive! \n");
        }
    }
}