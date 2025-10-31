public class Program
{
    public static void Main()
    {
        var pikachu = new Pokemon("Pikachu", "Electric", 100);
        var dracaufeu = new Pokemon("Dracaufeu", "Fire", 100);
        
        pikachu.Attack(dracaufeu, 100);
    }
}
