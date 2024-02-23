namespace Pokemon;

public interface ITrainer
{
    const int maxTeamSize = 8;
    void CatchPokemon(Pokemons pokemon);
    void Fight(ITrainer foe);
    string Shittalk();
}
