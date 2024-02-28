using System.Drawing;

namespace Spel;

public abstract class Nature
{
    /* in this class we define the nature of the game. so what i need to do
    in this class is: to give it a property. for example what the Color is?
    if we talk about trie or sky the color is different.also the size of this things.
    or more batter to give them type.So Color and Size are the best things to
    have it in this class, and some methods to do something with all of
    this stuff. 
    */
    private string? shape;
    List<Tree> tree = new List<Tree>();// a list of tree 
    ConsoleColor prevcolor = Console.ForegroundColor;
    // private int x;
    // private int y;
    public Nature(string shape, ConsoleColor prevColor)
    {
        this.shape = shape;
        this.prevcolor = prevColor;
    }
    public string Shape
    {
        get { return shape; }
        set { shape = value; }
    }
    //here i will print the shape and add it to the list i have every time u print the tree add it to my list 
    public abstract void DrawShape(string shape);
    public void AddTree()
    {
        Tree tree = new Tree(shape, prevcolor, 10, 2);
        tree.DrawShape(shape);
    }
    public abstract void MakeingNature();
}
