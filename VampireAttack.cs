namespace PokemonBattle;

public class VampireAttack : DamageAttack
{
    public double VampireCoefficient { get; }

    public VampireAttack(string name, int damage, double vampireCoefficient, PokemonType type)
        : base(name, damage, type)
    {
        VampireCoefficient = vampireCoefficient;
    }

    public override void Use(Pokemon user, Pokemon target)
    {
		if (user.IsFainted())
        {
            Console.WriteLine($"{user.Name} has fainted and cannot use {Name}.");
            return;
        }
        // Console.WriteLine($"{user.Name} uses {Name}!");
        var effectiveness = TypeHelper.GetEffectiveness(Type, target.Type);
        var totalDamage = (int)(Damage * effectiveness);
        // target.TakeDamage(Name, totalDamage, effectiveness);
        // Duplicata du parent, peut être remplacé par base.Use()
        base.Use(user, target);
        int Heal = (int)(totalDamage * VampireCoefficient);
        user.ReceiveHeal(Heal);
        Console.WriteLine($"{user.Name} healed for {Heal} HP due to vampire effect!");
    }

    public override void GetDescription()
    {
        base.GetDescription();
        Console.WriteLine("  (Heals part of the damage dealt)");
    }
}