
using System;

namespace Spel
{
    /// <summary>
    /// den klassen skulle ärva från Mobs som ärver från Characters. 
    /// </summary>
    public class MediumMobs : Mobs
    {
        public MediumMobs(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
            : base(name, strength, vitality, stamina, x, y, map, player)
        {
        }

        public override void ShowingTheCreatures(Map map)
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.Name + this.Vitality);
            UpdateLocation(map);
        }

        public override void UpdateLocation(Map map)
        {
            if (player.XPositions == X && player.YPosition == Y)
            {
                GetNewLocation(map);
            }
        }
    }
}

