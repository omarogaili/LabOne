//using System.Security.Cryptography.X509Certificates;

//namespace Spel;

//public class Map
//{

//    public readonly int Width = +60 ;
//    public readonly int Height = +30;
//    public string[,] tiles;


//    public Map()
//    {
//        tiles = new string[Width, Height];

//        // Making the map
//        for (int x = 0; x < Width; x++)
//        {
//            for (int y = 0; y < Height; y++)
//            {
//                if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
//                {
//                    // Place a wall at the edges of the map
//                    tiles[x, y] = "#";
//                }
//                else
//                {
//                    // Fill the rest of the map with empty spaces
//                    tiles[x, y] = " ";
//                }
//            }
//        }
//    }
//    public int MapWidth
//    {
//        get { return Width; }
//    }

//    public int MapHeight
//    {
//        get { return Height; }
//    }



//    public void Draw(Player player)
//    {
//        Console.Clear();
//        for (int y = 0; y < Height; y++)
//        {
//            for (int x = 0; x < Width; x++)
//            {
//                Console.Write(tiles[x, y]);
//            }
//            Console.WriteLine();

//        }
//        Console.SetCursorPosition(player.XPositions, player.YPosition);
//        Console.Write(player.Name);

//    }


//}
using System;
using System.Collections.Generic;

namespace Spel
{
    public class Map
    {
        public readonly int Width = 60;
        public readonly int Height = 30;
        public string[,] tiles;
        private List<EasyMob> enemies;

        public Map()
        {
            tiles = new string[Width, Height];

            // Skapa kartan
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
                    {
                        tiles[x, y] = "#"; // Vägg
                    }
                    else
                    {
                        tiles[x, y] = " "; // Tomt utrymme
                    }
                }
            }

            // Skapa en lista för fiender
            enemies = new List<EasyMob>();
        }

        public void AddEnemy(EasyMob enemy)
        {
            enemies.Add(enemy);
        }

        public void DrawEnemies()
        {
            foreach (var enemy in enemies)
            {
                Console.SetCursorPosition(enemy.X, enemy.Y);
                Console.Write(enemy.Name);
            }
        }

        public void RemoveDeadEnemies()
        {
            enemies.RemoveAll(enemy => enemy.IsDead);
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

            DrawEnemies(); // Rita ut fiender
        }
    }
}
