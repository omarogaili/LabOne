using System.Security.Cryptography.X509Certificates;

namespace Spel;

public abstract class Items
{
    private string? item;
    private double weight ;
    private double values;
    private int x;
    private int y;
    //  Random rand =new Random();

    public Items(string item,double weight,double values , int x, int y){
        this.Item= item;
        this.Weight= weight;
        this.Values= values;
        this.LocationX= x;
        this.LocationY= y;
        /* add more prop if we want to, more items*/
    }
    public string Item{
        get{return item;}
        set{item=value;}
    }
    public double Weight{
        get{return weight;}
        set{weight=value;}
    }
    public double Values{
        get{return values;}
        set{values=value;}
    }
    public  int LocationX{
        get{return x;}
        set{x=value;}
    }
    public  int LocationY{
        get{return y;}
        set{y=value; }
    }
}
