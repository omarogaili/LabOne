namespace UppgiftoneLessenThree;

public class Cat : Animal
    {
        public Cat(string name) : base("Cat", name)
        {
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + this.name + ".");
        }

        public override string MakeSound()
        {
            return "Purrrrrr";
        }
    }
