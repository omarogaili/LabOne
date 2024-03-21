// using Microsoft.Identity.Client;

using System.IO.Compression;
using System.Threading.Tasks.Dataflow;

namespace Spel;

public class Player : Characters
{
    private List<HealthItems> items = new List<HealthItems>();
    private List<WeaponItem> weapons = new List<WeaponItem>(4); // Changed to List<WeaponItem>    private Mechanism mechanism;
    Map map = new Map();
    private Random rand = new Random();
    public int XPositions { get; set; }
    public int YPosition { get; set; }
    public int XpPoints { get; set; }
    int initialX;
    int initialY;
    int initialHealth;

    //constructor for the class player from 
    public Player(string shape, int strength, int vitality, int stamina, int xpPoints, int postionX, int postionY, Map map)
    : base(shape, strength, vitality, stamina)
    {
        shape = "🤺"; //this the shape i want. 
        this.Name = shape;
        this.Vitality = vitality;
        this.XPositions = postionX;
        this.YPosition = postionY;
        this.XPositions = xpPoints;
        this.map = map;
        // mechanism = new Mechanism ( XPositions +2, YPosition);
    }
    public override void ShowingTheCreatures()
    {
        Console.WriteLine(this.Name + this.Vitality);
    }

    public override void ShowingTheMediumMobs()
    {
        Console.WriteLine(this.Name + this.Vitality);
    }
    public void MoveLeft(Map map)
    {
        if (XPositions > 1)
        {
            // Clear the player's current position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(' '); // ' ' represents an empty tile

            // Update the player's position
            XPositions--;

            // Update the player's position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(Name);
        }
    }

    public void MoveRight(Map map)
    {
        if (XPositions < map.MapWidth - 4)
        {
            // Clear the player's current position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(' '); // ' ' represents an empty tile
                                // Update the player's position
            XPositions++;
            // Update the player's position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(Name);
        }
    }

    public void MoveUp(Map map)
    {
        if (YPosition > 1)
        {
            // Clear the player's current position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(' '); // ' ' represents an empty tile
                                // Update the player's position
            YPosition--;
            // Update the player's position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(Name);
        }
    }
    public void MoveDown(Map map)
    {
        if (YPosition < map.MapHeight - 2)
        {
            // Clear the player's current position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(' '); // ' ' represents an empty tile

            // Update the player's position
            YPosition++;

            // Update the player's position on the console
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(Name);
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
        int yaxis = YPosition + 10;
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
    public void PlayerPropertyes(Mobs mobs)
    {
        int xaxis = Console.WindowWidth - 20;
        int yaxis = Console.WindowHeight - 10;
        Console.SetCursorPosition(xaxis, yaxis);
        Console.WriteLine("Health" + ":" + this.Vitality + "\n" + "XP :" + this.XpPoints);
        
        
    }
    public void AddWeapon(List<WeaponItem> weapon)
    {
        weapons.AddRange(weapon);
    }
    //to show the weapon so the player should tap att I 
    public void ShowInventory()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            Console.Clear();
            Console.WriteLine($" Your Inventory: {weapons[i].Item}");
        }
    }
    public void HideInventory()
    {
        Console.Clear(); 
    }
    //change the weapon
    public void ChangeTheWeapon(string weaponName)
    {
        var selectedWeapon = weapons.Find(w => w.Item == weaponName);
        if (selectedWeapon != null)
        {
            Console.WriteLine($"Using weapon: {selectedWeapon.Item}, Damage: {selectedWeapon.Damage}");
        }
        else
        {
            Console.WriteLine("Weapon not found!");
        }
    }
    public void AddItems(List<HealthItems> newItems)
    {
        items.AddRange(newItems);
    }
    public int RangeUp()
    {
        foreach (HealthItems item in items)
        {
            int newHealth;
            if (XPositions == item.LocationX && YPosition == item.LocationY)
            {
                newHealth = this.Vitality + item.Health;
                Vitality= newHealth;
                /*add more prop lik coolness and strength */
                /*the same logic we should use if the player ben hit or moved ner by the anime */
                break;
            }
        }
        return Vitality;
    }
    public void ShowingTheItems()
    {
        foreach (HealthItems item in items)
        {
            Console.SetCursorPosition(item.LocationX, item.LocationY);
            Console.WriteLine(item.Item);
        }
    }
    public void ShowingTheWeapons()
    {
        foreach (WeaponItem w in weapons)
        {
            Console.SetCursorPosition(w.LocationX, w.LocationY);
            Console.WriteLine(w.Item);
        }
    }
    /* in this method we have one condition if the x and y position of the player and the food att the same 
    so we give the x and y position of the food a new random position and than we send it to the items location
    by using the SetCursorPosition() så we "write" the new place and than save it in a list and after that we send it 
    for Add item method to save it in the list and Write it. 
    */

    public void RemovingItems(Map map)
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            HealthItems item = items[i];
            if (XPositions == item.LocationX && YPosition == item.LocationY)
            {
                Vitality= RangeUp();
                items.RemoveAt(i);
                item.LocationX = rand.Next(1, map.Width - 6);
                item.LocationY = rand.Next(1, map.Height - 5);//säker ställa att den inte gå ut
                HealthItems newItem = new HealthItems(item.Item, item.Weight, item.Values, item.LocationX, item.LocationY, item.Health);
                Console.SetCursorPosition(item.LocationX, item.LocationY);
                List<HealthItems> newItems = new List<HealthItems> { newItem };
                AddItems(newItems);
                
            }
        }
    }
    public void RemovingWeapon(Map map)
    {
        for (int i = weapons.Count - 1; i >= 0; i--)
        {
            WeaponItem item = weapons[i];
            if (XPositions == item.LocationX && YPosition == item.LocationY)
            {
                weapons.RemoveAt(i); // Remove the item from the weapons list
                item.LocationX = rand.Next(1, map.Width - 6);
                item.LocationY = rand.Next(1, map.Height - 5);
                WeaponItem newItem = new WeaponItem(item.Item, item.Weight, item.Values, item.LocationX, item.LocationY, item.Damage);
                Console.SetCursorPosition(item.LocationX, item.LocationY);
                weapons.Add(newItem); // Add the updated item back to the weapons list
            }
        }
    }

/* kollar om vitality är 0 då är spelaren död och hjälper oss att avsluta spelet*/
    public bool IsDead()
    {
        if (this.Vitality <= 0)
        {
            Console.Clear();
            Console.WriteLine("GAME OVER");
            return true;
        }
        return false;
    }
    /*
    Den metoden använder vi för att vi ska göra en Reset om spelaren någon gång väljer gå ut från spelet 
    till huvud menu och sedan vill den spela igen utan att stänga av programet (spelet)
    */
    public void Reset()
    {
        Console.Clear();
        YPosition = 9;
        this.XPositions = 10;
        this.Vitality = Vitality;
        this.XpPoints = 0;
        UpdateLocation();
        IsDead();
    }
    //to make the player coolness change,so what we need to do is 
    //create a new list this list should the player (user) choose from 
    // when it's time to choose something (in the fight or in conversation) with the 
    //this method will be placed down here ||
}
