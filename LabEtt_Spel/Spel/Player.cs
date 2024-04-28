// using Microsoft.Identity.Client;

using System.IO.Compression;
using System.Threading.Tasks.Dataflow;

namespace Spel;
/// <summary>
/// den klassen är har allt som berör spelaren. rörelse metoder, items liksom hälsa och vapen samt hur spelaren skjuter fiender
/// </summary>
public class Player : Characters
{
    private List<HealthItems> items = new List<HealthItems>();
    private List<WeaponItem> weapons = new List<WeaponItem>(4); // Changed to List<WeaponItem>    private Mechanism mechanism;
    Map map = new Map();
    private Random rand = new Random();
    public int XPositions { get; set; } // spelaren plats i X axel
    public int YPosition { get; set; } // spelaren plats i Y axel
    public int XpPoints { get; set; } // XP points

    //constructor for the class player from 
    public Player(string shape, int strength, int vitality, int stamina, int xpPoints, int postionX, int postionY, Map map)
    : base(shape, strength, vitality, stamina)
    {
        shape = "P"; //this the shape i want. 
        this.Name = shape;
        this.Vitality = vitality;
        this.XPositions = postionX;
        this.YPosition = postionY;
        this.XPositions = xpPoints;
        this.map = map;
        // mechanism = new Mechanism ( XPositions +2, YPosition);
    }
    // den metodden ansvarig för att skriva ut spelaren 
    public override void ShowingTheCreatures(Map map)
    {
        Console.WriteLine(this.Name + this.Vitality);
    }
    // den metoden ansvarig för att skriva mobs
    //rörelse metoder neddan,
    // det som jag gör är att jag kontrollerar spelaren position och sedan sätter jag en CursorPosition och minska sedan X platsen 
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
    // fungerar påsamma sätt som metoden övan men jag gav - 4 från map breed för att sätta gräns så att inte spelaren röra sig utanför map
    public void MoveRight(Map map)
    {
        if (XPositions < map.Width - 4)
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
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(' '); 
            YPosition--;
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(Name);
        }
    }
    public void MoveDown(Map map)
    {
        if (YPosition < map.Height - 2)
        {
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(' '); 

            YPosition++;
            Console.SetCursorPosition(XPositions, YPosition);
            Console.Write(Name);
        }
    }
    // den metoden är ansvarig för att updatera spelarens plats.
    private void UpdateLocation()
    {
        Console.Clear();
        Console.SetCursorPosition(XPositions, YPosition);
        Communication(map);
    }
    //meningen med den metoden är att spelaren ska kunna prata när den röra sig, men eftersom vi har fixat en map och så ligger den under map, 
    // metoden kontrollerar spelarens x och y position och sedan har jag skapat en lista av olika strings för att de ska visas i skärmen för varje gång
    //spelaren röra på sig samt en random för att en random text ska visas i skärmen. 
    // jag justerar text position där Console.SetCursorPosition(xaxis, yaxis - 12); för att texten ska visas ovanför spelaren. 
    private void Communication(Map map)
    {
        int xaxis = XPositions;
        int yaxis = YPosition + 10;
        List<string> speech = new List<string>(){
            "I'll Wack you up",
            "Are you sure about that",
            "Welcome to me World!",
            };
        Random randChat = new Random();
        int index = randChat.Next(speech.Count);
        string chatting = speech[index];
        Console.SetCursorPosition(xaxis, yaxis - 12);
        Console.WriteLine(chatting);
    }
    /// <summary>
    /// spelarens egenskaper liksom XP och hälsa för att spelaren ska hålla sig updaterad om sin egenskaper 
    /// </summary>
    /// <param name="mobs"> jag skickar in klassen mobs för att dessa egenskaper blir påverkade av fiendenerna </param>
    public void PlayerPropertyes(Mobs mobs)
    {
        int xaxis = Console.WindowWidth - 20;
        int yaxis = Console.WindowHeight - 10;
        Console.SetCursorPosition(xaxis, yaxis);
        Console.WriteLine("Health" + ":" + this.Vitality + "\n" + "XP :" + this.XpPoints);
        
        
    }
    /// <summary>
    /// skapar en lisa av Vapen som soelaren kan tar upp och sedan lägga till de i inventroy metoden 
    /// </summary>
    /// <param name="weapon">Vapen lista från Vapen klassen</param>
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
