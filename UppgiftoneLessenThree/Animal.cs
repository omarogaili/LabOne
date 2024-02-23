using System;

namespace UppgiftoneLessenThree
{
    public class Animal
    {
        public readonly string name;
        public readonly string type;

        public Animal(string type, string name)
        {
            this.name = name;
            this.type = type;
        }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine( $"the is {this.name}, {this.type } ");
        }

        public virtual string MakeSound()
        {
            return "";
        }

        public virtual void Fly()
        {
            if(type.Equals("Bird")){
                
                Console.WriteLine("Jag kan inte flyga!");
            }
            else if(type.Equals("Butterfly")){
            Console.WriteLine("Jag kan inte flyga!");
        }
    }
    }
}

    // public class Dog : Animal
    // {
    //     public Dog(string name) : base("Dog", name)
    //     {
    //     }

    //     public override void IntroduceYourself()
    //     {
    //         Console.WriteLine("Vovv!!! Jag är en hund som kallas " + this.name + ".");
    //     }

    //     public override string MakeSound()
    //     {
    //         return "Vov, vov, vovv!!!";
    //     }
    // }

    // public class Cat : Animal
    // {
    //     public Cat(string name) : base("Cat", name)
    //     {
    //     }

    //     public override void IntroduceYourself()
    //     {
    //         Console.WriteLine("Mjau. Jag är en katt som heter " + this.name + ".");
    //     }

    //     public override string MakeSound()
    //     {
    //         return "Purrrrrr";
    //     }
    // }

    // public class Bird : Animal
    // {
    //     public Bird(string name) : base("Bird", name)
    //     {
    //     }

    //     public override void IntroduceYourself()
    //     {
    //         Console.WriteLine("Pip Pip! Jag är en fågel vid namn " + this.name + ".");
    //     }

    //     public override string MakeSound()
    //     {
    //         return "Pip pip!";
    //     }

    //     public override void Fly()
    //     {
    //         Console.WriteLine("Flax flax, jag flaxar med vingarna!");
    //     }
    // }

    // public class Butterfly : Animal
    // {
    //     public Butterfly(string name) : base("Butterfly", name)
    //     {
    //     }

    //     public override void IntroduceYourself()
    //     {
    //         Console.WriteLine("Hej, jag är fjärilen " + this.name + ".");
    //     }
    // }

