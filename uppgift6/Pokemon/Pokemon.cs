namespace Pokemon;

public class Pokemons: Monster
{
    private  string type;
    private int evluation;

    public Pokemons(string type, int evluation, string name, int healthPoint) : base (name, healthPoint)
    {
        this.Type = type;
        this.Evluation = evluation;
        this.Name= name;
        this.HealthPoint=healthPoint;
    }
    public string Type
    {
        get { return this.type; }
        set { this.type = value; }
    }
    public int Evluation
    {
        get { return this.evluation; }
        set { this.evluation = value; }
    }

}
