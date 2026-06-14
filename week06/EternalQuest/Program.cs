class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eternal Quest Running...");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");

        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        Console.WriteLine($"You chose option {choice}");
    }
}