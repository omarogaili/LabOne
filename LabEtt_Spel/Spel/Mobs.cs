namespace Spel;

public class Mobs : Characters
{
    Player player;
    private int x;
    private int y;
    List<EasyMob> easymob = new List<EasyMob>();
    Random rand = new Random();

    public Mobs(string name, double vitality, int x, int y,Player player) : base(name, 1.1, vitality, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0)
    {
        name = "👽"; //this the shape i want. 
        this.Name = name;
        vitality = 10;
        this.Vitality = vitality;
        Console.Write(name);
        this.X = x;
        this.Y = y;
        this.player= player;
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
     public void AddMobs(List<EasyMob> newEasymob)
    {
        easymob.AddRange(newEasymob);
    }

    public void ShowingTheMobs()
    {
        foreach (EasyMob easyMob in easymob)
        {
            Console.SetCursorPosition(easyMob.EasyMobsX, easyMob.EasyMobsY);
            Console.WriteLine(easyMob.Easymob);
        }
    }

     public void RemovingMobs()
    {
        for (int i =easymob.Count -1; i>=0; i--){
            EasyMob easyMob = easymob[i];
            
            if(player.XPositions== easyMob.EasyMobsX  &&  player.YPosition ==easyMob.EasyMobsY){
                easymob.RemoveAt(i);
                easyMob.EasyMobsX = rand.Next(Console.WindowWidth);
                easyMob.EasyMobsY = rand.Next(Console.WindowHeight);                  
                EasyMob newEasyMob = new EasyMob(easyMob.Easymob, easyMob.EasyMobsX, easyMob.EasyMobsY, easyMob.Health);
                Console.SetCursorPosition(easyMob.EasyMobsX, easyMob.EasyMobsY);
                List<EasyMob> newEasymob = new List<EasyMob> { easyMob };
                AddMobs(newEasymob);
                break;
            }
        }
    }

}

