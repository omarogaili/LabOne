// using Microsoft.IdentityModel.Tokens;

namespace Spel;

public class Mobs : Characters
{
    Player player;
    Mechanism mechanism;
    private int X {get; set;}
    private int Y {get;set;}
    List<EasyMob> easymob = new List<EasyMob>();
    private Map map;

    List <MediumMobs> mediumMobs = new List<MediumMobs>();
    Random rand = new Random();

    public Mobs(string name,int strength, int vitality, int stamina, int x, int y,Player player, Mechanism mechanism,Map map ) 
    : base(name,strength,vitality,stamina)
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
// public int GetSomeDamage()
// {
//     foreach (EasyMob mob in easymob)
//     {
//         if (player.XPositions == mob.EasyMobsX && player.YPosition == mob.EasyMobsY)
//         {
//              // Beräkna skadan som minsta av spelarens hälsa och fiendens skada
//             player.Vitality -= mob.Damage; // Dra av skadan från spelarens hälsa
//         }
//     }
//     return player.Vitality;
    
// }
public int GetSomeDamage()
{
    foreach (EasyMob mob in easymob)
    {
        if (player.XPositions == mob.EasyMobsX && player.YPosition == mob.EasyMobsY)
        {
            // Beräkna skadan som minsta av spelarens hälsa och fiendens skada
            int damageTaken = Math.Min(player.Vitality, mob.Damage);
            player.Vitality -= damageTaken; // Dra av skadan från spelarens hälsa

            if (player.Vitality <= 0)
            {
                // Om spelarens hälsa blir noll eller mindre, avsluta spelet
                player.Vitality = 0;
                return player.Vitality; // Returnera den nya hälsan
            }
        }
    }
    return player.Vitality;
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

public void RemovingMobs(Map map)
{
    for (int i = easymob.Count - 1; i >= 0; i--)
    {
        EasyMob easyMob = easymob[i];
        if (mechanism.PostionX >= easyMob.EasyMobsX && mechanism.PostionY == easyMob.EasyMobsY
            || player.XPositions == easyMob.EasyMobsX && player.YPosition == easyMob.EasyMobsY)
        {
            player.Vitality -= easyMob.Damage;
            player.Vitality= GetSomeDamage();
            easymob.RemoveAt(i);
            player.XpPoints += easyMob.XpPoints;

            // Generera en ny position inom kartans gränser
            easyMob.EasyMobsX = rand.Next(1, map.Width - 6);
            easyMob.EasyMobsY = rand.Next(1, map.Height - 5);

            EasyMob newEasyMob = new EasyMob(easyMob.Easymob, easyMob.EasyMobsX, easyMob.EasyMobsY,
                easyMob.Health, easyMob.XpPoints, easyMob.Damage, easyMob.Vitality);
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

