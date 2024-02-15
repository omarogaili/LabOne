namespace Spel;
/*
in this class we'll save all the properties that should all the creatures have in this game
we'll have some rolls that we will use them latter for different creature types. 
*/
public class Characters
{
    string name ="";
    double strength;
    double vitality; //health
    double patience; 
    double coolness;
    double stamina; 
    double charisma;
    double talkativeness;
    double speed;
    double wisdom;
    double rationality;
    /*
    what we need to do here is to gave the creatures of typ 1 for exempel a value like 5
    and so for the player and the Boos. 
    */
    public Characters (string name ,double strength, double vitality, double patience, double coolness,double stamina,double charisma,double talkativeness,double speed,double wisdom,double rationality )
    {
        this.Name =  name;
        this.Charisma = GivingAValue(charisma);
        this.Coolness = GivingAValue(coolness);
        this.Patience = GivingAValue(patience);
        this.Rationality =GivingAValue(rationality);
        this.Speed = GivingAValue(speed);
        this.stamina = GivingAValue(speed);
        this.Strength = GivingAValue(strength);
        this.Talkativeness = GivingAValue(talkativeness);
        this.Wisdom = GivingAValue(wisdom);
        this.Vitality = GivingAValue(vitality);
    }
     public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public double Vitality{
        get{return vitality; }
        set {vitality = value; }
        }
    public double Patience
    {
        get {return patience; }
        set { patience = value; }
    }
    public double Coolness
    {
        get {return coolness; }
        set { coolness = value; }
    }
    public double Stamina
    {
        get {return stamina; }
        set {stamina = value; }
    }
    public double Charisma
    {
        get {return charisma;}
        set {charisma = value; }
    }
    public double Talkativeness
    {
        get {return talkativeness; }
        set {talkativeness = value; }
    }
    public double Speed
    {
        get {return speed; }
        set {speed = value; }
    }
    public double Wisdom
    {
        get {return wisdom;}
        set { wisdom = value;}
    }
    public double Rationality
    {
        get{ return rationality;}
        set{ rationality = value;}
    }

    // what i can do is to create a new method that gives every character a result
    //or a value we kan also do that after every time you win a fight the 
    // max result and the min result grow with one point 
    // the method should look like this:
    public double GivingAValue(double theValue) 
    {
        int minValue= 1; // the min value 
        int maxValue= 10; // there is the max value
        //what we can do with those tow values is to get them grow 
        // maybe with another condition but its about the fight not
        // so i don't know how to handle this case. 
        if(theValue < minValue) // condition for the min value
        {
            theValue = minValue;
            
        }
        else if(theValue > maxValue)
        {
            theValue = maxValue;
        }
        return theValue;
    }
       public virtual void ShowingTheCreatures()
    {
        Console.WriteLine(this.name + this.vitality);
    }
}


