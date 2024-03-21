namespace Spel;

public class HealthItems: Items
{
  private int health;
    public HealthItems(string item, double weight, double values, int locationX, int locationY, int health) 
    : base(item, weight, values, locationX, locationY)
    {
        Health = health;
    }
    public int Health
    {
      get { return health; }
      set { health = value; }
    }

}
