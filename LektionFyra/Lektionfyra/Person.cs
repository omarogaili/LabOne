using Microsoft.VisualBasic;

namespace Lektionfyra;

public class Person
{
    string name;
    string lastName;
    int age;
    string email;
    string password;
    int health;
    // constructor
    public Person(){
// man skapar den Konstratur för att vi ska kunna skapa en till person så den används 
    }
    public Person(string name, string lasName, int age, string email, string password, int helth)
    {
        this.Name= name;
        this.LastName= lasName;
        this.Age= age;
        this.Email= email;
        this.Password= password;
        this.health =health;
     }
    public string Name{
        get { return name; }
        set { name = value; }
    }
    public int Age{
        get { return age; }
        set { age = value; }
    }
    public string LastName{
        get { return lastName; }
        set { lastName = value; }
    }
    public string Email{
        get { return email; }
        set { email = value; }
    }
    public string Password{
        get { return password; }
        set { password = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public void EnterYourName()
    {

        Console.WriteLine($"Hej på dig \u001b[32m{this.name} {this.LastName}\u001b[0m Här är det din \u001b[32m{this.Email}\u001b[0m och detta är din ålder \u001b[32m{this.Age}\u001b[0m ");
    }
    public void AgeControl()
    {
        int age= 18;
        if(age >= this.Age )
        {
            Console.WriteLine($"{this.Name} du är för ung mannen!");
        }
        else
        {
            Console.WriteLine($"{this.Name} du är Vuxen!");
        }
    }
    public void HealthCheck( int healthCheck, string hit )
    {
        int health=100;
        hit =Console.ReadLine();
        if(hit == "h")
        {
            int hitspoint= 10;
            healthCheck = health - hitspoint;
            this.Health= healthCheck;
            Console.WriteLine($"Du är skadad {this.Health}");
        }
        else if(hit== "H"){
            int hitspoint= 50;
            healthCheck = health - hitspoint;
            this.Health= healthCheck;
            Console.WriteLine($"Du är skadad {this.Health}");
        }
    
        if(healthCheck == 0){
            Console.WriteLine("Du är DÖD");
        }
        else{
            Console.WriteLine($"{this.HealthCheck}");
        }
    }
}
