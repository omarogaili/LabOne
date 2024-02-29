namespace Spel;

public class Tree : Nature
{
    private int x;
    private int y;
    private ConsoleColor prevColor;

public Tree(string shape,ConsoleColor prevColor, int x, int y) : base(shape,prevColor)
{
    this.Shape = shape;
    this.TreeX = x;
    this.TreeY = y;
    this.PrevColor = prevColor;

}
public int TreeX
    {
        get { return x; }
        set { x = value; }
    }
    public int TreeY
    {
        get { return y; }
        set { y = value; }
    }
    public void SetShape(string shape)
    {
        ConsoleColor prevcolor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        int rows = 9;
        for (int i = 0; i <= rows; i++)//H
        {
            for (int x = 0; x < rows - i; x++) Console.Write(" ");
            for (int j = 0; j < i * 2 - 1; j++) //W
                Console.Write(shape);
            Console.WriteLine();
        }
        Console.ForegroundColor = prevcolor;
    }
    public void MakeingNature()
{ 
    int windowWidth = Console.WindowWidth;
    int windowHeight = Console.WindowHeight;

    // Justera x-koordinaten så att trädet inte hamnar utanför högerkanten av fönstret
    int adjustedX = windowWidth - 10; // Justera detta värde efter behov

    // Kontrollera att x-koordinaten inte är utanför fönstret
    if (adjustedX >= 0 && adjustedX < windowWidth && TreeY >= 0 && TreeY < windowHeight)
    {
        TreeX = adjustedX;
        string shape = "*";
        Console.SetCursorPosition(TreeX-6, TreeY);
        SetShape(shape);
    }
}
}
