using System.Reflection.Metadata;
using System.Security;
// using Microsoft.EntityFrameworkCore;
using Spel;

internal class Program
{
    /* Vi tänkte ha en highscore list men omständigheter gjorde att vi hann inte med detta */
    
    private static void Main(string[] args)
    {
        List<User> mylist = new List<User>();//a list from the user class, because i need the users
        List<Score> scores = new List<Score>();
        Console.Write("Regestera dig här: ");
        SavingUser(mylist); 
        bool isSelected = false; //bool to control the loop 
        int option = 1; // to check the options we'll have 3 options
        ConsoleKeyInfo keyInfo;// we'll use it for the switch statement by using the Key prop
        string? interactive = "[V]   \u001b[32m";
        (int left, int top) = Console.GetCursorPosition();
        Map gameMap = new Map();
        Player player= new Player ("",1,2,1,10,50,10,gameMap);
        Mechanism mechanism= new Mechanism("F", player, gameMap);
        EasyMob mobs= new EasyMob("",1,5,1,10,15,gameMap, player);
        MediumMobs mediumMobs = new MediumMobs("", 1, 5, 1, 20, 9, gameMap, player);

        bool confimexit =false; 
        
       
        do 
        { 
            
            Console.SetCursorPosition(left, top);
            //showing the choosing one with an if statement
            Console.WriteLine($"{(option == 1 ? interactive : "    ")}Play\u001b[0m");
            Console.WriteLine($"{(option == 2 ? interactive : "    ")}HighScore\u001b[0m");
            Console.WriteLine($"{(option == 3 ? interactive : "    ")}Exit\u001b[0m");
            keyInfo = Console.ReadKey(); //than we get the key information to use it in switch statement
            switch (keyInfo.Key)
            {
                case ConsoleKey.DownArrow:
                    option = (option == 3 ? 1 : option + 1); //if we in the last option than get me back to option 1
                    break;
                case ConsoleKey.UpArrow:
                    option = (option == 1 ? 3 : option - 1); //if we in the first than get me back to option 3
                    break;
                case ConsoleKey.Enter:
                    isSelected = true;
                    if (option == 1)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(left, top);
                        Console.Write("[I]nventory");
                        gameMap.Draw(player);
                        PlayGame(player,mechanism, mobs, mediumMobs, left, top,confimexit,gameMap); 
                        
                    
                        if(player.IsDead())
                        {
                            isSelected=false;
                            Console.Clear();
                            player.Reset();
                        }
                        if(!confimexit)
                        {
                            isSelected = false;
                        }
                        
                    }
                    else if (option == 2)
                    {
                        Console.Clear();
                        ShowHighScore(mylist);
                        Console.ReadKey();
                        Console.SetCursorPosition(10, 20);
                        isSelected = false;
                    }
                    
                    else if (option == 3)
                    {
                        Console.WriteLine("GOOD BAY");
                        Thread.Sleep(150);
                    }
                    break;
            }
        }while (!isSelected);
    }
    // Database method to save the user information in a list  
    /* Vi tänkte  att ha med database ifa vi vill utveckla spelet så har vi det med */
    static void SavingUser(List<User> mylist)
    {
        using (var _context = new ApplicationDb())
        {
            _context.Database.EnsureCreated();
            string? userIn = Console.ReadLine();
            var user = new User();
            user.userName = userIn; 
            _context.users.Add(user);
            _context.SaveChanges();
            List<User> allUsers = _context.users.ToList();// converting _context.users to a list
            mylist.AddRange(allUsers); //than we save this list in the argument we have 
            // why using AddRange? because in _context.Users we have more than one element in side the
            // user table so we need to user AddRange method to save them all in once. like userName 
            // and userId. 
            // _context.Database.ExecuteSqlRaw("DELETE FROM users Where userId=1003");  
            // this method
            // used to delete one raw from a table. 

        }
    }
    static void ShowHighScore(List<User> users)
    {
        Console.Clear();
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine(users[i].userName + " ID : " + users[i].userId);
        }
    }
    /*GamePlay metoden
    vi tänkte fixa en metod som ska innehålla allt som gäller spelet. 
    vi kunde dela den metoden till andra små metoder men vi tänkte att det är bäst att vi ska ha en 
    hel metod som ska inenhålla allt ihopa. 
    den metoden innehålla alla "funktioner" som vi har i spelet. 
    vi ha en bool variable isGameRunning som vi använder för att kontrollera om spelt körs eller int
    för att stoppa loppen. 
    */
    static void PlayGame(Player player, Mechanism mechanism, EasyMob mobs,MediumMobs mediumMobs,int left , int top, bool confimexit, Map gameMap)
    {
        bool isGameRunning = true;
        bool showInventory = false;
        mobs = new EasyMob("M", 1, 5, 1, 4, 12, gameMap, player);
        mediumMobs = new MediumMobs("ME", 1, 5, 1, 8, 19, gameMap, player);
        player.AddItems(new List<HealthItems>
                            {
                                new HealthItems("H", 1, 0,10,20,1),
                                new HealthItems("H", 1, 0,15,10,2),
                                new HealthItems("H", 1, 0, 12,13,5)
                            });
        player.AddWeapon(
            new List <WeaponItem>{
                new WeaponItem("W",20,40,10,15,10),
                new WeaponItem("W",20,40,6,12,10)
            }
        );
    
        do
        {
           
            // Tree tree1 = new Tree("*", ConsoleColor.Red, 80, 12);
            // tree1.MakeingNature();
            player.PlayerPropertyes(mobs);
            player.ShowingTheItems();
            player.RemovingItems(gameMap);
            player.RemovingWeapon(gameMap);
            player.ShowingTheWeapons();
            mobs.ShowingTheCreatures(gameMap);
            mediumMobs.ShowingTheCreatures(gameMap);
            
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A)
            {
                player.MoveLeft(gameMap);
            }
            else if (key == ConsoleKey.RightArrow || key == ConsoleKey.D)
            {
                player.MoveRight(gameMap);
            }
            else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
            {
                player.MoveUp(gameMap);
            }
            else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
            {
                player.MoveDown(gameMap);
            }
            else if (key == ConsoleKey.I)
            {
                player.ShowInventory();
                showInventory = true;
                ConsoleKeyInfo nextKey = Console.ReadKey(); // Läs in nästa tangenttryckning
                if (nextKey.Key == ConsoleKey.Q)
                {
                    player.HideInventory();
                    showInventory = false;
                    gameMap.Draw(player);
                }
            }
            else if (key == ConsoleKey.Escape )
            {
                confimexit= ConfirmExit(left, top);
                  if (showInventory ||!confimexit ) // Om inventariet visas
                {
                showInventory = false;
                Console.Clear(); 
                gameMap.Draw(player); 
                player.PlayerPropertyes(mobs); 
                player.ShowingTheItems(); 
               

                }
                else if(confimexit)
                {
                    
                    isGameRunning=false;
                    Console.Clear();
                }
            }
            if (player.IsDead())
            {
                isGameRunning = false;
                break;
            }
            else if (key == ConsoleKey.Spacebar)
            {
                mechanism.Firing();
            }
            else if (key == ConsoleKey.B)
            {
                mechanism.Firing();
            }
            } while (isGameRunning);
    }
    // Den metoden skicka tillbaka ett värde true eller false för att vi ska bekräffta att spelaren vi
    //ut från spelet. eftersom vi jobbade i VS code så som du ser har vi gjort så här att vi gett top och left
    // ett värde för att styra hur långt upp det meddelnade (alltså valen) ska dyka upp.
    //annars så behöver vi inte de. 
    static bool ConfirmExit( int left, int top)
{
    Console.Clear();
    ConsoleKeyInfo escKey;
    string symbolToChoice = "[V]   \u001b[32m";
    int choice = 1;
    Console.WriteLine("Are you sure you want to leave the game?");
        do
        {
            Console.SetCursorPosition(left=0, top=3);
            Console.WriteLine($"{(choice == 1 ? symbolToChoice : "    ")}Yes\u001b[0m");
            Console.WriteLine($"{(choice == 2 ? symbolToChoice : "    ")}No\u001b[0m");
            escKey = Console.ReadKey();
            switch (escKey.Key)
            {
                case ConsoleKey.DownArrow:
                    choice = (choice == 2 ? 1 : choice + 1);
                    break;
                case ConsoleKey.UpArrow:
                    choice = (choice == 1 ? 2 : choice - 1);
                    break;
                case ConsoleKey.Enter:
                return choice==1;
            
            }
        } while (escKey.Key != ConsoleKey.Enter);
        return true; 
}
}

