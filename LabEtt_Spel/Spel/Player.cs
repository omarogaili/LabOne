namespace Spel;

public class Player : Characters
{
    public int XPositions { get; set; }
    public int YPosition { get; set; }
    //constructor for the class player from 
    public Player(string name, double vitality, int postionX, int postionY) : base(name, 1.1, vitality, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0)
    {
        name = "😒"; //this the shape i want. 
        this.Name = name;
        vitality = 10;
        this.Vitality = vitality;
        this.XPositions = postionX;
        this.YPosition = postionY;
        Console.Write(name);
    }

    public override void ShowingTheCreatures()
    {
        Console.WriteLine(this.Name + this.Vitality);
    }
    public void MoveLeft()
    {
        if (XPositions < Console.WindowWidth - 1)
        {
            XPositions--;
            UpdateLocation();
        }
    }
    public void MoveRight()
    {
        if (XPositions < Console.WindowWidth - 1)
        {
            XPositions++;
            UpdateLocation();
        }
    }
    public void MoveUp()
    {
        if (YPosition < Console.WindowHeight - 1)
        {
            YPosition--;
            UpdateLocation();
        }
        //go up when u are down
        else if (YPosition > Console.WindowHeight - 2)
        {
            YPosition--;
            UpdateLocation();
        }
    }
    public void MoveDown()
    {
        if (YPosition < Console.WindowHeight - 1)
        {
            YPosition++;
            UpdateLocation();
        } 
        // get down when u are up
        else if (YPosition > Console.WindowHeight + 2)
        {
            YPosition--;
            UpdateLocation();
        }
    }
    private void UpdateLocation()
    {
        Console.Clear();
        Console.SetCursorPosition(XPositions, YPosition);
        Console.Write(Name);
        string? chating = "";
        Console.Write(" " + Communication(chating));
    }
    private string Communication(string chating)
    {

        List<string> speech = new List<string>(){
            "I'll Wack you up",
            "Are you sure about that",
            "Welcome to me World!"
            };
        Random randChat = new Random();
        int index = randChat.Next(speech.Count);
        chating = speech[index];
        return chating;
    }
    //to make the player coolness change,so what we need to do is 
    //create a new list this list should the player (user) choose from 
    // when it's time to choose something (in the fight or in conversation) with the 
    //this method will be placed down here ||
}
