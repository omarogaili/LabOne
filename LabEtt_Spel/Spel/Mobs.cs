using Microsoft.IdentityModel.Tokens;

namespace Spel;

public class Mobs : Characters
{
    Player player;
    Mechanism mechanism;
    private int x;
    private int y;
    List<EasyMob> easymob = new List<EasyMob>();
    Random rand = new Random();

    public Mobs(string name, int vitality, int x, int y,Player player, Mechanism mechanism) 
    : base(name, 1, vitality, 2, 3, 4, 5, 6, 7, 8, 9)
    {
        name = "👽"; //this the shape i want. 
        this.Name = name;
        vitality = 10;
        this.Vitality = vitality;
        Console.Write(name);
        this.X = x;
        this.Y = y;
        this.player= player;
        this.mechanism= mechanism;
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
        public void GetSomeDamage()
    {
        foreach (EasyMob mob in easymob)
        {
            if (player.XPositions == mob.EasyMobsX && player.YPosition == mob.EasyMobsY)
            {
                player.Vitality -= mob.Damage;
                /*add more prop lik coolness and strength */
                /*the same logic we should use if the player ben hit or moved ner by the anime */
            }
        }
    }

     public void RemovingMobs()
    {
        for (int i =easymob.Count -1; i>=0; i--){
            EasyMob easyMob = easymob[i];
            if(mechanism.PostionX>= easyMob.EasyMobsX  &&  mechanism.PostionY ==easyMob.EasyMobsY 
            || player.XPositions == easyMob.EasyMobsX && player.YPosition == easyMob.EasyMobsY){
                GetSomeDamage();
                easymob.RemoveAt(i);
                player.XpPoints += easyMob.XpPoints;
                easyMob.EasyMobsX = rand.Next(Console.WindowWidth -4);
                easyMob.EasyMobsY = rand.Next(Console.WindowHeight-3);                  
                EasyMob newEasyMob = new EasyMob(easyMob.Easymob, easyMob.EasyMobsX, easyMob.EasyMobsY, 
                easyMob.Health, easyMob.XpPoints, easyMob.Damage);
                Console.SetCursorPosition(easyMob.EasyMobsX, easyMob.EasyMobsY);
                List<EasyMob> newEasymob = new List<EasyMob> { easyMob };
                AddMobs(newEasymob);
            }
        }
    }
}

