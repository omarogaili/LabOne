using Microsoft.Identity.Client;

namespace Spel;

public class Player : Characters
{
    private List<Items> items = new List<Items>();
    private Mechanism mechanism;
    private Random rand = new Random();
    public int XPositions { get; set; }
    public int YPosition { get; set; }
    //constructor for the class player from 
    public Player(string shape, double vitality, int postionX, int postionY) : base(shape, 1.1, vitality, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0)
    {
        shape = "🤺"; //this the shape i want. 
        this.Name = shape;
        vitality = 10;
        this.Vitality = vitality;
        this.XPositions = postionX;
        this.YPosition = postionY;
        Console.Write(shape);
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
        if (XPositions < Console.WindowWidth - 20) //this value is important so the player can move outside of the window
        {
            XPositions++;
            UpdateLocation();
        }
    }
    public void MoveUp()
    {
        if (YPosition > 2)
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
        int yaxis = this.YPosition + 10;
        List<string> speech = new List<string>(){
            "I'll Wack you up",
            "Are you sure about that",
            "Welcome to me World!",
            "Jag heter Albin HINCZ"
            };
        Random randChat = new Random();
        int index = randChat.Next(speech.Count);
        string chatting = speech[index];
        Console.SetCursorPosition(xaxis, yaxis - 12);
        Console.WriteLine(chatting);
    }
    public void PlayerPropertyes()
    {
        int xaxis = 0;
        int yaxis = 0;
        Console.SetCursorPosition(xaxis, yaxis);
        Console.WriteLine("Health" + ":" + this.Vitality);
        RangeUp();

    }
    public void AddItems(List<Items> newItems)
    {
        items.AddRange(newItems);
    }
    public void RangeUp()
    {
        foreach (Items item in items)
        {
            if (XPositions == item.LocationX && YPosition == item.LocationY)
            {
                this.Vitality += item.Health;
                /*add more prop lik coolness and strength */
                /*the same logic we should use if the player ben hit or moved ner by the anime */
            
                break;
            }

        }
    }
    public void ShowingTheItems()
    {
        foreach (Items item in items)
        {
            Console.SetCursorPosition(item.LocationX, item.LocationY);
            Console.WriteLine(item.Item);
        }
    }
    /* in this method we have one condition if the x and y position of the player and the food att the same 
    so we give the x and y position of the food a new random position and than we send it to the items location
    by using the SetCursorPosition() så we "write" the new place and than save it in a list and after that we send it 
    for Additem method to save it in the list and Write it. 
    */
    public void RemovingItems()
    {
        foreach (Items item in items){
            if(XPositions == item.LocationX && YPosition == item.LocationY){
                items.Remove(item);
                item.LocationX = rand.Next(Console.WindowWidth);
                item.LocationY = rand.Next(Console.WindowHeight);                  
                Items newItem = new Items(item.Item, item.LocationX, item.LocationY, item.Health);
                Console.SetCursorPosition(item.LocationX, item.LocationY);
                List<Items> newItems = new List<Items> { newItem };
                AddItems(newItems);
                break;
            }
        }
    } 
     //to make the player coolness change,so what we need to do is 
        //create a new list this list should the player (user) choose from 
        // when it's time to choose something (in the fight or in conversation) with the 
        //this method will be placed down here ||
}
