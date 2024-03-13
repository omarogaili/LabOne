using System.Security.Cryptography.X509Certificates;

namespace Spel;

public class Items
{
    private string item;
    private int x;
    private int y;
    private int health;
    //  Random rand =new Random();

    public Items(string item, int x, int y, int health){
        this.Item= item;
        this.LocationX= x;
        this.LocationY= y;
        this.Health= health;
        /* add more prop if we want to, more items*/
    }
    public string Item{
        get{return item;}
        set{item=value;}
    }
    public  int LocationX{
        get{return x;}
        set{x=value;}
    }
    public  int LocationY{
        get{return y;}
        set{y=value; }
    }
       public int Health{
        get{return health;}
        set{health=value; }
    }
}
