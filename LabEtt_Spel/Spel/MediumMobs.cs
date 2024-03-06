namespace Spel;

public class MediumMobs
{

private string mediumMob;// shape of the enemy 
    private int x;
    private int y;
    private int health;
    private int xpPoints;
    private int damage;
    public MediumMobs(string mediumMob, int x, int y, int health, int xpPoints, int damage){
        this.mediumMob = mediumMob;
        this.MediumMobX= x;
        this.MediumMobY= y;
        this.Health= health;
        this.XpPoints= xpPoints;
        this.Damage = damage;
        /* add more prop if we want to, more items*/
    }
    public string MediumMob{
        get{return mediumMob;}
        set{mediumMob=value;}
    }
    public int MediumMobX
    {
        get{return x;}
        set{x=value;}
    }
    public int MediumMobY{
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
}
