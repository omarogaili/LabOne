namespace Pokemon;

public class Monster
{
    private string name;
    private int healthPoint;

    public Monster(string name, int healthPoint)
    {
        this.healthPoint=  healthPoint;
        this.name = name;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int HealthPoint
    {
        get { return this.healthPoint; }
        set { this.healthPoint = value; }
    }


}
