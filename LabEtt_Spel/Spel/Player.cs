namespace Spel;

public class Player : Characters
{
    public int XPositions { get; set; }
    public int YPosition { get; set; }
    private Mechanism mechanism;
    //constructor for the class player from 
    public Player(string name, double vitality, int postionX, int postionY) : base(name, 1.1, vitality, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0)
    {
        name = "🤺"; //this the shape i want. 
        this.Name = name;
        vitality = 10;
        this.Vitality = vitality;
        this.XPositions = postionX;
        this.YPosition = postionY;
        Console.Write(name);
        // mechanism = new Mechanism ( XPositions +2, YPosition);
    }
    public override void ShowingTheCreatures()
    {
        Console.WriteLine(this.Name + this.Vitality);
    }
    public void MoveLeft()
    {
        if (XPositions > 0)
        {
            XPositions--;
            UpdateLocation();
        }
    }
    public void MoveRight()
    {
        if (XPositions < Console.WindowWidth - 30) //this value is important so the player can move outside of the window
        {
            XPositions++;
            UpdateLocation();
        }
    }
    public void MoveUp()
    {
        if (YPosition > 0)
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
    }
    private void UpdateLocation()
    {
        Console.Clear();
        Console.SetCursorPosition(XPositions, YPosition);
        Console.Write(Name);
        Communication();
    }
    private void Communication()
    {
        int xaxis = XPositions;
        int yaxis = this.YPosition +10;
        List<string> speech = new List<string>(){
            "I'll Wack you up",
            "Are you sure about that",
            "Welcome to me World!",
            "Jag heter Albin HINCZ"
            };
        Random randChat = new Random();
        int index = randChat.Next(speech.Count);
        string chatting = speech[index];
        Console.SetCursorPosition(xaxis, yaxis-12);
        Console.WriteLine(chatting);
    }
    //to make the player coolness change,so what we need to do is 
    //create a new list this list should the player (user) choose from 
    // when it's time to choose something (in the fight or in conversation) with the 
    //this method will be placed down here ||
}
