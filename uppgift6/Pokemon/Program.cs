using Pokemon;

internal class Program
{
    private static void Main(string[] args)
    {
        Pokemons pikachu = new("Electric",56, "pikachu", 70);
        Pokemons pikachu2 = new("Electric",56, "pikachu", 70);
        AshKetchum ash = new(pikachu);
        ash.Catch(pikachu);
        ash.PresentTeam();
        System.Console.WriteLine("=============================");
        Pokemons squirtle = new("Water",87, "Squirtle",50);
        ash.Catch(squirtle);
        ash.PresentTeam();
        System.Console.WriteLine("=============================");
        // Mewtwo mewtwo = new(102);
        // mewtwo.fight(ash);
        // mewtwo.catchPokemon(pikachu);
        // System.Console.WriteLine("=============================");
        // pikachu.attack(mewtwo);
    }
}