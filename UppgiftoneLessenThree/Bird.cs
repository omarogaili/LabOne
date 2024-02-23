namespace UppgiftoneLessenThree;

public class Bird : Animal
    {
        public Bird(string name) : base("Bird", name)
        {
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Pip Pip! Jag är en fågel vid namn " + this.name + ".");
        }

        public override string MakeSound()
        {
            return "Pip pip!";
        }

        public override void Fly()
        {
            Console.WriteLine("Flax flax, jag flaxar med vingarna!");
        }
    }
