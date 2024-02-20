using System.Security.Cryptography.X509Certificates;

namespace Spel;

public class EasyMob : Characters
{
    private int x;
    private int y;
//  public int XPositions { get; set; }
//     public int YPosition { get; set; }

    public EasyMob(string name, double vitality, int X, int Y) : base(name, 1.1, vitality, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0)
    {
        name = "👽"; //this the shape i want. 
        this.Name = name;
        vitality = 10;
        this.Vitality = vitality;
        Console.Write(name);
        this.X = X;
        this.Y = Y;
    }
        public int X {get{ return X; } set { X = value;}}
        public int Y {get{ return Y; } set { Y = value;}}
    // public void ShowingEasyMob()
    // {
    //     this.Name = "👽";
    //     int X = 0;
    //     int Y = 0;
    //     Console.SetCursorPosition(X + 10, Y + 15);
    //     Console.WriteLine(this.Name);
    // }


    // private void UpdateLocation()
    // {
    //     Console.Clear();
    //     Console.SetCursorPosition(XPositions, YPosition);
    //     Console.Write(Name);
        
    // }
    
}
