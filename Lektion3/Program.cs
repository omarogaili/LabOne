dinternal class Program
{
    private static void Main(string[] args)
    {
        // for (int i = 0; i < 100; i++)
        // {
        //     Console.WriteLine(ByThree(i));
        // }
    }
    // static string ByThree(int key)
    // {
    //     string fizzes = "Fizz";
    //     string Buzz = "Buzz";
    //     string FizzBuzz = "FizzBuzz";
    //     string FizzBuzzBuzz = "FizzBuzzBuzz";
    //     if (key % 3 == 0 && key % 5 == 0)
    //     {
    //         return FizzBuzz;
    //     }
    //     else if (key % 5 == 0)
    //     {
    //         if (key == 35)
    //         {
    //             return FizzBuzzBuzz;
    //         }
    //         return Buzz;
    //     }
    //     else if (key % 3 == 0)
    //     {
    //         return fizzes;
    //     }
    //     else if (key == 53)
    //     {
    //         return FizzBuzz;
    //     }
    //     return key.ToString();
    // }
    
static void introduceYourself(Animal ani)
{

    if (ani.name.Equals("Cat"))
    {
        Console.WriteLine("Mjau. JAg är en katt som heter " + ani.name + ".");
    }
    else if (ani.type.Equals("Dog"))
    {
        Console.WriteLine("Vovv!!! Jag är en hund som kallas " + ani.name + ".");
    }
    else if (ani.type.Equals("Bird"))
    {
        Console.WriteLine("Pip Pip! Jag är en fågel vid namn " + ani.name + ".");
    }
    else if (ani.type.Equals("Butterfly"))
    {
        Console.WriteLine("Hej, jag är fjärilen " + ani.name + ".");
    }
    else
    {
        Console.WriteLine("Morr. Jag är ett djur som heter " + ani.name + ".");
    }

}

static String makeSound(Animal ani)
{
    if (ani.type.Equals("Cat"))
    {
        return "Purrrrrr";
    }
    else if (ani.type.Equals("Dog"))
    {
        return "Vov, vov, vovv!!!";
    }
    else if (ani.type.Equals("Bird"))
    {
        return "Pip pip!";
    }
    else
    {
        return "";
    }
}
static void fly(Animal ani)
{
    if (ani.type.Equals("Bird") || ani.type.Equals("Butterfly"))
    {
        Console.WriteLine("Flax flax, jag flaxar med vingarna!");
    }
    else
    {
        Console.WriteLine("Jag kan inte flyga!");
    }
}

Animal cat = new("Cat", "Kurre");
Animal dog = new Animal("Dog", "Vilma");
Animal bird = new Animal("Bird", "Pippi");
Animal butterfly = new Animal("Butterfly", "Bella");

Console.WriteLine("=== Djuren säger hej ===");
introduceYourself(cat);
introduceYourself(dog);
introduceYourself(bird);
introduceYourself(butterfly);


Console.WriteLine("==== Djuren gör sina ljud ====");
Animal[] AllAnimals = [cat, dog, bird, butterfly];
for (int i = 0; i < AllAnimals.Length; i++)
{
    Console.WriteLine(makeSound(AllAnimals[i]));
}
}
