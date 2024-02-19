namespace Spel;

public class Mechanism
{
    private string? fire = "🔥";
    private int xPosition;
    private int yPosition;
    private Player player;
    //constructor 
    public Mechanism(string fire, Player player)
    {
        this.Fire = fire;
        this.PostionX = player.XPositions;
        this.PostionY = player.YPosition;
        this.player = player;
    }
    public string Fire
    {
        get { return fire; }
        set { fire = value; }
    }
    public int PostionX
    {
        get { return xPosition; }
        set { xPosition = value; }
    }
    public int PostionY
    {
        get { return yPosition; }
        set { yPosition = value; }
    }

    public void ShoweTheFire()
    {
        this.PostionX=player.XPositions+2; //adding 2 steps at the positive x direction 
        this.PostionY= player.YPosition;
        ConsoleKeyInfo keyInfo;
        var key= Console.ReadKey(true).Key;
        while (key == ConsoleKey.Spacebar )
        {
            
            Console.SetCursorPosition(xPosition +1 ,yPosition);
            PostionX++;
            Console.WriteLine(this.Fire);
            System.Threading.Thread.Sleep(100);
                if (!IsNextPositionEmpty(xPosition + 1))
                {
                    break;
                }
        }
        UpdateLocation();
    }
        private void UpdateLocation()
    {
        /* what this method do is to update the location, so that we don't get to zero after the loop is over
        we update the location so we start over. 
        */
        Console.Clear();
        this.PostionX=player.XPositions;
        this.PostionY=player.YPosition;
        Console.SetCursorPosition(PostionX, PostionY);
        
    }
            private bool IsNextPositionEmpty(int nextPosition)
        {
            return nextPosition >= 0 && nextPosition < Console.WindowWidth;
        }
        public void Something(){
            string a= "👿";
            int PostionX=0;
            int postionY=0;
            Console.SetCursorPosition(PostionX+ 40, postionY+20);
            Console.WriteLine(a);
        }

}
