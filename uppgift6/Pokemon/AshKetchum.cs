namespace Pokemon;

public class AshKetchum: ITrainer
{
    private Pokemons mainPokemon;
    private List<Pokemons> team = new List<Pokemons>(6);

    public AshKetchum(Pokemons mainPokemon)
    {
        this.mainPokemon = mainPokemon;
        this.Team = team;
    }
    public Pokemons MainPokemon
    {
        get { return mainPokemon; }
        set { mainPokemon = value; }
    }
    public List<Pokemons> Team
    {
        get { return team; }
        set { team = value; }
    }
    public void PresentTeam()
    {
        Console.WriteLine("this is my team");
        foreach (var Pokemon in team)
        {
            Console.WriteLine(Pokemon.Name+" "+Pokemon.Type);
        }
    }
    public void Catch(Pokemons newPokemon)
    {
        team.Add(newPokemon);
        /*lägga till i arryen*/
    }
    public void Fight(ITrainer trainer)
    {
    }
    public string ShitTalk()
    {
        return "sdfsdf";
    }

    public void CatchPokemon(Pokemons pokemon)
    {
        throw new NotImplementedException();
    }

    public string Shittalk()
    {
        throw new NotImplementedException();
    }
}