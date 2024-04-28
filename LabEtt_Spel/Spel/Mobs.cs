// using Microsoft.IdentityModel.Tokens;

namespace Spel;
/// <summary>
/// abstract klass egentligen för att den ska ärva till fienderna olika typer av fienderna vi vill ha 
///  Den klassen är ansvarig för fienderna och den ha en abstract metod den ska vara ansvarig för uppdatera platsen 
/// </summary>
public abstract class Mobs : Characters
{
    protected Map map;
    protected Player player;
    private Random rand = new Random();

    public Mobs(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
        : base(name, strength, vitality, stamina)
    {
        this.map = map;
        this.player = player;
        this.X = x;
        this.Y = y;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public abstract void UpdateLocation(Map map);

    public void GetNewLocation(Map map)
    {
        X = rand.Next(1, map.Width - 1);
        Y = rand.Next(1, map.Height - 1);
    }
}

