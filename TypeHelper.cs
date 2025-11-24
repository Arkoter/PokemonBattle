namespace PokemonBattle;

public static class TypeHelper
{
    // Create effectiveness chart as a Dictionnary
    // We only implement a few types for simplicity
    // Fire > Grass, Water > Fire, Grass > Water
    private static readonly Dictionary<PokemonType, Dictionary<PokemonType, double>> EffectivenessChart = new()
    {
        { PokemonType.Fire, new Dictionary<PokemonType, double> 
            {
                { PokemonType.Grass, 2.0 },
                { PokemonType.Fire, 0.5 },
                { PokemonType.Water, 0.5 }
            } 
        },
    };


    // Get effectiveness multiplier : sera utilisé dans la leçon sur l'héritage !
    public static double GetEffectiveness(PokemonType attackType, PokemonType targetType)
    {
        if (EffectivenessChart.ContainsKey(attackType) && EffectivenessChart[attackType].ContainsKey(targetType))
        {
            return EffectivenessChart[attackType][targetType];
        }
        return 1.0; // Neutral effectiveness
    }
}