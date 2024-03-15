using System.Security.Cryptography.X509Certificates;

namespace Spel;

public class EasyMob 
{
    private string easymob;// shape of the enemy 
    private int x;
    private int y;
    private int health;
    private int xpPoints;
    private int damage;
    int vitality;
    public EasyMob(string easymob, int x, int y, int health, int xpPoints, int damage, int vitality){
        this.easymob = easymob;
        this.EasyMobsX= x;
        this.EasyMobsY= y;
        this.Health= health;
        this.XpPoints= xpPoints;
        this.Damage = damage;
        this.vitality= vitality;
        /* add more prop if we want to, more items*/
    }
    public string Easymob{
        get{return easymob;}
        set{easymob=value;}
    }
    public int EasyMobsX
    {
        get{return x;}
        set{x=value;}
    }
    public int EasyMobsY{
        get{return y;}
        set{y=value; }
    }
       public int Health{
        get{return health;}
        set{health=value; }
       }
       public int XpPoints
       {
        get{return xpPoints;}
        set{xpPoints=value; }
       }
       public int Damage
       {
        get{return damage;}
        set{damage=value; }
       }
       public int Vitality{
        get{return vitality;}
        set{vitality=value; }
       }
//  public int XPositions { get; set; }
//     public int YPosition { get; set; }

    // public EasyMob(string name, double vitality, int x, int y) : base(name, 1.1, vitality, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0)
    // {
    //     name = "👽"; //this the shape i want. 
    //     this.Name = name;
    //     vitality = 10;
    //     this.Vitality = vitality;
    //     Console.Write(name);
    //     this.X = x;
    //     this.Y = y;
    // }
    //     public int X {get{ return x; } set { x = value;}}
    //     public int Y {get{ return y; } set { y = value;}}

        
    // public void ShowingEasyMob()
    // {
    //     this.Name = "👽";
    //     int X = 0;
    //     int Y = 0;
    //     Console.SetCursorPosition(X + 10, Y + 15);
    //     Console.WriteLine(this.Name);
    // }


    // private void UpdateLocation()
    // {
    //     Console.Clear();
    //     Console.SetCursorPosition(XPositions, YPosition);
    //     Console.Write(Name);
        
    // }
    
}
