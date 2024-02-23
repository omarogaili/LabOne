using Metoder;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ange ditt namn");
        string? yourName = Console.ReadLine();
        Console.WriteLine(ReverseString(yourName));
        List<DiaryEntry> mylist = new List<DiaryEntry>();
        while (true)
        {
            Console.WriteLine("1. Läs dagboksinlägg");
            Console.WriteLine("2. Skapa nytt dagboksinlägg");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj ett alternativ: ");
            int val = Convert.ToInt32(Console.ReadLine());
            switch (val)
            {
                case 1:
                    ReadEntry(mylist);
                    break;
                case 2:
                    CreateEntry(mylist);
                    break;
                case 3:
                    Console.WriteLine("Avslutar programmet...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
    public static string ReverseString(String yourName)
    {
        char[] reversed = yourName.ToCharArray();
        Array.Reverse(reversed);
        string revString = new string(reversed);
        return revString;
    }
    static void ReadEntry(List<DiaryEntry>mylist)
    {
        for (int i=0 ; i < mylist.Count ; i++){
            Console.WriteLine(mylist[i].Datum + " " + mylist[i].content+ " "+ mylist[i].rubric);
        }
    }

    static void CreateEntry(List<DiaryEntry>mylist)
    {
        Console.Write("Ange datumet: ");
        DateTime? datum = DateTime.Parse(Console.ReadLine());
        Console.Write("ange rubriken: ");
        string? rubric = Console.ReadLine();
        Console.Write("Skriv i din Dagbok: ");
        string? content = Console.ReadLine();
        mylist.Add(new DiaryEntry(datum, rubric, content));
    }
}
// the method which i should make it with a key and the key should match the rubric of the input. 
