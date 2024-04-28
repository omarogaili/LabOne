
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace Spel
{ /// <summary>
///  den klassen ska ärva från Mobs som ärver från Characters. 
/// </summary>
    public class EasyMob : Mobs
    {
        public EasyMob(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
            : base(name, strength, vitality, stamina, x, y, map, player)
        {
        }
        public bool IsDead { get; private set; } = false;

        public override void ShowingTheCreatures(Map map)
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.Name);
            UpdateLocation(map);
        }

        public override void UpdateLocation(Map map)
        {
            if (player.XPositions == X && player.YPosition == Y)
            {
                GetNewLocation(map);
            }
        }
        public void Dead()
        {
           IsDead = true;
        }

    }
}
