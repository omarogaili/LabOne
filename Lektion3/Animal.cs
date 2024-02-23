public class Animal
{
    public readonly string name;
    public readonly string type;
    public Animal(String type, String name)
    {
        this.name = name;
        this.type = type;
    }
    void introduceYourself() //create this in animal klass
    {
        // Hmm.....???
    }

    String makeSound() // 
    {
        return ""; //HMMMMM?????
    }

    void fly()
    {
        // ??? Whack 
    }

    internal static void SetYear(int v)
    {
        throw new NotImplementedException();
    }

    internal void SetFriend(Animal vilma)
    {
        throw new NotImplementedException();
    }

    internal void AddToy(Toy toy)
    {
        throw new NotImplementedException();
    }
}