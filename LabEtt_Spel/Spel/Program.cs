using System.Security;
// using Microsoft.EntityFrameworkCore;
using Spel;

internal class Program
{
    
    private static void Main(string[] args)
    {
   
        // EasyMob mob= new EasyMob("👽",10 ,10, 12, mechanism);
        List<User> mylist = new List<User>();//a list from the user class, because i need the users
        Console.Write("Regestera dig här: ");
        SavingUser(mylist);     
        bool isSelected = false; //bool to control the loop 
        int option = 1; // to check the options we'll have 3 options
        ConsoleKeyInfo keyInfo;// we'll use it for the switch statement by using the Key prop
        string? interactive = "☑️   \u001b[32m";
        (int left, int top) = Console.GetCursorPosition();

        Player player= new Player ("",2,4,10,10);
        Mechanism mechanism= new Mechanism("💀", player);
        Mobs mobs= new Mobs("👽", 10, 10, 12,player,mechanism);
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
                        player.AddItems(new List<Items>
                            {
                                new Items("🌯", 10, 20,2),
                                new Items("🦐", 15, 10,5),
                                new Items("🍺", 12, 13, 10)
                            });
                            mobs.AddMobs(new List<EasyMob>
                            {
                                new EasyMob("🦹", 10, 35,12,10,10),
                                new EasyMob("👻", 15, 27,5, 10,1),
                                new EasyMob("👿", 12, 20, 10, 10,1)
                            });
                            player.RangeUp();
                        // Characters characters= new Characters();
                        // player.ShowingTheCreatures();
                        // bool isDead = false;
                        do
                        {
                            Tree tree1 = new Tree("*", ConsoleColor.Red,80, 12);
                            tree1.MakeingNature();
                            player.PlayerPropertyes();
                            player.ShowingTheItems();
                            mobs.ShowingTheMobs();
                            mobs.RemovingMobs();
                            player.RemovingItems();
                            player.RangeUp();
                            var key = Console.ReadKey(true).Key;
                            if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A)
                            {
                                player.MoveLeft();
                            }
                            else if (key == ConsoleKey.RightArrow || key == ConsoleKey.D)
                            {
                                player.MoveRight();
                            }
                            else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
                            {
                                player.MoveUp();
                            }
                            else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
                            {
                                player.MoveDown();
                            }
                            else if (key == ConsoleKey.Escape)
                            {
                                Console.Clear();
                                ConsoleKeyInfo escKey;
                                string symbolToChoice = "☑️   \u001b[32m";
                                int choice = 1;
                                Console.WriteLine("Are you sure you want to leave me alone?");
                                do
                                {
                                Console.SetCursorPosition(left, top);
                                Console.WriteLine($"{(choice == 1 ? symbolToChoice : "    ")}Yes");
                                Console.WriteLine($"{(choice == 2 ? symbolToChoice : "    ")}No");
                                    escKey = Console.ReadKey();
                                    switch (escKey.Key)
                                    {
                                        case ConsoleKey.DownArrow:
                                            choice = (choice == 2 ? 1 : choice +1);
                                            break;
                                        case ConsoleKey.UpArrow:
                                            choice = (choice == 1 ? 2 : choice -1);
                                            break;
                                        case ConsoleKey.Enter:
                                            if (choice == 1)
                                            {
                                                isSelected =false;
                                            }
                                            else if (choice == 2)
                                            {
                                                isSelected = true;
                                            }
                                            break;
                                    }
                                } while (escKey.Key != ConsoleKey.Enter); // Fortsätt loopa tills användaren trycker på Enter
                            }
                            if (player.IsDead())
                            {
                                Console.Clear();
                                isSelected = false;
                            }
                            else if (key == ConsoleKey.Spacebar)
                            {
                                mechanism.Firing();
                            }                           
                            else if (key == ConsoleKey.B )
                            {
                                mechanism.Firing();
                            }
                        }while (!player.IsDead());
                    } 
                    else if (option == 2)
                    {
                        for (int i = 0; i < mylist.Count; i++)
                        {
                            Console.WriteLine(mylist[i].userName + " ID : " + mylist[i].userId);
                        }
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("GOOD BAY");
                        Thread.Sleep(150);
                    }
                    break;
            }
        }while (!isSelected);
        // List<User> mylist = new List<User>();//a list from the user class, because i need the users
        // SavingUser(mylist);//argument to saving user method 
        // for (int i = 0; i < mylist.Count; i++)
        // {
        //     Console.WriteLine(mylist[i].userName + " " + mylist[i].userId);
        // }
    }
    //Database method to save the user information in a list  
    static void SavingUser(List<User> mylist)
    {
        using (var _context = new ApplicationDb())
        {
            _context.Database.EnsureCreated();
            string? userIn = Console.ReadLine();
            var user = new User();
            user.userName = userIn; 
            _context.users.Add(user);
            // _context.SaveChanges();
            List<User> allUsers = _context.users.ToList();// converting _context.users to a list
            mylist.AddRange(allUsers); //than we save this list in the argument we have 
            //why using AddRange? because in _context.Users we have more than one element in side the
            //user table so we need to user AddRange method to save them all in once. like userName 
            //and userId. 
            // _context.Database.ExecuteSqlRaw("DELETE FROM users Where userId=1003");  
            //this method
            //used to delete one raw from a table. 
        }
    }
}

