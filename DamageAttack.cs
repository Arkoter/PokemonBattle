namespace PokemonBattle;

public class DamageAttack : Attack
{
    public int Damage { get ;}

    public DamageAttack(string name, int damage, PokemonType type)
        : base(name, type)
    {
        Damage = damage;
    }

    public override void Use(Pokemon user, Pokemon target)
    {
        if (user.IsFainted())
        {
            Console.WriteLine($"{user.Name} has fainted and cannot use {Name}.");
            return;
        }
        
        Console.WriteLine($"{user.Name} use {Name}!");
        var effectiveness = TypeHelper.GetEffectiveness(Type, target.Type);
        var totalDamage = (int)(Damage * effectiveness);
        target.ReceiveDamage(Damage);
    }

    public override void GetDescription()
    {
        Console.WriteLine($"- {Name} (Damage: {Damage}, Type: {Type})");
    }
}