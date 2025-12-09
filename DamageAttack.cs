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
        switch (effectiveness)
        {
            case 0.5:
                Console.WriteLine("Ce n'est pas très efficace");
                break;
            case 1:
                Console.WriteLine("");
                break;
            case 2:
                Console.WriteLine("C'est super efficace !");
                break;
            default:
                //noop
                break;
        }
        var totalDamage = (int)(Damage * effectiveness);
        target.ReceiveDamage(totalDamage);
    }

    public override void GetDescription()
    {
        Console.WriteLine($"- {Name} (Damage: {Damage}, Type: {Type})");
    }
}