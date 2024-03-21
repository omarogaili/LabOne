namespace Spel;
/*
den klassen är är väldigt lik HealthItem klassen , tanken med att den är att spelaren ska kunna 
spara vapen som den hittar i värden, och sedan ska kunna använda de, varje vapen ska ett eget dagmage
där kan olika fiender bli påverkade av det. 
*/
public class WeaponItem :Items
{
    int damage;
    int key;
    public WeaponItem(string item, double weight, double values, int x, int y, int damage): base(item, weight, values, x, y)
    {
        this.Damage = damage;
    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
     public int Key
    {
        get { return key; }
        set { key = value; }
    }
}
