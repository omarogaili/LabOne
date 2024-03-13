// using Microsoft.IdentityModel.Tokens;

namespace Spel;

public class Mobs : Characters
{
    Player player;
    Mechanism mechanism;
    private int x;
    private int y;
    List<EasyMob> easymob = new List<EasyMob>();
    private Map map;

    List <MediumMobs> mediumMobs = new List<MediumMobs>();
    Random rand = new Random();

    public Mobs(string name, int vitality, int x, int y,Player player, Mechanism mechanism,Map map ) 
    : base(name, 1, vitality, 2, 3, 4, 5, 6, 7, 8, 9)
    {
        name = "👽"; //this the shape i want. 
        this.Name = name;
        vitality = 10;
        this.Vitality = vitality;
        Console.Write(name);
        this.X = x;
        this.Y = y;
        this.player= player;
        this.mechanism= mechanism;
        this.map= map;
    }
public int X
    {
        get { return x; }
        set { x = value; }
    }
    public int Y
    {
        get { return y; }
        set { y = value; }
    }
      public void AddMobs(List<EasyMob> newEasymob)
    {
        easymob.AddRange(newEasymob);
    }

    public void AddMediumMobs(List<MediumMobs> newMediumMobs)
    {
        mediumMobs.AddRange(newMediumMobs);
    }   

    public override void ShowingTheCreatures()
    {
        foreach (EasyMob easyMob in easymob)
        {
            Console.SetCursorPosition(easyMob.EasyMobsX, easyMob.EasyMobsY);
            Console.WriteLine(easyMob.Easymob);
        }
    }

    public override void ShowingTheMediumMobs(){
        foreach (MediumMobs mediumMob in mediumMobs)
        {
            Console.SetCursorPosition(mediumMob.MediumMobX, mediumMob.MediumMobY);
            Console.WriteLine(mediumMob.MediumMob);
        }
    }
    public void GetSomeDamage()
{
    foreach (EasyMob mob in easymob)
    {
        if (player.XPositions == mob.EasyMobsX && player.YPosition == mob.EasyMobsY)
        {
            if (player.Vitality <= mob.Damage)
            {
                player.Vitality = 0;
            }
            else
            {
                player.Vitality -= mob.Damage; 
            }
            /*add more prop lik coolness and strength */
            /*the same logic we should use if the player ben hit or moved ner by the anime */
        }
    }
}

    public void GetSomeDamageFromMediumMobs(){
        foreach (MediumMobs mob in mediumMobs)
        {
            if (player.XPositions == mob.MediumMobX && player.YPosition == mob.MediumMobY)
            {
                player.Vitality -= mob.Damage;
                /*add more prop lik coolness and strength */
                /*the same logic we should use if the player ben hit or moved ner by the anime */
            }
        }
    }

//    public void RemovingMobs(Map map)
//     {
//         for (int i =easymob.Count -1; i>=0; i--){
//             EasyMob easyMob = easymob[i];
//             if(mechanism.PostionX>= easyMob.EasyMobsX  &&  mechanism.PostionY ==easyMob.EasyMobsY 
//             || player.XPositions == easyMob.EasyMobsX && player.YPosition == easyMob.EasyMobsY){
//                 GetSomeDamage();
//                 easymob.RemoveAt(i);
//                 player.XpPoints += easyMob.XpPoints;
//                 easyMob.EasyMobsX = rand.Next(map.Width -6);
//                 easyMob.EasyMobsY = rand.Next(map.Height-5);                 
//                 EasyMob newEasyMob = new EasyMob(easyMob.Easymob, easyMob.EasyMobsX, easyMob.EasyMobsY, 
//                 easyMob.Health, easyMob.XpPoints, easyMob.Damage);
//                 Console.SetCursorPosition(easyMob.EasyMobsX, easyMob.EasyMobsY);
//                 List<EasyMob> newEasymob = new List<EasyMob> { easyMob };
//                 AddMobs(newEasymob);
//             }
//         }
//     }
public void RemovingMobs(Map map)
{
    for (int i = easymob.Count - 1; i >= 0; i--)
    {
        EasyMob easyMob = easymob[i];
        if (mechanism.PostionX >= easyMob.EasyMobsX && mechanism.PostionY == easyMob.EasyMobsY
            || player.XPositions == easyMob.EasyMobsX && player.YPosition == easyMob.EasyMobsY)
        {
            GetSomeDamage();
            easymob.RemoveAt(i);
            player.XpPoints += easyMob.XpPoints;

            // Generera en ny position inom kartans gränser
            easyMob.EasyMobsX = rand.Next(1, map.Width - 6);
            easyMob.EasyMobsY = rand.Next(1, map.Height - 5);

            EasyMob newEasyMob = new EasyMob(easyMob.Easymob, easyMob.EasyMobsX, easyMob.EasyMobsY,
                easyMob.Health, easyMob.XpPoints, easyMob.Damage);
            Console.SetCursorPosition(easyMob.EasyMobsX, easyMob.EasyMobsY);
            List<EasyMob> newEasymob = new List<EasyMob> { easyMob };
            AddMobs(newEasymob);
        }
    }
}

    public void RemovingMediumMobs(Map map)
    {
        for (int i =mediumMobs.Count -1; i>=0; i--){
            MediumMobs mediumMob = mediumMobs[i];
            if(mechanism.PostionX>= mediumMob.MediumMobX  &&  mechanism.PostionY ==mediumMob.MediumMobY 
            || player.XPositions == mediumMob.MediumMobX && player.YPosition == mediumMob.MediumMobY){
                GetSomeDamageFromMediumMobs();
                mediumMobs.RemoveAt(i);
                player.XpPoints += mediumMob.XpPoints;
                mediumMob.MediumMobX = rand.Next(1,map.Width -6);
                mediumMob.MediumMobY = rand.Next(1,map.Height-5);                  
                MediumMobs newMediumMob = new MediumMobs(mediumMob.MediumMob, mediumMob.MediumMobX, mediumMob.MediumMobY, 
                mediumMob.Health, mediumMob.XpPoints, mediumMob.Damage);
                Console.SetCursorPosition(mediumMob.MediumMobX, mediumMob.MediumMobY);
                List<MediumMobs> newMediumMobs = new List<MediumMobs> { mediumMob };
                AddMediumMobs(newMediumMobs);
            }
        }
    }
}

