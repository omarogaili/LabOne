namespace Spel;

public class Mechanism
{
    private string fire = "🔥";
    private int xPosition;
    private int yPosition;
    private Player player;
    private Map map;
    //constructor 
    public Mechanism(string fire, Player player, Map map)
    {
        this.Fire = fire;
        this.PostionX = player.XPositions;
        this.PostionY = player.YPosition;
        this.player = player;
        this.map = map;
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

    /* this make a thread, so we can move the player at the same time we can move the player. because we have an While
    loop in Showing fire method. 
    */
    public void Firing()
{
    Thread fireThread = new Thread(new ThreadStart(ShoweTheFire));
    fireThread.Start();
}

    public void ShoweTheFire()
    {
        this.PostionX=player.XPositions+1; //adding 2 steps at the positive x direction 
        this.PostionY= player.YPosition;
        // ConsoleKeyInfo keyInfo;
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
                if(this.PostionX <0 || this.PostionX >= map.Width){
                    break;
                }
        }
        UpdateLocation();
          while (key == ConsoleKey.B )
        {
            Console.SetCursorPosition(xPosition +1 ,yPosition);
            PostionX--;
            Console.WriteLine(this.Fire);
            System.Threading.Thread.Sleep(100);
                if (!IsNextPositionEmpty(xPosition - 1))
                {
                    break;
                }
                 if(this.PostionX <0 || this.PostionX >= map.Width){
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
        // Console.Clear();
        map.Draw(player);
        this.PostionX=player.XPositions;
        this.PostionY=player.YPosition;
        Console.SetCursorPosition(PostionX, PostionY);
        
    }
            private bool IsNextPositionEmpty(int nextPosition)
        {
            return nextPosition >= 0 && nextPosition < Console.WindowWidth;
        }
}
