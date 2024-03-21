namespace Spel;
/*
in this class we'll save all the properties that should all the creatures have in this game
we'll have some rolls that we will use them latter for different creature types. 
*/
public abstract class Characters : Map
{
    /* vi behöver inte ha alla dessa egenskaper men vi tänkte att vi ska kunna använda de senare 
    om vi vill jobba vidare med spelet */
    string name ="";
    int strength;
    int vitality; 
    int patience; 
    int coolness;
    int stamina; 
    int charisma;
    int talkativeness;
    int speed;
    int wisdom;
    int rationality;
    int x;
    int y;
    public Characters (string name ,int strength, int vitality
    ,int stamina)
    {
        this.Name =  name;
        this.Charisma = charisma;
        this.Coolness = coolness;
        this.Patience =patience;
        this.Rationality =rationality;
        this.Speed = speed;
        this.stamina = speed;
        this.Strength = strength;
        this.Talkativeness = talkativeness;
        this.Wisdom =wisdom;
        this.Vitality = vitality;
    }
     public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Vitality{
        get{return vitality; }
        set {vitality = value; }
        }
    public int Patience
    {
        get {return patience; }
        set { patience = value; }
    }
    public int Coolness
    {
        get {return coolness; }
        set { coolness = value; }
    }
    public int Stamina
    {
        get {return stamina; }
        set {stamina = value; }
    }
    public int Charisma
    {
        get {return charisma;}
        set {charisma = value; }
    }
    public int Talkativeness
    {
        get {return talkativeness; }
        set {talkativeness = value; }
    }
    public int Speed
    {
        get {return speed; }
        set {speed = value; }
    }
    public int Wisdom
    {
        get {return wisdom;}
        set { wisdom = value;}
    }
    public int Rationality
    {
        get{ return rationality;}
        set{ rationality = value;}
    }

    // what i can do is to create a new method that gives every character a result
    //or a value we kan also do that after every time you win a fight the 
    // max result and the min result grow with one point 
    // the method should look like this:
       public abstract void ShowingTheCreatures();
       public abstract void ShowingTheMediumMobs();
}


