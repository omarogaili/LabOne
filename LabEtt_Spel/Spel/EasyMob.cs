//using System.Security.Cryptography.X509Certificates;

//namespace Spel;
//public class EasyMob : Mobs
//{
//    public EasyMob(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
//        : base(name, strength, vitality, stamina, x, y, map, player)
//    {
//    }
//    public override void ShowingTheCreatures()
//    {
//        Console.WriteLine(this.Name + this.Vitality);
//    }

//    public override void UpdateLocation()
//    {
//        if (player.XPositions == X && player.YPosition == Y)
//        {
//            GetNewLocation();
//        }
//    }
//}
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace Spel
{
    public class EasyMob : Mobs
    {
        public EasyMob(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
            : base(name, strength, vitality, stamina, x, y, map, player)
        {
        }
        public bool IsDead { get; private set; } = false;

        public override void ShowingTheCreatures()
        {
            Console.WriteLine(this.Name + this.Vitality);
        }

        public override void UpdateLocation()
        {
            if (player.XPositions == X && player.YPosition == Y)
            {
                GetNewLocation();
            }
        }
        public void Dead()
        {
           IsDead = true;
        }
    }
}
