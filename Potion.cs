namespace PokemonBattle;

public class Potion : IItem
{
    public string Name { get; }
    public int Cost { get; }

    public double HealingAmount { get; }

    public Potion(string name = "Potion", int cost = 200, double healingAmount = 20)
    {
        Name = name;
        Cost = cost;
        HealingAmount = healingAmount;
    }

    public void Use(Pokemon target)
    {
        if (target == null)
        {
            return;
        }

        if (target.IsFainted())
        {
            Console.WriteLine($"{target.Name} est K.O., la {Name} n\'a aucun effet.");
            return;
        }

        Console.WriteLine($"Tu utilises {Name} sur {target.Name} !");
        target.ReceiveHeal(HealingAmount);
        Console.WriteLine($"{target.Name} récupère {HealingAmount} PV !");
    }
}