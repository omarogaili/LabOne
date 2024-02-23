namespace _2Dice;

public class RockPaperScissors
{
    public void  GameObject(){
        List<string> gameObjects = new List<string>();
        gameObjects.Add("Sten");
        gameObjects.Add("Sax");
        gameObjects.Add("Påse");
        Random rand= new Random(); // because we have a list of strings so we cant use random directly
        int randIndex = rand.Next(gameObjects.Count);
        string theRandomChoice= gameObjects[randIndex];
        Console.Write("Välje en av : Sten, Sax, Påse ");
        string? playerChoice= Console.ReadLine();
        if(gameObjects[randIndex]== playerChoice){
            for(int i= 0; i < gameObjects.Count; i++){
                Console.WriteLine("Du valde lika :"+gameObjects[i]+ playerChoice);
            }
        }
        else if(gameObjects[randIndex] == "Paper" && playerChoice == "Sax"){
            for(int i = 0; i < gameObjects.Count; i++){
                Console.WriteLine("Du vann : "+ gameObjects[i]+" " + gameObjects[randIndex]+" " + playerChoice);
            }
    }
}
}
