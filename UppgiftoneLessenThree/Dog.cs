namespace UppgiftoneLessenThree;

public class Dog : Animal
{
    public Dog(string name) : base("Dog", name)
    {

    }

    public override void IntroduceYourself()
    {
        Console.WriteLine("Vovv!!! Jag är en hund som kallas " + this.name + ".");
    }

    public override string MakeSound()
    {
        return "Vov, vov, vovv!!!";
    }
}
