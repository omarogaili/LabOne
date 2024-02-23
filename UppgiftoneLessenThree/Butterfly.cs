namespace UppgiftoneLessenThree;

public class Butterfly : Animal
    {
        public Butterfly(string name) : base("Butterfly", name)
        {
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Hej, jag är fjärilen " + this.name + ".");
        }
    }