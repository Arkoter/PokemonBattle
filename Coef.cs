public class Coef
{
    public static double GetTypeEffectiveness(PokemonType attackType, PokemonType defenderType)
    {
        if (attackType == PokemonType.Fire && defenderType == PokemonType.Grass)
            return 2.0;
        if (attackType == PokemonType.Water && defenderType == PokemonType.Fire)
            return 2.0;
        if (attackType == PokemonType.Grass && defenderType == PokemonType.Water)
            return 2.0;
        if (attackType == PokemonType.Electric && defenderType == PokemonType.Water)
            return 2.0;
        if (attackType == PokemonType.Fire && defenderType == PokemonType.Water)
            return 0.5;
        if (attackType == PokemonType.Water && defenderType == PokemonType.Grass)
            return 0.5;
        if (attackType == PokemonType.Grass && defenderType == PokemonType.Fire)
            return 0.5;
        if (attackType == PokemonType.Electric && defenderType == PokemonType.Grass)
            return 0.5;

        return 1.0;
    }
}