using System.ComponentModel;
using Lektionfyra;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Skriv ditt namn : ");
        string? name=Console.ReadLine();
        Console.Write("Skriv ditt efternamn : ");
        string? lastName= Console.ReadLine();
        Console.Write("Skriv din ålder :");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Skriv Email :");
        string? email=Console.ReadLine();
        Console.Write("ange ditt lösenord :");
        string? password=Console.ReadLine();
        int health=100;
        string? attack=Console.ReadLine();
        List<Person> person = new List<Person>();
        person.Add(new Person(name,lastName, age, email, password,health));
        Person b= new Person(name,lastName, age, email, password, health);
        b.EnterYourName();
        b.AgeControl();
        b.HealthCheck(health,attack);
    }
}