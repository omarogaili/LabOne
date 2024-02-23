internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ange ditt namn");
        string? yourName = Console.ReadLine();
        ReverseString(yourName);
        Console.WriteLine(ReverseString(yourName));
        // Random rnd= new Random(); // skapar en random för att få ut en kast.
        // int rollOne= rnd.Next(6);
        // int rollTwo= rnd.Next(6);
        // int rollThree= rnd.Next(6);
        //  if(rollOne== rollTwo)
        // {
        //     Console.WriteLine("Du fick två "+ rollOne+" "+ rollTwo+"på täning Första och Andra" +" och en "+ rollThree);
        // }
        // else if(rollTwo == rollThree){
        //         Console.WriteLine("Du fick två "+  rollTwo+  " " +rollThree + " på täning Andra och tredje"+ " en "+ rollOne );
        //     }
        //     else if(rollOne == rollThree){
        //         Console.WriteLine("Du fick två "+ rollOne+ " " +rollThree+"på täning Första och tredje" +" en "+ rollTwo );

        //     }
        // // else if(rollOne== rollTwo || rollTwo== rollThree|| rollOne== rollThree){
        // //     Console.WriteLine("Du fick två "+ rollOne+" "+ rollTwo+ " "+ rollThree);
        // // }
        // else{
        //     Console.WriteLine("Du fick "+ rollOne+ " och "+rollTwo + " "+ rollThree );
        // }
      
    //     switch(rollOne, rollTwo, rollThree)
    //     {
    //         case 1:
    //         if(rollOne== rollTwo )
    //     {
    //         Console.WriteLine("Du fick två "+ rollOne+" "+ rollTwo
    //         );
    //     }
    //         break;
    //         case 2:
    //         if(rollOne== rollThree )
    //     {
    //         Console.WriteLine("Du fick två "+ rollOne+" "+ rollThree);
    //     }
    //         break; 
    //         case 3:
    //         if(rollTwo== rollThree )
    //     {
    //         Console.WriteLine("Du fick två "+ rollTwo+" "+ rollThree);
    //     }
    //         break; //
    //         default:
    //         Console.WriteLine("Du fick "+ rollOne+ ", "+rollTwo + " och "+ rollThree );
    //         break; //
    //     }
    // for (int i = 1;i < 100;i++)
    // {
    //     var text= i.ToString();
    //     if(i % 3 == 0 && i % 5==0 && text.Contains("3"))
    //     {
    //         Console.WriteLine("FizzBuzz Fizz");
    //     }
    //     else if(i % 3 == 0 && i % 5==0 && text.Contains("5"))
    //     {
    //         Console.WriteLine("FizzBuzz Buzz");
    //     }
    //     else if(i % 3 == 0 && i % 5==0)
    //     {
    //         Console.WriteLine("FizzBuzz");
    //     }
    //     else if(i % 3== 0)
    //     {
    //         Console.WriteLine("Fizz");
    //     }
    //     else if(i % 5 ==0)
    //     {
    //         Console.WriteLine("Buzz");
    //     }
    //     else if(text.Contains("3"))
    //     {
    //         Console.WriteLine("Fizz");
    //     }
    //     else if( text.Contains("5"))
    //     {
    //         Console.WriteLine("Buzz 5");
    //     }
    //     else if(text.Contains("3") && text.Contains("5"))
    //     {
    //         Console.WriteLine("BuzzFizzBuzz 3 och 5");
    //     }
    //     // kollar om ett siffra innehåller en 3 alltså 53 innehåller en 3 och då ska vi skriva fizz
         
    //     else
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    }
    public static string ReverseString (String yourName){
        char[] reversed= yourName.ToCharArray();
        Array.Reverse (reversed);
        string revString= new string(reversed);
        return revString;
    }
}