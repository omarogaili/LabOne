using System.Globalization;

namespace UppgiftoneLessenThree;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Static void IntroduceYourself(Animal ani)
        // {
        //     if (ani.name.Equals("Cat"))
        //     {
        //         Console.WriteLine("Mjau. JAg är en katt som heter " + ani.name + ".");
        //     }Butterfly();
        //     else if (ani.type.Equals("Dog"))
        //     {
        //         Console.WriteLine("Vovv!!! Jag är en hund som kallas " + ani.name + ".");
        //     }
        //     else if (ani.type.Equals("Bird"))
        //     {
        //         Console.WriteLine("Pip Pip! Jag är en fågel vid namn " + ani.name + ".");
        //     }
        //     else if (ani.type.Equals("Butterfly"))
        //     {
        //         Console.WriteLine("Hej, jag är fjärilen " + ani.name + ".");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Morr. Jag är ett djur som heter " + ani.name + ".");
        //     }
        // }
        // static String makeSound(Animal ani)
        // {
        // if (ani.type.Equals("Cat"))
        // {
        //     return "Purrrrrr";
        // }
        // else if (ani.type.Equals("Dog"))
        // {
        //     return "Vov, vov, vovv!!!";
        // }
        // else if (ani.type.Equals("Bird"))
        // {
        //     return "Pip pip!";
        // }
        // else
        // {
        //     return "";
        // }
        // }
        // static void fly(Animal ani)
        // {
        //     // if (ani.type.Equals("Bird") || ani.type.Equals("Butterfly"))
        //     // {
        //     //     Console.WriteLine("Flax flax, jag flaxar med vingarna!");
        //     // }
        //     // else
        //     // {
        //     //     Console.WriteLine("Jag kan inte flyga!");
        //     // }
        // }
        Cat cat = new Cat("Cat"); //create a new cat /object
        Dog  dog = new Dog("Dog");
        Bird bird = new Bird("Bird");
        Butterfly butterfly = new ("Butterfly");
        Console.WriteLine("=== Djuren säger hej ===");
        cat.IntroduceYourself();
        dog.IntroduceYourself();
        bird.IntroduceYourself();
        butterfly.IntroduceYourself();
        Console.WriteLine("==== Djuren gör sina ljud ====");
        // Animal[] AllAnimals = [cat, dog, bird, butterfly];
        // for (int i = 0; i < AllAnimals.Length; i++)
        // {
        //     Console.WriteLine(MakeSound(AllAnimals[i]));
        // }
    }
}