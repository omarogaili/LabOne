// using Microsoft.IdentityModel.Tokens;

namespace Spel;

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

    //public abstract void Draw();
    public abstract void UpdateLocation();

    public void GetNewLocation()
    {
        X = rand.Next(1, map.Width - 1);
        Y = rand.Next(1, map.Height - 1);
    }
}

