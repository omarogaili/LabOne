using System.Security.Cryptography.X509Certificates;

namespace Spel;

public class Map
{
    
    public readonly int Width = +60 ;
    public readonly int Height = +30;
    public string[,] tiles;
    private Player player;
    

    public Map()
    {
        tiles = new string[Width, Height];

        // Making the map
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
                {
                    // Place a wall at the edges of the map
                    tiles[x, y] = "#";
                }
                else
                {
                    // Fill the rest of the map with empty spaces
                    tiles[x, y] = " ";
                }
            }
        }
    }
    public int MapWidth
    {
        get { return Width; }
    }

    public int MapHeight
    {
        get { return Height; }
    }



    public void Draw(Player player)
    {
        Console.Clear();
        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
            {
                Console.Write(tiles[x, y]);
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(player.XPositions, player.YPosition);
        Console.Write(player.Name);
    }

}