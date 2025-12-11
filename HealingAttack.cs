namespace PokemonBattle;

public class HealingAttack : Attack
{
    public int HealingAmount { get; }

    public HealingAttack(string name, int healingAmount, PokemonType type)
        : base(name, type)
    {
        HealingAmount = healingAmount;
    }

    public override void Use(Pokemon user, Pokemon target)
    {
        if (user.IsFainted())
        {
            Console.WriteLine($"{user.Name} has fainted and cannot use {Name}.");
            return;
        }

        user.ReceiveHeal(HealingAmount);
        Console.WriteLine($"{user.Name} used {Name} and healed for {HealingAmount} HP! \n");
    }

    public override void GetDescription()
    {
        Console.WriteLine($"- {Name} (Healing: {HealingAmount}, Type: {Type})");
    }
}