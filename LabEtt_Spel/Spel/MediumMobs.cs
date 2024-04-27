//namespace Spel;

//public class MediumMobs : Mobs
//{
//    public MediumMobs(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
//        : base(name, strength, vitality, stamina, x, y, map, player)
//    {
//    }

//    //public override void Draw()
//    //{
//    //    Console.SetCursorPosition(X, Y);
//    //    Console.WriteLine("👹");
//    //}
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
using System;

namespace Spel
{
    public class MediumMobs : Mobs
    {
        public MediumMobs(string name, int strength, int vitality, int stamina, int x, int y, Map map, Player player)
            : base(name, strength, vitality, stamina, x, y, map, player)
        {
        }

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
    }
}

